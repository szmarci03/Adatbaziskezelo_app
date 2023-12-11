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
    public partial class UserControlRating : UserControl
    {

        MyContext context = new MyContext();

        public UserControlRating()
        {
            InitializeComponent();
            Fillrating();
            Showload();
        }

        private void Fillrating()
        {
            var rating = from x in context.Ratings
                         select x;
            listBoxrating.DataSource = rating.ToList();
            listBoxrating.DisplayMember = "Ratingvalue";
        }

        private void listBoxrating_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showload();
        }

        private void Showload()
        {
            var értékelés = (Rating)listBoxrating.SelectedItem;

            var show = from x in context.Shows
                       where x.RatingId == értékelés.RatingId
                       && x.DateAdded == dateTimePicker1.Value
                       select new ShowForRating
                       {
                           Id = x.ShowId,
                           Title = x.Title,
                           Dateadded = x.DateAdded
                       };
            showForRatingBindingSource.DataSource = show.ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Showload();
        }
    }

    public class ShowForRating
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime? Dateadded { get; set; }
    }
}
