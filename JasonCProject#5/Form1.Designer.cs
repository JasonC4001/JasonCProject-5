﻿namespace JasonCProject_5
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
            lblPlayer1Health = new Label();
            lblPlayer1AttackStrength = new Label();
            txtPlayer1Health = new TextBox();
            txtPlayer1AttackStrength = new TextBox();
            lblPlayer2Health = new Label();
            lblPlayer2AttackStrength = new Label();
            lstOut = new ListBox();
            btnCalculateHealth = new Button();
            btnClearAll = new Button();
            btnQuit = new Button();
            lblPlayer1Name = new Label();
            txtPlayer1Name = new TextBox();
            lblPlayer2Name = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(358, 28);
            label1.MinimumSize = new Size(115, 20);
            label1.Name = "label1";
            label1.Size = new Size(270, 37);
            label1.TabIndex = 0;
            label1.Text = "Trading Card Game ";
            label1.Click += label1_Click;
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
            lblPlayer1AttackStrength.Location = new Point(140, 176);
            lblPlayer1AttackStrength.Name = "lblPlayer1AttackStrength";
            lblPlayer1AttackStrength.Size = new Size(147, 15);
            lblPlayer1AttackStrength.TabIndex = 3;
            lblPlayer1AttackStrength.Text = "Player's 1 Attack Strength: ";
            // 
            // txtPlayer1Health
            // 
            txtPlayer1Health.Location = new Point(302, 144);
            txtPlayer1Health.Name = "txtPlayer1Health";
            txtPlayer1Health.Size = new Size(100, 23);
            txtPlayer1Health.TabIndex = 5;
            txtPlayer1Health.Enter += txtPlayer1Health_Enter;
            txtPlayer1Health.Leave += txtPlayer1Health_Leave;
            // 
            // txtPlayer1AttackStrength
            // 
            txtPlayer1AttackStrength.Location = new Point(302, 173);
            txtPlayer1AttackStrength.Name = "txtPlayer1AttackStrength";
            txtPlayer1AttackStrength.Size = new Size(100, 23);
            txtPlayer1AttackStrength.TabIndex = 6;
            txtPlayer1AttackStrength.Enter += txtPlayer1AttackStrength_Enter;
            txtPlayer1AttackStrength.Leave += txtPlayer1AttackStrength_Leave;
            // 
            // lblPlayer2Health
            // 
            lblPlayer2Health.AutoSize = true;
            lblPlayer2Health.Location = new Point(632, 147);
            lblPlayer2Health.Name = "lblPlayer2Health";
            lblPlayer2Health.Size = new Size(100, 15);
            lblPlayer2Health.TabIndex = 8;
            lblPlayer2Health.Text = "Player's 2 Health: ";
            // 
            // lblPlayer2AttackStrength
            // 
            lblPlayer2AttackStrength.AutoSize = true;
            lblPlayer2AttackStrength.Location = new Point(591, 173);
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
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalculateHealth
            // 
            btnCalculateHealth.Location = new Point(131, 476);
            btnCalculateHealth.Name = "btnCalculateHealth";
            btnCalculateHealth.Size = new Size(194, 23);
            btnCalculateHealth.TabIndex = 11;
            btnCalculateHealth.Text = "Calculate &Player's 1 Health";
            btnCalculateHealth.UseVisualStyleBackColor = true;
            btnCalculateHealth.Click += btnCalculateHealth_Click;
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
            // lblPlayer1Name
            // 
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.Location = new Point(188, 118);
            lblPlayer1Name.Name = "lblPlayer1Name";
            lblPlayer1Name.Size = new Size(94, 15);
            lblPlayer1Name.TabIndex = 1;
            lblPlayer1Name.Text = "Player's 1 Name:";
            lblPlayer1Name.Click += lblPlayer1Name_Click;
            // 
            // txtPlayer1Name
            // 
            txtPlayer1Name.BackColor = SystemColors.Window;
            txtPlayer1Name.ForeColor = SystemColors.WindowText;
            txtPlayer1Name.Location = new Point(302, 115);
            txtPlayer1Name.Name = "txtPlayer1Name";
            txtPlayer1Name.Size = new Size(100, 23);
            txtPlayer1Name.TabIndex = 4;
            txtPlayer1Name.TextChanged += txtPlayer1Name_TextChanged;
            txtPlayer1Name.Enter += txtPlayer1Name_Enter;
            txtPlayer1Name.Leave += txtPlayer1Name_Leave;
            // 
            // lblPlayer2Name
            // 
            lblPlayer2Name.AutoSize = true;
            lblPlayer2Name.Location = new Point(638, 118);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(94, 15);
            lblPlayer2Name.TabIndex = 7;
            lblPlayer2Name.Text = "Player's 2 Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 551);
            Controls.Add(lblPlayer2Name);
            Controls.Add(txtPlayer1Name);
            Controls.Add(lblPlayer1Name);
            Controls.Add(btnQuit);
            Controls.Add(btnClearAll);
            Controls.Add(btnCalculateHealth);
            Controls.Add(lstOut);
            Controls.Add(lblPlayer2AttackStrength);
            Controls.Add(lblPlayer2Health);
            Controls.Add(txtPlayer1AttackStrength);
            Controls.Add(txtPlayer1Health);
            Controls.Add(lblPlayer1AttackStrength);
            Controls.Add(lblPlayer1Health);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private Label lblPlayer1Health;
        private Label lblPlayer1AttackStrength;
        private TextBox txtPlayer1Health;
        private TextBox txtPlayer1AttackStrength;
        private Label lblPlayer2Health;
        private Label lblPlayer2AttackStrength;
        private ListBox lstOut;
        private Button btnCalculateHealth;
        private Button btnClearAll;
        private Button btnQuit;
        private Label lblPlayer1Name;
        private TextBox txtPlayer1Name;
        private Label lblPlayer2Name;
    }
}
