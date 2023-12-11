namespace ZH2_M9PVND
{
    partial class FormShowAdd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonOk = new Button();
            buttonCancel = new Button();
            textBoxId = new TextBox();
            textBoxTitle = new TextBox();
            textBoxRelease = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxType = new ComboBox();
            comboBoxRating = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.CausesValidation = false;
            buttonOk.Location = new Point(312, 497);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.CausesValidation = false;
            buttonCancel.Location = new Point(59, 497);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(255, 33);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(132, 23);
            textBoxId.TabIndex = 2;
            textBoxId.Validating += textBoxId_Validating;
            textBoxId.Validated += textBoxId_Validated;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(255, 114);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(132, 23);
            textBoxTitle.TabIndex = 3;
            textBoxTitle.Validating += textBoxTitle_Validating;
            textBoxTitle.Validated += textBoxTitle_Validated;
            // 
            // textBoxRelease
            // 
            textBoxRelease.Location = new Point(255, 268);
            textBoxRelease.Name = "textBoxRelease";
            textBoxRelease.Size = new Size(132, 23);
            textBoxRelease.TabIndex = 4;
            textBoxRelease.Validating += textBoxRelease_Validating;
            textBoxRelease.Validated += textBoxRelease_Validated;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(266, 344);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 6;
            // 
            // comboBoxRating
            // 
            comboBoxRating.FormattingEnabled = true;
            comboBoxRating.Location = new Point(266, 426);
            comboBoxRating.Name = "comboBoxRating";
            comboBoxRating.Size = new Size(121, 23);
            comboBoxRating.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "Show Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 99);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Dateadded";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 268);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 11;
            label4.Text = "Releaseyear";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 352);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 12;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 429);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 13;
            label6.Text = "Rating";
            // 
            // FormShowAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 571);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRating);
            Controls.Add(comboBoxType);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxRelease);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxId);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormShowAdd";
            Text = "FormShowAdd";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        public TextBox textBoxId;
        public TextBox textBoxTitle;
        public TextBox textBoxRelease;
        public DateTimePicker dateTimePicker1;
        public ComboBox comboBoxType;
        public ComboBox comboBoxRating;
        private ErrorProvider errorProvider1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}