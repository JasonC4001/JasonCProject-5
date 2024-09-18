namespace JasonCProject_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtPlayer1Name.Clear(); 
            txtPlayer1Health.Clear();   
            txtPlayer1AttackStrength.Clear();

        }
    }
}
