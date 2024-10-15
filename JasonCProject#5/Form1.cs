using System.Diagnostics.Eventing.Reader;

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
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show("Are you sure you want to Quit?", "Quitting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ButtonSelected == DialogResult.Yes)
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
            //Calculate the starting health of both players, then add or subtract depending on each player's attack strength.
            //double p2Strength = .050;
            double p1Health, strength, p1HealthLeft, damageTaken;
            string p1Name, p2Name;
            bool healthValid, strengthValid;

            // player 2 strength for now 
            double p2Strength = 12;

            // Input
            //health = double.Parse(txtPlayer1Health.Text);
            p1Name = txtPlayer1Name.Text;
            p2Name = txtPlayer2Name.Text;


            // Parse converts string to double
            // Convert Parse to TryParse
            healthValid = double.TryParse(txtPlayer1Health.Text, out p1Health);
            strengthValid = double.TryParse(txtPlayer1AttackStrength.Text, out strength);


            // Processing
            damageTaken = p2Strength;
            p1HealthLeft = p1Health - damageTaken;


            // Output
            if (healthValid && strengthValid)
            {
                lstOut.Items.Add("Player's 1 Name is: " + p1Name);
                lstOut.Items.Add(p1Name + "'s health is: " + p1Health.ToString("N2"));
                lstOut.Items.Add(p1Name + "'s strength is: " + strength.ToString("N2"));
                lstOut.Items.Add(p1Name + " has taken: " + damageTaken.ToString("N2") + " damage from Player 2");
                lstOut.Items.Add("Total Health is: " + p1HealthLeft.ToString("N2"));

            }

            // Else statement if user enters an invalid response. 
            else
            {
                lstOut.Items.Add("Invalid response, please enter a numeric response for health and strength.");
            }

            // If's and Else-If's statements whether Player 1 or 2 wins/loses, and both players draw or loses.           

            if (p1HealthLeft <= 0)
            {
                lstOut.Items.Add("Player 2 Wins! Player 1 has no remaining health.");
            }

            //else if (p1HealthLeft == p2HealthLeft) {}



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

        private void Form1_Load(object sender, EventArgs e)
        {

            rdo1.Checked = true;

        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo1.Checked)
            {
                
            }
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
