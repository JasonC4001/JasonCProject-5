using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasonCProject_5
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            ff = form1;
            InitializeComponent();
        }

        private void lblHealth_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set&Return Button ^

            bool healthValid, strengthValid, normalValid;
            int hTempValue, sTempValue, nTempValue;

            StreamWriter sw;

            healthValid = int.TryParse(txtHealthValue.Text, out hTempValue);
            strengthValid = int.TryParse(txtStrengthValue.Text, out sTempValue);
            normalValid = int.TryParse(txtNormalValue.Text, out nTempValue);  

            if (healthValid && strengthValid && normalValid)
            {
                //if values are valid, set properties
                ff.HealthPowerUpAmount = hTempValue;
                ff.StrengthPowerUpAmount = sTempValue;
                ff.NormalPowerUpAmount = nTempValue;

                //Now save values to file
                sw = File.CreateText(ff.CardGameConfig);
                sw.WriteLine(ff.HealthPowerUpAmount);
                sw.WriteLine(ff.StrengthPowerUpAmount);
                sw.WriteLine(ff.NormalPowerUpAmount);

                sw.Close();

                //this code will go back to form 1
                this.Hide();

            }
            else
            {
                //If the values are NOT valid,
                //replace all text box values with current values
                ff.setValuesOnSecondForm();
            }
           
        }
    }
}
