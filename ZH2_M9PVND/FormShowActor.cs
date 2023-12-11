using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_M9PVND.Models;

namespace ZH2_M9PVND
{
    public partial class FormShowActor : Form
    {

        MyContext context = new MyContext();

        public FormShowActor()
        {
            InitializeComponent();
            Fill();
            Fillszerep();
        }

        private void textBoxShow_TextChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            var show = from x in context.Shows
                       where x.Title.StartsWith(textBoxShow.Text)
                       select x;
            listBoxShow.DataSource = show.ToList();
            listBoxShow.DisplayMember = "Title";

            var actor = from x in context.Actors
                        where x.ActorName.StartsWith(textBoxActor.Text)
                        select x;
            listBoxActor.DataSource = actor.ToList();
            listBoxActor.DisplayMember = "Actorname";
        }

        private void textBoxActor_TextChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void listBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fillszerep();
        }

        private void Fillszerep()
        {
            var selectedshow = (Show)listBoxShow.SelectedItem;

            var szereplés = from x in context.ShowActors
                            where x.ShowId == selectedshow.ShowId
                            select new ShowActorDetail
                            {
                                Id = x.ShowActorId,

                                Name = x.Actor.ActorName
                            };
            listBoxSzerep.DataSource = szereplés.ToList();
            listBoxSzerep.DisplayMember = "Name";
            listBoxSzerep.ValueMember = "Id";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            var show = (Show)listBoxShow.SelectedItem;
            var actor = (Actor)listBoxActor.SelectedItem;

            ShowActor showactor = new ShowActor();

            showactor.ShowId = show.ShowId;
            showactor.ActorId = actor.ActorId;

            context.ShowActors.Add(showactor);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Fillszerep();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            var valami = (ShowActorDetail)listBoxSzerep.SelectedItem;

            var törlendő = (from x in context.ShowActors
                            where x.ShowActorId == valami.Id
                            select x).FirstOrDefault();
            context.Remove(törlendő);
            if (MessageBox.Show("Biztos ki akarod törölni", "törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                Fillszerep();
            }
        }
    }

    public class ShowActorDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
