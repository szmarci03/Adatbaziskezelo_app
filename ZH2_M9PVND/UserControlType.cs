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
    public partial class UserControlType : UserControl
    {

        MyContext context = new MyContext();

        public UserControlType()
        {
            InitializeComponent();
            Filltype();
        }

        private void Filltype()
        {
            var típus = from x in context.Types
                        select x;
            listBox1.DataSource = típus.ToList();
            listBox1.DisplayMember = "Typename";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var típus = (Models.Type)listBox1.SelectedItem;

            var show = from x in context.Shows
                       where x.TypeId == típus.TypeId
                       select new ShowForType
                       {
                           Id = x.ShowId,
                           Title = x.Title,
                           Dateadded = x.DateAdded,
                           Release = x.ReleaseYear,
                           Rating = x.Rating.Ratingvalue
                       };
            showForTypeBindingSource.DataSource = show.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class ShowForType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? Release { get; set; }
        public string Rating { get; set; }
    }
}
