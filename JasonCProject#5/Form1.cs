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
            lstOut.Items.Clear();
            txtPlayer1Name.Focus();
        }

        private void btnCalculateHealth_Click(object sender, EventArgs e)
        {
            //Just Calculate the starting health of both players, then add or subtract from it, depending on each player's attack strength
            double healthRate = .0075;
            double health, totalHealth, healthAmount;
            string Player1Name;

            // input

            health = double.Parse(txtPlayer1Health.Text);
            Player1Name = txtPlayer1Name.Text;


            // processing

            healthAmount = health * healthRate;
            totalHealth = health + healthAmount;



            // output 

            lstOut.Items.Add("Player's 1 Name is: " + Player1Name);
            lstOut.Items.Add("Health is: " + health);
            lstOut.Items.Add("Health Amount is: " + healthAmount);
            lstOut.Items.Add("Total Health is: " + totalHealth);

            // This changes the focus to the clear button

            btnClearAll.Focus();


        }



        private void txtPlayer1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Name_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayer1Name_Enter(object sender, EventArgs e)
        {
            txtPlayer1Name.BackColor = Color.Yellow;
        }

        private void txtPlayer1Name_Leave(object sender, EventArgs e)
        {
            txtPlayer1Name.BackColor = SystemColors.Window;
        }

        private void txtPlayer1Health_Enter(object sender, EventArgs e)
        {
            txtPlayer1Health.BackColor = Color.Yellow;
        }

        private void txtPlayer1Health_Leave(object sender, EventArgs e)
        {
            txtPlayer1Health.BackColor = SystemColors.Window;
        }

        private void txtPlayer1AttackStrength_Enter(object sender, EventArgs e)
        {
            txtPlayer1AttackStrength.BackColor = Color.Yellow;
        }

        private void txtPlayer1AttackStrength_Leave(object sender, EventArgs e)
        {
            txtPlayer1AttackStrength.BackColor = SystemColors.Window;
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
