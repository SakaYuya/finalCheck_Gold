
namespace ServerApp
{
    partial class FServerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FServerApp));
            this.clientActiBalel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.portServerLabel = new System.Windows.Forms.Label();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.ipserverTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.portTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.hcmuslogoGridPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.hcmuslogoPanel = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.clientActiTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientInUseTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // clientActiBalel
            // 
            this.clientActiBalel.AutoSize = true;
            this.clientActiBalel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientActiBalel.Location = new System.Drawing.Point(18, 94);
            this.clientActiBalel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientActiBalel.Name = "clientActiBalel";
            this.clientActiBalel.Size = new System.Drawing.Size(170, 24);
            this.clientActiBalel.TabIndex = 2;
            this.clientActiBalel.Text = "Client activitives: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clients in use: ";
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverIPLabel.Location = new System.Drawing.Point(18, 21);
            this.serverIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(107, 24);
            this.serverIPLabel.TabIndex = 4;
            this.serverIPLabel.Text = "Server IP: ";
            // 
            // portServerLabel
            // 
            this.portServerLabel.AutoSize = true;
            this.portServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portServerLabel.Location = new System.Drawing.Point(284, 21);
            this.portServerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portServerLabel.Name = "portServerLabel";
            this.portServerLabel.Size = new System.Drawing.Size(59, 24);
            this.portServerLabel.TabIndex = 5;
            this.portServerLabel.Text = "Port: ";
            // 
            // startButton
            // 
            this.startButton.BorderRadius = 10;
            this.startButton.CheckedState.Parent = this.startButton;
            this.startButton.CustomImages.Parent = this.startButton;
            this.startButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startButton.DisabledState.Parent = this.startButton;
            this.startButton.FillColor = System.Drawing.Color.Khaki;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.HoverState.Parent = this.startButton;
            this.startButton.Location = new System.Drawing.Point(441, 10);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.ShadowDecoration.Parent = this.startButton;
            this.startButton.Size = new System.Drawing.Size(91, 46);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ipserverTextbox
            // 
            this.ipserverTextbox.BorderRadius = 10;
            this.ipserverTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipserverTextbox.DefaultText = "127.0.0.1";
            this.ipserverTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ipserverTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ipserverTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ipserverTextbox.DisabledState.Parent = this.ipserverTextbox;
            this.ipserverTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ipserverTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ipserverTextbox.FocusedState.Parent = this.ipserverTextbox;
            this.ipserverTextbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipserverTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.ipserverTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ipserverTextbox.HoverState.Parent = this.ipserverTextbox;
            this.ipserverTextbox.Location = new System.Drawing.Point(116, 10);
            this.ipserverTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipserverTextbox.Name = "ipserverTextbox";
            this.ipserverTextbox.PasswordChar = '\0';
            this.ipserverTextbox.PlaceholderText = "";
            this.ipserverTextbox.SelectedText = "";
            this.ipserverTextbox.ShadowDecoration.Parent = this.ipserverTextbox;
            this.ipserverTextbox.Size = new System.Drawing.Size(162, 46);
            this.ipserverTextbox.TabIndex = 10;
            // 
            // portTextbox
            // 
            this.portTextbox.BorderRadius = 10;
            this.portTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portTextbox.DefaultText = "9000";
            this.portTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.portTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.portTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextbox.DisabledState.Parent = this.portTextbox;
            this.portTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextbox.FocusedState.Parent = this.portTextbox;
            this.portTextbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.portTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextbox.HoverState.Parent = this.portTextbox;
            this.portTextbox.Location = new System.Drawing.Point(336, 10);
            this.portTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.PasswordChar = '\0';
            this.portTextbox.PlaceholderText = "";
            this.portTextbox.SelectedText = "";
            this.portTextbox.SelectionStart = 4;
            this.portTextbox.ShadowDecoration.Parent = this.portTextbox;
            this.portTextbox.Size = new System.Drawing.Size(91, 46);
            this.portTextbox.TabIndex = 10;
            // 
            // hcmuslogoGridPanel
            // 
            this.hcmuslogoGridPanel.Location = new System.Drawing.Point(716, 10);
            this.hcmuslogoGridPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hcmuslogoGridPanel.Name = "hcmuslogoGridPanel";
            this.hcmuslogoGridPanel.ShadowDecoration.Parent = this.hcmuslogoGridPanel;
            this.hcmuslogoGridPanel.Size = new System.Drawing.Size(105, 98);
            this.hcmuslogoGridPanel.TabIndex = 9;
            // 
            // hcmuslogoPanel
            // 
            this.hcmuslogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcmuslogoPanel.BackgroundImage")));
            this.hcmuslogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hcmuslogoPanel.Location = new System.Drawing.Point(716, 10);
            this.hcmuslogoPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hcmuslogoPanel.Name = "hcmuslogoPanel";
            this.hcmuslogoPanel.Size = new System.Drawing.Size(105, 98);
            this.hcmuslogoPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BorderRadius = 10;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Orange;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(721, 549);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(130, 46);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clientActiTextbox
            // 
            this.clientActiTextbox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.clientActiTextbox.BorderRadius = 15;
            this.clientActiTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientActiTextbox.DefaultText = "";
            this.clientActiTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientActiTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientActiTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientActiTextbox.DisabledState.Parent = this.clientActiTextbox;
            this.clientActiTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientActiTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientActiTextbox.FocusedState.Parent = this.clientActiTextbox;
            this.clientActiTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientActiTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientActiTextbox.HoverState.Parent = this.clientActiTextbox;
            this.clientActiTextbox.Location = new System.Drawing.Point(22, 130);
            this.clientActiTextbox.Multiline = true;
            this.clientActiTextbox.Name = "clientActiTextbox";
            this.clientActiTextbox.PasswordChar = '\0';
            this.clientActiTextbox.PlaceholderText = "";
            this.clientActiTextbox.ReadOnly = true;
            this.clientActiTextbox.SelectedText = "";
            this.clientActiTextbox.ShadowDecoration.Parent = this.clientActiTextbox;
            this.clientActiTextbox.Size = new System.Drawing.Size(484, 414);
            this.clientActiTextbox.TabIndex = 11;
            this.clientActiTextbox.TextChanged += new System.EventHandler(this.clientActiTextbox_TextChanged);
            // 
            // clientInUseTextbox
            // 
            this.clientInUseTextbox.BorderRadius = 15;
            this.clientInUseTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientInUseTextbox.DefaultText = "";
            this.clientInUseTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientInUseTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientInUseTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientInUseTextbox.DisabledState.Parent = this.clientInUseTextbox;
            this.clientInUseTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientInUseTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.clientInUseTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientInUseTextbox.FocusedState.Parent = this.clientInUseTextbox;
            this.clientInUseTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInUseTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientInUseTextbox.HoverState.Parent = this.clientInUseTextbox;
            this.clientInUseTextbox.Location = new System.Drawing.Point(548, 130);
            this.clientInUseTextbox.Multiline = true;
            this.clientInUseTextbox.Name = "clientInUseTextbox";
            this.clientInUseTextbox.PasswordChar = '\0';
            this.clientInUseTextbox.PlaceholderText = "";
            this.clientInUseTextbox.ReadOnly = true;
            this.clientInUseTextbox.SelectedText = "";
            this.clientInUseTextbox.ShadowDecoration.Parent = this.clientInUseTextbox;
            this.clientInUseTextbox.Size = new System.Drawing.Size(303, 414);
            this.clientInUseTextbox.TabIndex = 13;
            this.clientInUseTextbox.TextChanged += new System.EventHandler(this.clientInUseTextbox_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.BorderRadius = 10;
            this.stopButton.CheckedState.Parent = this.stopButton;
            this.stopButton.CustomImages.Parent = this.stopButton;
            this.stopButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stopButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stopButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stopButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stopButton.DisabledState.Parent = this.stopButton;
            this.stopButton.Enabled = false;
            this.stopButton.FillColor = System.Drawing.Color.Khaki;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.HoverState.Parent = this.stopButton;
            this.stopButton.Location = new System.Drawing.Point(548, 10);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.ShadowDecoration.Parent = this.stopButton;
            this.stopButton.Size = new System.Drawing.Size(91, 46);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // FServerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(873, 609);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.clientInUseTextbox);
            this.Controls.Add(this.clientActiTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hcmuslogoPanel);
            this.Controls.Add(this.hcmuslogoGridPanel);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.ipserverTextbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.portServerLabel);
            this.Controls.Add(this.serverIPLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientActiBalel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(889, 657);
            this.MinimumSize = new System.Drawing.Size(889, 597);
            this.Name = "FServerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOLD RATE (Server)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clientActiBalel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serverIPLabel;
        private System.Windows.Forms.Label portServerLabel;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2TextBox ipserverTextbox;
        private Guna.UI2.WinForms.Guna2TextBox portTextbox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel hcmuslogoGridPanel;
        private System.Windows.Forms.Panel hcmuslogoPanel;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2TextBox clientActiTextbox;
        private Guna.UI2.WinForms.Guna2TextBox clientInUseTextbox;
        private Guna.UI2.WinForms.Guna2Button stopButton;
    
    }
}

