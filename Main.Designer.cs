namespace Developer_Assistant
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome = new System.Windows.Forms.Label();
            this.hardwareButton = new System.Windows.Forms.Button();
            this.softwareButton = new System.Windows.Forms.Button();
            this.setingsButton = new System.Windows.Forms.Button();
            this.timerButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.Software = new System.Windows.Forms.Panel();
            this.flowLayoutSoftwarePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Hardware = new System.Windows.Forms.Panel();
            this.welcomeHardware = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel.SuspendLayout();
            this.Software.SuspendLayout();
            this.Hardware.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Timer.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AccessibleDescription = "";
            this.welcome.AccessibleName = "";
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.welcome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome.Location = new System.Drawing.Point(-1, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(1007, 63);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome Developer!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardwareButton
            // 
            this.hardwareButton.BackColor = System.Drawing.Color.Teal;
            this.hardwareButton.ForeColor = System.Drawing.Color.White;
            this.hardwareButton.Location = new System.Drawing.Point(493, 3);
            this.hardwareButton.Name = "hardwareButton";
            this.hardwareButton.Size = new System.Drawing.Size(239, 60);
            this.hardwareButton.TabIndex = 1;
            this.hardwareButton.Text = "Hardware Manager";
            this.hardwareButton.UseVisualStyleBackColor = false;
            this.hardwareButton.Click += new System.EventHandler(this.HardwareButton_Click);
            // 
            // softwareButton
            // 
            this.softwareButton.BackColor = System.Drawing.Color.Teal;
            this.softwareButton.ForeColor = System.Drawing.Color.White;
            this.softwareButton.Location = new System.Drawing.Point(248, 3);
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.Size = new System.Drawing.Size(239, 60);
            this.softwareButton.TabIndex = 2;
            this.softwareButton.Text = "Software Manager";
            this.softwareButton.UseVisualStyleBackColor = false;
            this.softwareButton.Click += new System.EventHandler(this.SoftwareButton_Click);
            // 
            // setingsButton
            // 
            this.setingsButton.BackColor = System.Drawing.Color.Teal;
            this.setingsButton.ForeColor = System.Drawing.Color.White;
            this.setingsButton.Location = new System.Drawing.Point(738, 3);
            this.setingsButton.Name = "setingsButton";
            this.setingsButton.Size = new System.Drawing.Size(237, 60);
            this.setingsButton.TabIndex = 4;
            this.setingsButton.Text = "Settings";
            this.setingsButton.UseVisualStyleBackColor = false;
            this.setingsButton.Click += new System.EventHandler(this.SetingsButton_Click);
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.Color.Teal;
            this.timerButton.ForeColor = System.Drawing.Color.White;
            this.timerButton.Location = new System.Drawing.Point(3, 3);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(239, 60);
            this.timerButton.TabIndex = 3;
            this.timerButton.Text = "Timer Manager";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Software);
            this.mainPanel.Controls.Add(this.Hardware);
            this.mainPanel.Controls.Add(this.Settings);
            this.mainPanel.Controls.Add(this.Timer);
            this.mainPanel.Location = new System.Drawing.Point(4, 131);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1002, 557);
            this.mainPanel.TabIndex = 6;
            // 
            // Software
            // 
            this.Software.Controls.Add(this.flowLayoutSoftwarePanel);
            this.Software.Location = new System.Drawing.Point(0, 0);
            this.Software.Name = "Software";
            this.Software.Size = new System.Drawing.Size(978, 557);
            this.Software.TabIndex = 8;
            this.Software.Visible = false;
            // 
            // flowLayoutSoftwarePanel
            // 
            this.flowLayoutSoftwarePanel.Location = new System.Drawing.Point(-8, 0);
            this.flowLayoutSoftwarePanel.Name = "flowLayoutSoftwarePanel";
            this.flowLayoutSoftwarePanel.Size = new System.Drawing.Size(1002, 557);
            this.flowLayoutSoftwarePanel.TabIndex = 3;
            // 
            // Hardware
            // 
            this.Hardware.Controls.Add(this.welcomeHardware);
            this.Hardware.Location = new System.Drawing.Point(0, 0);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(978, 557);
            this.Hardware.TabIndex = 7;
            this.Hardware.Visible = false;
            // 
            // welcomeHardware
            // 
            this.welcomeHardware.AutoSize = true;
            this.welcomeHardware.Location = new System.Drawing.Point(436, 267);
            this.welcomeHardware.Name = "welcomeHardware";
            this.welcomeHardware.Size = new System.Drawing.Size(115, 13);
            this.welcomeHardware.TabIndex = 0;
            this.welcomeHardware.Text = "Welcome in Hardware!";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label3);
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(978, 557);
            this.Settings.TabIndex = 9;
            this.Settings.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welcome in Settings!";
            // 
            // Timer
            // 
            this.Timer.Controls.Add(this.label2);
            this.Timer.Location = new System.Drawing.Point(0, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(978, 557);
            this.Timer.TabIndex = 7;
            this.Timer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome in Timer!";
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.timerButton);
            this.navigationPanel.Controls.Add(this.softwareButton);
            this.navigationPanel.Controls.Add(this.hardwareButton);
            this.navigationPanel.Controls.Add(this.setingsButton);
            this.navigationPanel.Location = new System.Drawing.Point(12, 63);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(981, 68);
            this.navigationPanel.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1005, 700);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.mainPanel.ResumeLayout(false);
            this.Software.ResumeLayout(false);
            this.Hardware.ResumeLayout(false);
            this.Hardware.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Timer.ResumeLayout(false);
            this.Timer.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button hardwareButton;
        private System.Windows.Forms.Button softwareButton;
        private System.Windows.Forms.Button setingsButton;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel Hardware;
        private System.Windows.Forms.Panel Software;
        private System.Windows.Forms.Panel Timer;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label welcomeHardware;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutSoftwarePanel;
        private System.Windows.Forms.FlowLayoutPanel navigationPanel;
    }
}

