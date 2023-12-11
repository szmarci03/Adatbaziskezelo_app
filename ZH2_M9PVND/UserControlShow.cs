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
    public partial class UserControlShow : UserControl
    {

        MyContext context = new MyContext();

        public UserControlShow()
        {
            InitializeComponent();
            Filldata();
        }

        private void Filldata()
        {
            var show = from x in context.Shows
                       select new ShowDetail
                       {
                           Id = x.ShowId,
                           Title = x.Title,
                           Dateadded = x.DateAdded,
                           Release = x.ReleaseYear,
                           Rating = x.Rating.Ratingvalue,
                           Type = x.Type.Typename
                       };
            dataGridView1.DataSource = show.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShowAdd formShowAdd = new FormShowAdd();
            if (formShowAdd.ShowDialog()==DialogResult.OK)
            {
                Show show = new Show();
                show.ShowId = int.Parse(formShowAdd.textBoxId.Text);
                show.Title = formShowAdd.textBoxTitle.Text;
                show.DateAdded = formShowAdd.dateTimePicker1.Value;
                show.ReleaseYear = int.Parse(formShowAdd.textBoxRelease.Text);

                var értékelés = (Rating)formShowAdd.comboBoxRating.SelectedItem;
                var típus = (Models.Type)formShowAdd.comboBoxType.SelectedItem;

                show.RatingId = értékelés.RatingId;
                show.TypeId = típus.TypeId;

                context.Shows.Add(show);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Filldata();
            }
        }
    }

    public class ShowDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Release { get; set; }
        public string Type { get; set; }
        public string Rating { get; set; }
    }
}
