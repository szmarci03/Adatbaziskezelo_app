namespace ZH2_M9PVND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos bezárnád?", "kilépés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlShow userControlShow = new UserControlShow();
            panel1.Controls.Add(userControlShow);
            userControlShow.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShowActor actor = new FormShowActor();
            actor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlRating rating = new UserControlRating();
            panel1.Controls.Add(rating);
            rating.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControlType type = new UserControlType();
            panel1.Controls.Add(type);
            type.Dock = DockStyle.Fill;
        }
    }
}