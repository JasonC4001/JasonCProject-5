using System.Diagnostics.Eventing.Reader;
//Jason Chen - ICA 7

namespace JasonCProject_5
{
    public partial class Form1 : Form
    {
        private string PowerUps;
        const string p1_HEALTH = "Add Health";
        const string p1_STRENGTH = "Add Strength";
        const string p1_NORMAL = "No Power Ups";
        private string TradingGameLog = "TradingGameLog.txt";
        private string CardGameConfig = "CardGameConfig.txt";

        private double HealthPowerUpAmount = 10;
        private double StrengthPowerUpAmount = 15;
        private double NormalPowerUpAmount = 0;

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
            // This will quit the form. Quitting the form doesn't always closes the program
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }
                
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
       
            double p1Health, p1Strength, p1DamageTaken, p1HealthLeft, p2Health;

            // h = Health, s = Strength
            double hPowerUpAmount = 0;
            double sPowerUpAmount = 0;
            double nPowerUpAmount = 0;

            string p1Name, p2Name;
            bool healthValid, strengthValid;

            // player 2 strength for now
            double p2Strength = 12;

            //declaring the StreamWriter
            StreamWriter sw;

            //Input
            p1Name = txtPlayer1Name.Text;
            p2Name = txtPlayer2Name.Text;

            
            // Parse converts string to double
            p2Health = double.Parse(txtPlayer2Health.Text);
            p2Strength = double.Parse(txtPlayer2AttackStrength.Text);


            // Convert Parse to TryParse
            healthValid = double.TryParse(txtPlayer1Health.Text, out p1Health);
            strengthValid = double.TryParse(txtPlayer1AttackStrength.Text, out p1Strength);


            if (healthValid && strengthValid)
            {
                switch (PowerUps)
                {
                    case p1_HEALTH:
                        hPowerUpAmount = HealthPowerUpAmount;
                        break;
                    case p1_STRENGTH:
                        sPowerUpAmount = StrengthPowerUpAmount;
                        break;
                    case p1_NORMAL:
                        nPowerUpAmount = NormalPowerUpAmount;
                        break;
                    default:
                        lstOut.Items.Add("Error; this should never happen.");
                        break;
                }

                //processing
                p1DamageTaken = p2Strength;
                p1Strength += sPowerUpAmount;
                p1HealthLeft = hPowerUpAmount + (p1Health - p1DamageTaken);
                p2Health -= p1Strength;

                //output
                lstOut.Items.Add("Player's 1 Name is: " + p1Name);
                lstOut.Items.Add("Power Up Selected: " + PowerUps);
                lstOut.Items.Add("Power Up Amount (Health): " + hPowerUpAmount);
                lstOut.Items.Add("Power Up Amount (Strength): " + sPowerUpAmount);

                lstOut.Items.Add(p1Name + "'s health is: " + p1Health.ToString("N2"));
                lstOut.Items.Add(p1Name + "'s strength is: " + p1Strength.ToString("N2"));
                lstOut.Items.Add(p1Name + " has taken: " + p1DamageTaken.ToString("N2") + " damage from Player 2");
                lstOut.Items.Add("Total Health is: " + p1HealthLeft.ToString("N2"));
                lstOut.Items.Add("");


                sw = File.AppendText(TradingGameLog);
                sw.WriteLine("************Beginning of Game Log at " + DateTime.Now.ToString("G") + "************");
                sw.WriteLine("Player's 1 Name is: " + p1Name);
                sw.WriteLine("Power Up Selected: " + PowerUps);
                sw.WriteLine("Power Up Amount (Health): " + hPowerUpAmount);
                sw.WriteLine("Power Up Amount (Strength): " + sPowerUpAmount);
                sw.WriteLine(p1Name + "'s health is: " + p1Health.ToString("N2"));
                sw.WriteLine(p1Name + "'s strength is: " + p1Strength.ToString("N2"));
                sw.WriteLine(p1Name + " has taken: " + p1DamageTaken.ToString("N2") + " damage from Player 2");
                sw.WriteLine("Total Health is: " + p1HealthLeft.ToString("N2"));
                sw.WriteLine("");

                sw.Close();

            }

            
            // Else statement if user enters an invalid response. 
            else
            {
                lstOut.Items.Add("Invalid response, please enter a numeric response for health and strength.");
            }


            /*
            //SAMPLE CODE (DON'T KEEP IN CODE) 
            DateTime t = DateTime.Now;
            lstOut.Items.Add(DateTime.Now.ToString("d"));
            lstOut.Items.Add(DateTime.Now.ToString("f"));
            lstOut.Items.Add(DateTime.Now.ToString("G"));
            */
            // If's and Else-If's statements whether Player 1 or 2 wins/loses, and both players draw or loses.           
            //if (p1HealthLeft <= 0)
            //{
            //lstOut.Items.Add("Player 2 Win! Player 1 has no remaining health");
            //}

            //else if (p1HealthLeft == p2HealthLeft)
            //{
            //
            //}

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

            rdoHealth.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;

            do
            {
                try
                {
                    reader = File.OpenText(CardGameConfig);
                    fileBad = false;

                    valValid = double.TryParse(reader.ReadLine(), out HealthPowerUpAmount);

                    valValid = double.TryParse(reader.ReadLine(), out StrengthPowerUpAmount);

                    valValid = double.TryParse(reader.ReadLine(), out NormalPowerUpAmount);

                    reader.Close();

                }
                catch (FileNotFoundException ex)
                {

                    MessageBox.Show("The configuration file was not found. Please select a different file.\n Error Message was: " +
                        ex.Message);
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();

                    //This code takes the file the user selected and puts it in the variable. 
                    CardGameConfig = openFileDialog1.FileName;
                }

            } while (fileBad);
          
        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHealth.Checked)
            {
                PowerUps  = p1_HEALTH;
            }
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStrength.Checked)
            {
                PowerUps = p1_STRENGTH;
            }
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNormal.Checked)
            {
                PowerUps = p1_NORMAL;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
