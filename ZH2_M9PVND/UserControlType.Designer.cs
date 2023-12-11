namespace ZH2_M9PVND
{
    partial class UserControlType
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
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateaddedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            releaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            showForTypeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showForTypeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(38, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, dateaddedDataGridViewTextBoxColumn, releaseDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn });
            dataGridView1.DataSource = showForTypeBindingSource;
            dataGridView1.Location = new Point(207, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(533, 340);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateaddedDataGridViewTextBoxColumn
            // 
            dateaddedDataGridViewTextBoxColumn.DataPropertyName = "Dateadded";
            dateaddedDataGridViewTextBoxColumn.HeaderText = "Dateadded";
            dateaddedDataGridViewTextBoxColumn.Name = "dateaddedDataGridViewTextBoxColumn";
            // 
            // releaseDataGridViewTextBoxColumn
            // 
            releaseDataGridViewTextBoxColumn.DataPropertyName = "Release";
            releaseDataGridViewTextBoxColumn.HeaderText = "Release";
            releaseDataGridViewTextBoxColumn.Name = "releaseDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.DataSource = showForTypeBindingSource;
            ratingDataGridViewTextBoxColumn.DisplayMember = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            ratingDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // showForTypeBindingSource
            // 
            showForTypeBindingSource.DataSource = typeof(ShowForType);
            // 
            // UserControlType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Name = "UserControlType";
            Size = new Size(796, 509);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showForTypeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private DataGridView dataGridView1;
        private BindingSource showForTypeBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateaddedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn releaseDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn ratingDataGridViewTextBoxColumn;
    }
}
