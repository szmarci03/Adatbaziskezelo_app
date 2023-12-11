namespace ZH2_M9PVND
{
    partial class FormShowActor
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
            listBoxShow = new ListBox();
            listBoxSzerep = new ListBox();
            listBoxActor = new ListBox();
            textBoxShow = new TextBox();
            textBoxActor = new TextBox();
            buttonPlus = new Button();
            buttonMinus = new Button();
            SuspendLayout();
            // 
            // listBoxShow
            // 
            listBoxShow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxShow.FormattingEnabled = true;
            listBoxShow.ItemHeight = 15;
            listBoxShow.Location = new Point(22, 85);
            listBoxShow.Name = "listBoxShow";
            listBoxShow.Size = new Size(120, 289);
            listBoxShow.TabIndex = 0;
            listBoxShow.SelectedIndexChanged += listBoxShow_SelectedIndexChanged;
            // 
            // listBoxSzerep
            // 
            listBoxSzerep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            listBoxSzerep.FormattingEnabled = true;
            listBoxSzerep.ItemHeight = 15;
            listBoxSzerep.Location = new Point(247, 85);
            listBoxSzerep.Name = "listBoxSzerep";
            listBoxSzerep.Size = new Size(120, 289);
            listBoxSzerep.TabIndex = 1;
            // 
            // listBoxActor
            // 
            listBoxActor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxActor.FormattingEnabled = true;
            listBoxActor.ItemHeight = 15;
            listBoxActor.Location = new Point(643, 85);
            listBoxActor.Name = "listBoxActor";
            listBoxActor.Size = new Size(120, 289);
            listBoxActor.TabIndex = 2;
            // 
            // textBoxShow
            // 
            textBoxShow.Location = new Point(22, 29);
            textBoxShow.Name = "textBoxShow";
            textBoxShow.Size = new Size(120, 23);
            textBoxShow.TabIndex = 3;
            textBoxShow.TextChanged += textBoxShow_TextChanged;
            // 
            // textBoxActor
            // 
            textBoxActor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxActor.Location = new Point(643, 29);
            textBoxActor.Name = "textBoxActor";
            textBoxActor.Size = new Size(120, 23);
            textBoxActor.TabIndex = 4;
            textBoxActor.TextChanged += textBoxActor_TextChanged;
            // 
            // buttonPlus
            // 
            buttonPlus.Anchor = AnchorStyles.Top;
            buttonPlus.Location = new Point(464, 85);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 66);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Anchor = AnchorStyles.Bottom;
            buttonMinus.Location = new Point(464, 308);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 66);
            buttonMinus.TabIndex = 6;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // FormShowActor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(textBoxActor);
            Controls.Add(textBoxShow);
            Controls.Add(listBoxActor);
            Controls.Add(listBoxSzerep);
            Controls.Add(listBoxShow);
            Name = "FormShowActor";
            Text = "FormShowActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxShow;
        private ListBox listBoxSzerep;
        private ListBox listBoxActor;
        private TextBox textBoxShow;
        private TextBox textBoxActor;
        private Button buttonPlus;
        private Button buttonMinus;
    }
}