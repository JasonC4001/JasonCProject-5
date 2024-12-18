using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms.VisualStyles;

//Name: Jason Chen 
//Prof. Frary 
//CIS 152

namespace JasonCProject_5
{
    public partial class Form1 : Form
    {
        //health, strength, and damage taken of player 1 
        private int p1Health, p1Strength, p1DamageTaken, p1DamageTakenTotal;
        
        //Intital starting health and strength for Player 2
        private int p2Health = 80;
        private int p2Strength = 12;

        //Random number for p2health and p2Strength
        private Random p2RandomHealth = new Random();
        private Random p2RandomStrength  = new Random();
        
        private string PowerUps;
        const string P1_HEALTH = "ADD HEALTH";
        const string P1_STRENGTH = "ADD STRENGTH";
        const string P1_NORMAL = "NO POWER UP";
        private string TradingGameLog = "TradingGameLog.txt";
        public string CardGameConfig = "CardGameConfig.txt";

        private int healthPowerUpAmount = 10;
        private int strengthPowerUpAmount = 15;
        private int normalPowerUpAmount = 0;

        //declare Form2
        private Form2 SettingsForm;

        public int HealthPowerUpAmount
        {
            get { return healthPowerUpAmount; }
            set { healthPowerUpAmount = value; }
        }

        public int StrengthPowerUpAmount
        {
            get { return strengthPowerUpAmount; }
            set { strengthPowerUpAmount = value; }
        }

        public int NormalPowerUpAmount
        {
            get { return normalPowerUpAmount; }
            set { normalPowerUpAmount = value; }
        }

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
            //Asks for confirmation if user really wants to quit. 
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
            //Set p2Health and p2Strength to 0 so it can generate new values for a new game. 
            p2Health = 0;
            p2Strength = 0;

            //Resets all P1 damage taken to 0 for new game. 
            p1DamageTaken = 0;

            //Allows users to enter new values after clicking 'Clear All'.
            txtPlayer1Health.ReadOnly = false;
            txtPlayer1AttackStrength.ReadOnly = false;

            //Clears all textbox and listbox when user clicks the 'Clear All' button. 
            txtPlayer1Name.Clear();
            txtPlayer1Health.Clear();
            txtPlayer1AttackStrength.Clear();
            lstOut.Items.Clear();

            //Brings focus into Player 1 Name Textbox and the Radio Health button if user selected another radio button. 
            txtPlayer1Name.Focus();
            rdoHealth.Focus();
     
            //Generates new values for Player's 2 health and strength for the new game 
            if (p2Health <= 0 && p2Strength <=0)
            {
                p2Health = p2RandomHealth.Next(80, 300);
                p2Strength = p2RandomStrength.Next(10, 150);
            }
            
            //Changes the string inside the textbox for Player's 2 health and strength 
            txtPlayer2Health.Text = p2Health.ToString();
            txtPlayer2AttackStrength.Text = p2Strength.ToString();
        }

        private void btnCalculateHealth_Click(object sender, EventArgs e)
        {
            string p1Name, p2Name;
            bool healthValid, strengthValid;

            // h = Health, s = Strength, n = Normal
            int hPowerUpAmount = 0;
            int sPowerUpAmount = 0;
            int nPowerUpAmount = 0;
    
            //declaring the StreamWriter
            StreamWriter sw;

            //Input (Note: p2Name is not in use since the text boxes for player 2 inputs are set to 'readonly' and they are randomly generated values. 
            p1Name = txtPlayer1Name.Text;
            p2Name = txtPlayer2Name.Text;

            // Convert Parse to TryParse
            healthValid = int.TryParse(txtPlayer1Health.Text, out p1Health);
            strengthValid = int.TryParse(txtPlayer1AttackStrength.Text, out p1Strength);

            if (healthValid && strengthValid)
            {
                //prevents players from modifing the values after starting the game and calculating the health.
                //To restart with new value, user must start a new game by clicking 'Clear All'. 
                txtPlayer1Health.ReadOnly = true;  
                txtPlayer1AttackStrength.ReadOnly = true;

                switch (PowerUps)
                {
                    case P1_HEALTH:
                        hPowerUpAmount = healthPowerUpAmount;
                        break;
                    case P1_STRENGTH:
                        sPowerUpAmount = strengthPowerUpAmount;
                        break;
                    case P1_NORMAL:
                        nPowerUpAmount = normalPowerUpAmount;
                        break;
                    default:
                        lstOut.Items.Add("Error; this should never happen.");
                        break;
                }

                //processing (Add or subtract each player's health depending on each player's strength.) 

                //Player 1 Strength adds if player selects 'Add Strength' Radio button
                p1Strength += sPowerUpAmount;

                //IGNORE
                //p1DamageTaken -= p2Strength;
                //p1HealthLeft = p1Health + (p1DamageTaken - hPowerUpAmount);
                //p1HealthLeft += hPowerUpAmount;

                //Calculates and hold the value of how muhc P1 damage has taken for output. 
                p1DamageTakenTotal = hPowerUpAmount - p2Strength;

                //Player 1 decrease each round based on player's 2 attack strength until a player wins or ties. 
                p1DamageTaken += hPowerUpAmount - p2Strength;
                p1Health += p1DamageTaken;
                
                //Brings inital Player 2 health, saves p2 health from previous rounds, and continues to decrease each round until a player wins or ties. 
                p2Health -= p1Strength;

                //After each round, the number in the player's 2 health textbox changes to the corresponding health value
                txtPlayer2Health.Text = p2Health.ToString();

                //output (Note: 'lstOut.Items.Add("");' are blank lines so it's not too clustered inside the form. 
                lstOut.Items.Add("Player's 1 Name is: " + p1Name);
                lstOut.Items.Add("Power Up Selected: " + PowerUps);
                lstOut.Items.Add("Power Up Amount (Health): " + hPowerUpAmount);
                lstOut.Items.Add("Power Up Amount (Strength): " + sPowerUpAmount);
                lstOut.Items.Add(p1Name + "'s health is: " + p1Health);
                lstOut.Items.Add(p1Name + "'s strength is: " + p1Strength);
                lstOut.Items.Add(p1Name + " has taken: " + p1DamageTakenTotal + " damage from Player 2");
                lstOut.Items.Add("Player 1 dealt " + p1Strength + " damage to Player 2!");
                lstOut.Items.Add("");
                lstOut.Items.Add("Player's 1 remaining Health is: " + p1Health);
                lstOut.Items.Add("Player 2 has " + p2Health + " health remaining");
     
                //Output determines if a player has won, or both has died and tied. 
                if (p1Health <= 0 && p2Health <= 0)
                {
                    lstOut.Items.Add("It's a tie!");
                    lstOut.Items.Add("");
                }
                else if (p1Health <= 0)
                {
                    lstOut.Items.Add("Player 2 Wins! ");
                    lstOut.Items.Add("");
                }
                else if (p2Health <= 0)
                {
                    lstOut.Items.Add("Player 1 Wins!");
                    lstOut.Items.Add("");
                }
                else
                {
                    lstOut.Items.Add("No one has won yet.");
                    lstOut.Items.Add("");
                }

                //Saves results to seperate file. 

                sw = File.AppendText(TradingGameLog);
                sw.WriteLine("************Beginning of Game Log at " + DateTime.Now.ToString("G") + "************");
                sw.WriteLine("Player's 1 Name is: " + p1Name);
                sw.WriteLine("Power Up Selected: " + PowerUps);
                sw.WriteLine("Power Up Amount (Health): " + hPowerUpAmount);
                sw.WriteLine("Power Up Amount (Strength): " + sPowerUpAmount);
                sw.WriteLine(p1Name + "'s health is: " + p1Health);
                sw.WriteLine(p1Name + "'s strength is: " + p1Strength);
                sw.WriteLine(p1Name + " has taken: " + p1DamageTaken + " damage from Player 2");
                sw.WriteLine("Player's 1 remaining Health is: " + p1Health);
                sw.WriteLine("");
                sw.WriteLine("Player 1 dealt " + p1Strength + " damage to Player 2!");
                sw.WriteLine("Player 2 has " + p2Health + " health remaining");

                if (p1Health <= 0 && p2Health <= 0)
                {
                    sw.WriteLine("It's a tie!");
                    sw.WriteLine("");
                }
                else if (p1Health <= 0)
                {
                    sw.WriteLine("Player 2 Wins!");
                    sw.WriteLine("");
                }
                else if (p2Health <= 0)
                {
                    sw.WriteLine("Player 1 Wins!");
                    sw.WriteLine("");
                }
                else
                {
                    sw.WriteLine("No one has won yet.");
                    sw.WriteLine("");
                }

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
            SettingsForm = new Form2(this);

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
                    int tempValue;

                    valValid = int.TryParse(reader.ReadLine(), out tempValue);
                    HealthPowerUpAmount = tempValue;

                    valValid = int.TryParse(reader.ReadLine(), out tempValue);
                    StrengthPowerUpAmount = tempValue;

                    valValid = int.TryParse(reader.ReadLine(), out tempValue);
                    NormalPowerUpAmount = tempValue;


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
                PowerUps = P1_HEALTH;
            }
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStrength.Checked)
            {
                PowerUps = P1_STRENGTH;
            }
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNormal.Checked)
            {
                PowerUps = P1_NORMAL;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setValuesOnSecondForm();
            SettingsForm.ShowDialog();
        }

        public void setValuesOnSecondForm()
        {

            SettingsForm.txtHealthValue.Text = HealthPowerUpAmount.ToString();
            SettingsForm.txtStrengthValue.Text = StrengthPowerUpAmount.ToString();
            SettingsForm.txtNormalValue.Text = NormalPowerUpAmount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //increased from 2000 to 10000
            const int MAX_LOG_SIZE = 10000;

            string[] TradingLineLog = new string[MAX_LOG_SIZE];

            StreamReader sr = File.OpenText(TradingGameLog);

            int logNumLines = 0;
            while (!sr.EndOfStream)
            {
                TradingLineLog[logNumLines] = sr.ReadLine();
                logNumLines++;
            }

            sr.Close();

            for (int i = 0; i < logNumLines; i++) 
            {
                if (TradingLineLog[i] == "Power Up Selected: " + PowerUps) 
                {
                    for (int j = i-2; j <= i + 11; j++)
                    {
                        lstOut.Items.Add(TradingLineLog[j]);
                    }

                }
            }
        }
    }
}
