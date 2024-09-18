namespace JasonCProject_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblPlayer1Name = new Label();
            lblPlayer1Health = new Label();
            lblPlayer1AttackStrength = new Label();
            txtPlayer1Name = new TextBox();
            txtPlayer1Health = new TextBox();
            txtPlayer1AttackStrength = new TextBox();
            lblPlayer2Name = new Label();
            lblPlayer2Health = new Label();
            lblPlayer2AttackStrength = new Label();
            lstOut = new ListBox();
            btnCalculateHealth = new Button();
            btnClearAll = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(425, 59);
            label1.MinimumSize = new Size(115, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Trading Card Game ";
            label1.Click += label1_Click;
            // 
            // lblPlayer1Name
            // 
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.Location = new Point(188, 115);
            lblPlayer1Name.Name = "lblPlayer1Name";
            lblPlayer1Name.Size = new Size(94, 15);
            lblPlayer1Name.TabIndex = 1;
            lblPlayer1Name.Text = "Player's 1 Name:";
            // 
            // lblPlayer1Health
            // 
            lblPlayer1Health.AutoSize = true;
            lblPlayer1Health.Location = new Point(185, 147);
            lblPlayer1Health.Name = "lblPlayer1Health";
            lblPlayer1Health.Size = new Size(97, 15);
            lblPlayer1Health.TabIndex = 2;
            lblPlayer1Health.Text = "Player's 1 Health:";
            // 
            // lblPlayer1AttackStrength
            // 
            lblPlayer1AttackStrength.AutoSize = true;
            lblPlayer1AttackStrength.Location = new Point(140, 181);
            lblPlayer1AttackStrength.Name = "lblPlayer1AttackStrength";
            lblPlayer1AttackStrength.Size = new Size(147, 15);
            lblPlayer1AttackStrength.TabIndex = 3;
            lblPlayer1AttackStrength.Text = "Player's 1 Attack Strength: ";
            // 
            // txtPlayer1Name
            // 
            txtPlayer1Name.Location = new Point(302, 107);
            txtPlayer1Name.Name = "txtPlayer1Name";
            txtPlayer1Name.Size = new Size(100, 23);
            txtPlayer1Name.TabIndex = 4;
            // 
            // txtPlayer1Health
            // 
            txtPlayer1Health.Location = new Point(302, 139);
            txtPlayer1Health.Name = "txtPlayer1Health";
            txtPlayer1Health.Size = new Size(100, 23);
            txtPlayer1Health.TabIndex = 5;
            // 
            // txtPlayer1AttackStrength
            // 
            txtPlayer1AttackStrength.Location = new Point(302, 173);
            txtPlayer1AttackStrength.Name = "txtPlayer1AttackStrength";
            txtPlayer1AttackStrength.Size = new Size(100, 23);
            txtPlayer1AttackStrength.TabIndex = 6;
            // 
            // lblPlayer2Name
            // 
            lblPlayer2Name.AutoSize = true;
            lblPlayer2Name.Location = new Point(641, 115);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(97, 15);
            lblPlayer2Name.TabIndex = 7;
            lblPlayer2Name.Text = "Player's 2 Name: ";
            // 
            // lblPlayer2Health
            // 
            lblPlayer2Health.AutoSize = true;
            lblPlayer2Health.Location = new Point(638, 147);
            lblPlayer2Health.Name = "lblPlayer2Health";
            lblPlayer2Health.Size = new Size(100, 15);
            lblPlayer2Health.TabIndex = 8;
            lblPlayer2Health.Text = "Player's 2 Health: ";
            // 
            // lblPlayer2AttackStrength
            // 
            lblPlayer2AttackStrength.AutoSize = true;
            lblPlayer2AttackStrength.Location = new Point(591, 181);
            lblPlayer2AttackStrength.Name = "lblPlayer2AttackStrength";
            lblPlayer2AttackStrength.Size = new Size(147, 15);
            lblPlayer2AttackStrength.TabIndex = 9;
            lblPlayer2AttackStrength.Text = "Player's 2 Attack Strength: ";
            lblPlayer2AttackStrength.Click += label7_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(188, 224);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(619, 199);
            lstOut.TabIndex = 10;
            // 
            // btnCalculateHealth
            // 
            btnCalculateHealth.Location = new Point(131, 476);
            btnCalculateHealth.Name = "btnCalculateHealth";
            btnCalculateHealth.Size = new Size(194, 23);
            btnCalculateHealth.TabIndex = 11;
            btnCalculateHealth.Text = "Calculate &Player's 1 Health";
            btnCalculateHealth.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(387, 476);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(194, 23);
            btnClearAll.TabIndex = 12;
            btnClearAll.Text = "&Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(638, 476);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(194, 23);
            btnQuit.TabIndex = 13;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 551);
            Controls.Add(btnQuit);
            Controls.Add(btnClearAll);
            Controls.Add(btnCalculateHealth);
            Controls.Add(lstOut);
            Controls.Add(lblPlayer2AttackStrength);
            Controls.Add(lblPlayer2Health);
            Controls.Add(lblPlayer2Name);
            Controls.Add(txtPlayer1AttackStrength);
            Controls.Add(txtPlayer1Health);
            Controls.Add(txtPlayer1Name);
            Controls.Add(lblPlayer1AttackStrength);
            Controls.Add(lblPlayer1Health);
            Controls.Add(lblPlayer1Name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Label lblPlayer1Name;
        private Label lblPlayer1Health;
        private Label lblPlayer1AttackStrength;
        private TextBox txtPlayer1Name;
        private TextBox txtPlayer1Health;
        private TextBox txtPlayer1AttackStrength;
        private Label lblPlayer2Name;
        private Label lblPlayer2Health;
        private Label lblPlayer2AttackStrength;
        private ListBox lstOut;
        private Button btnCalculateHealth;
        private Button btnClearAll;
        private Button btnQuit;
    }
}
