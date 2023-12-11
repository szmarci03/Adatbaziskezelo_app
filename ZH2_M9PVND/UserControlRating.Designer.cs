namespace ZH2_M9PVND
{
    partial class UserControlRating
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxrating = new ListBox();
            listBoxshow = new ListBox();
            showForRatingBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)showForRatingBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBoxrating
            // 
            listBoxrating.FormattingEnabled = true;
            listBoxrating.ItemHeight = 15;
            listBoxrating.Location = new Point(49, 57);
            listBoxrating.Name = "listBoxrating";
            listBoxrating.Size = new Size(120, 349);
            listBoxrating.TabIndex = 0;
            listBoxrating.SelectedIndexChanged += listBoxrating_SelectedIndexChanged;
            // 
            // listBoxshow
            // 
            listBoxshow.DataSource = showForRatingBindingSource;
            listBoxshow.DisplayMember = "Title";
            listBoxshow.FormattingEnabled = true;
            listBoxshow.ItemHeight = 15;
            listBoxshow.Location = new Point(514, 117);
            listBoxshow.Name = "listBoxshow";
            listBoxshow.Size = new Size(175, 289);
            listBoxshow.TabIndex = 1;
            // 
            // showForRatingBindingSource
            // 
            showForRatingBindingSource.DataSource = typeof(ShowForRating);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(489, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 57);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 3;
            label1.Text = "2021 körüli dátumot érdemes választani";
            // 
            // UserControlRating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBoxshow);
            Controls.Add(listBoxrating);
            Name = "UserControlRating";
            Size = new Size(796, 509);
            ((System.ComponentModel.ISupportInitialize)showForRatingBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxrating;
        private ListBox listBoxshow;
        private DateTimePicker dateTimePicker1;
        private BindingSource showForRatingBindingSource;
        private Label label1;
    }
}
