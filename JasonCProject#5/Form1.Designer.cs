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
            txtPlayer2Name = new TextBox();
            txtPlayer2Health = new TextBox();
            txtPlayer2AttackStrength = new TextBox();
            groupBox1 = new GroupBox();
            rdo3 = new RadioButton();
            rdo2 = new RadioButton();
            rdo1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(353, 9);
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
            lblPlayer1Health.Location = new Point(173, 92);
            lblPlayer1Health.Name = "lblPlayer1Health";
            lblPlayer1Health.Size = new Size(97, 15);
            lblPlayer1Health.TabIndex = 2;
            lblPlayer1Health.Text = "Player's 1 Health:";
            // 
            // lblPlayer1AttackStrength
            // 
            lblPlayer1AttackStrength.AutoSize = true;
            lblPlayer1AttackStrength.Location = new Point(128, 121);
            lblPlayer1AttackStrength.Name = "lblPlayer1AttackStrength";
            lblPlayer1AttackStrength.Size = new Size(147, 15);
            lblPlayer1AttackStrength.TabIndex = 3;
            lblPlayer1AttackStrength.Text = "Player's 1 Attack Strength: ";
            // 
            // txtPlayer1Health
            // 
            txtPlayer1Health.Location = new Point(290, 89);
            txtPlayer1Health.Name = "txtPlayer1Health";
            txtPlayer1Health.Size = new Size(100, 23);
            txtPlayer1Health.TabIndex = 5;
            txtPlayer1Health.Enter += txtPlayer1Health_Enter;
            txtPlayer1Health.Leave += txtPlayer1Health_Leave;
            // 
            // txtPlayer1AttackStrength
            // 
            txtPlayer1AttackStrength.Location = new Point(290, 121);
            txtPlayer1AttackStrength.Name = "txtPlayer1AttackStrength";
            txtPlayer1AttackStrength.Size = new Size(100, 23);
            txtPlayer1AttackStrength.TabIndex = 6;
            txtPlayer1AttackStrength.Enter += txtPlayer1AttackStrength_Enter;
            txtPlayer1AttackStrength.Leave += txtPlayer1AttackStrength_Leave;
            // 
            // lblPlayer2Health
            // 
            lblPlayer2Health.AutoSize = true;
            lblPlayer2Health.Location = new Point(591, 92);
            lblPlayer2Health.Name = "lblPlayer2Health";
            lblPlayer2Health.Size = new Size(100, 15);
            lblPlayer2Health.TabIndex = 8;
            lblPlayer2Health.Text = "Player's 2 Health: ";
            // 
            // lblPlayer2AttackStrength
            // 
            lblPlayer2AttackStrength.AutoSize = true;
            lblPlayer2AttackStrength.Location = new Point(544, 121);
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
            lstOut.Location = new Point(188, 250);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(619, 199);
            lstOut.TabIndex = 10;
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalculateHealth
            // 
            btnCalculateHealth.Location = new Point(140, 476);
            btnCalculateHealth.Name = "btnCalculateHealth";
            btnCalculateHealth.Size = new Size(194, 23);
            btnCalculateHealth.TabIndex = 11;
            btnCalculateHealth.Text = "Calculate &Player's 1 Health";
            btnCalculateHealth.UseVisualStyleBackColor = true;
            btnCalculateHealth.Click += btnCalculateHealth_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(404, 476);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(194, 23);
            btnClearAll.TabIndex = 12;
            btnClearAll.Text = "&Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(661, 476);
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
            lblPlayer1Name.Location = new Point(176, 63);
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
            txtPlayer1Name.Location = new Point(290, 60);
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
            lblPlayer2Name.Location = new Point(593, 63);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(94, 15);
            lblPlayer2Name.TabIndex = 7;
            lblPlayer2Name.Text = "Player's 2 Name:";
            // 
            // txtPlayer2Name
            // 
            txtPlayer2Name.Location = new Point(707, 60);
            txtPlayer2Name.Name = "txtPlayer2Name";
            txtPlayer2Name.ReadOnly = true;
            txtPlayer2Name.Size = new Size(100, 23);
            txtPlayer2Name.TabIndex = 14;
            txtPlayer2Name.Text = "Bot 1";
            // 
            // txtPlayer2Health
            // 
            txtPlayer2Health.Location = new Point(707, 89);
            txtPlayer2Health.Name = "txtPlayer2Health";
            txtPlayer2Health.ReadOnly = true;
            txtPlayer2Health.Size = new Size(100, 23);
            txtPlayer2Health.TabIndex = 15;
            txtPlayer2Health.Text = "46";
            // 
            // txtPlayer2AttackStrength
            // 
            txtPlayer2AttackStrength.Location = new Point(707, 121);
            txtPlayer2AttackStrength.Name = "txtPlayer2AttackStrength";
            txtPlayer2AttackStrength.ReadOnly = true;
            txtPlayer2AttackStrength.Size = new Size(100, 23);
            txtPlayer2AttackStrength.TabIndex = 16;
            txtPlayer2AttackStrength.Text = "12";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo3);
            groupBox1.Controls.Add(rdo2);
            groupBox1.Controls.Add(rdo1);
            groupBox1.Location = new Point(66, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(890, 71);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player's 1 Power Ups";
            // 
            // rdo3
            // 
            rdo3.AutoSize = true;
            rdo3.Location = new Point(647, 22);
            rdo3.Name = "rdo3";
            rdo3.Size = new Size(115, 19);
            rdo3.TabIndex = 2;
            rdo3.TabStop = true;
            rdo3.Text = "Perk 3: No Power";
            rdo3.UseVisualStyleBackColor = true;
            rdo3.CheckedChanged += rdo3_CheckedChanged;
            // 
            // rdo2
            // 
            rdo2.AutoSize = true;
            rdo2.Location = new Point(377, 22);
            rdo2.Name = "rdo2";
            rdo2.Size = new Size(133, 19);
            rdo2.TabIndex = 1;
            rdo2.TabStop = true;
            rdo2.Text = "Perk 2: Add Strength";
            rdo2.UseVisualStyleBackColor = true;
            rdo2.CheckedChanged += rdo2_CheckedChanged;
            // 
            // rdo1
            // 
            rdo1.AutoSize = true;
            rdo1.Location = new Point(107, 22);
            rdo1.Name = "rdo1";
            rdo1.Size = new Size(123, 19);
            rdo1.TabIndex = 0;
            rdo1.TabStop = true;
            rdo1.Text = "Perk 1: Add Health";
            rdo1.UseVisualStyleBackColor = true;
            rdo1.CheckedChanged += rdo1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 551);
            Controls.Add(groupBox1);
            Controls.Add(txtPlayer2AttackStrength);
            Controls.Add(txtPlayer2Health);
            Controls.Add(txtPlayer2Name);
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
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox txtPlayer2Name;
        private TextBox txtPlayer2Health;
        private TextBox txtPlayer2AttackStrength;
        private GroupBox groupBox1;
        private RadioButton rdo3;
        private RadioButton rdo2;
        private RadioButton rdo1;
    }
}
