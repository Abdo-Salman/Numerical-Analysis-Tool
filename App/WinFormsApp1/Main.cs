namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Bisec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bisection f1 = new Bisection();
            f1.ShowDialog();
            f1 = null;
            this.Show();
        }

        private void FLP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FalsePosition f2 = new FalsePosition();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void SFP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SFP f3 = new SFP();
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void Nton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Newton f4 = new Newton();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }

        private void Sec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secant f5 = new Secant();
            f5.ShowDialog();
            f5 = null;
            this.Show();
        }

        private void LU_Click(object sender, EventArgs e)
        {
            this.Hide();
            LU f6 = new LU();
            f6.ShowDialog();
            f6 = null;
            this.Show();
        }

        private void GElim_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gauss f7 = new Gauss();
            f7.ShowDialog();
            f7 = null;
            this.Show();
        }

        private void Cram_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cramer f8 = new Cramer();
            f8.ShowDialog();
            f8 = null;
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }
    }
}