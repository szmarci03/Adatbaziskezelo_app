using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_M9PVND.Models;

namespace ZH2_M9PVND
{
    public partial class FormShowAdd : Form
    {

        MyContext context = new MyContext();

        public FormShowAdd()
        {
            InitializeComponent();
            Fillcombobox();
        }

        private void Fillcombobox()
        {
            var típus = from x in context.Types
                        select x;
            comboBoxType.DataSource = típus.ToList();
            comboBoxType.DisplayMember = "Typename";

            var értékelés = from x in context.Ratings
                            select x;
            comboBoxRating.DataSource = értékelés.ToList();
            comboBoxRating.DisplayMember = "Ratingvalue";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxId_Validating(object sender, CancelEventArgs e)
        {
            var létező = from x in context.Shows
                         select x.ShowId.ToString();
            if (létező.Contains(textBoxId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxId, "Létező ID");
            }
            Regex r = new Regex("^[0-9]+$");
            if (!r.IsMatch(textBoxId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxId, "Szám legyen");
            }
        }

        private void textBoxId_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxId, string.Empty);
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTitle, "Nem lehet üres");
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTitle, string.Empty);
        }

        private void textBoxRelease_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if (!r.IsMatch(textBoxRelease.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxRelease, "Szám legyen");
            }
        }

        private void textBoxRelease_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxRelease, string.Empty);
        }
    }
}
