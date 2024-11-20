namespace JasonCProject_5
{
    partial class Form2
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
            lblHealth = new Label();
            lblConfigSettings = new Label();
            label3 = new Label();
            txtHealthValue = new TextBox();
            txtStrengthValue = new TextBox();
            lblStrength = new Label();
            txtNormalValue = new TextBox();
            lblNormal = new Label();
            btnSetReturn = new Button();
            SuspendLayout();
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(117, 95);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(81, 15);
            lblHealth.TabIndex = 0;
            lblHealth.Text = "Health's Value";
            lblHealth.Click += lblHealth_Click;
            // 
            // lblConfigSettings
            // 
            lblConfigSettings.AutoSize = true;
            lblConfigSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConfigSettings.Location = new Point(172, 29);
            lblConfigSettings.Name = "lblConfigSettings";
            lblConfigSettings.Size = new Size(183, 21);
            lblConfigSettings.TabIndex = 1;
            lblConfigSettings.Text = "Configuration Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtHealthValue
            // 
            txtHealthValue.Location = new Point(213, 87);
            txtHealthValue.Name = "txtHealthValue";
            txtHealthValue.Size = new Size(100, 23);
            txtHealthValue.TabIndex = 3;
            // 
            // txtStrengthValue
            // 
            txtStrengthValue.Location = new Point(213, 135);
            txtStrengthValue.Name = "txtStrengthValue";
            txtStrengthValue.Size = new Size(100, 23);
            txtStrengthValue.TabIndex = 5;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(107, 143);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(91, 15);
            lblStrength.TabIndex = 4;
            lblStrength.Text = "Strength's Value";
            // 
            // txtNormalValue
            // 
            txtNormalValue.Location = new Point(213, 183);
            txtNormalValue.Name = "txtNormalValue";
            txtNormalValue.Size = new Size(100, 23);
            txtNormalValue.TabIndex = 7;
            // 
            // lblNormal
            // 
            lblNormal.AutoSize = true;
            lblNormal.Location = new Point(112, 191);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(86, 15);
            lblNormal.TabIndex = 6;
            lblNormal.Text = "Normal's Value";
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(189, 250);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(144, 27);
            btnSetReturn.TabIndex = 10;
            btnSetReturn.Text = "&Set && Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 368);
            Controls.Add(btnSetReturn);
            Controls.Add(txtNormalValue);
            Controls.Add(lblNormal);
            Controls.Add(txtStrengthValue);
            Controls.Add(lblStrength);
            Controls.Add(txtHealthValue);
            Controls.Add(label3);
            Controls.Add(lblConfigSettings);
            Controls.Add(lblHealth);
            Name = "Form2";
            Text = "Game's Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHealth;
        private Label lblConfigSettings;
        private Label label3;
        private Label lblStrength;
        private Label lblNormal;
        private Button btnSetReturn;
        public TextBox txtHealthValue;
        public TextBox txtStrengthValue;
        public TextBox txtNormalValue;
    }
}