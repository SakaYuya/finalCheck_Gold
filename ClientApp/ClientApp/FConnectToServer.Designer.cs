
namespace ClientApp
{
    partial class FConnectToServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConnectToServer));
            this.goldImgPanel = new System.Windows.Forms.Panel();
            this.connectServerLabel = new System.Windows.Forms.Label();
            this.ipserverLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipserverTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.portTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.connectButton = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.stopButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // goldImgPanel
            // 
            this.goldImgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goldImgPanel.BackgroundImage")));
            this.goldImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goldImgPanel.Location = new System.Drawing.Point(38, 81);
            this.goldImgPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goldImgPanel.Name = "goldImgPanel";
            this.goldImgPanel.Size = new System.Drawing.Size(331, 420);
            this.goldImgPanel.TabIndex = 1;
            // 
            // connectServerLabel
            // 
            this.connectServerLabel.AutoSize = true;
            this.connectServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectServerLabel.Location = new System.Drawing.Point(58, 20);
            this.connectServerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectServerLabel.Name = "connectServerLabel";
            this.connectServerLabel.Size = new System.Drawing.Size(308, 39);
            this.connectServerLabel.TabIndex = 2;
            this.connectServerLabel.Text = "Connect to server";
            // 
            // ipserverLabel
            // 
            this.ipserverLabel.AutoSize = true;
            this.ipserverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipserverLabel.Location = new System.Drawing.Point(418, 81);
            this.ipserverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipserverLabel.Name = "ipserverLabel";
            this.ipserverLabel.Size = new System.Drawing.Size(95, 24);
            this.ipserverLabel.TabIndex = 4;
            this.ipserverLabel.Text = "IP Server";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(418, 196);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(47, 24);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // ipserverTextbox
            // 
            this.ipserverTextbox.BorderColor = System.Drawing.Color.Khaki;
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
            this.ipserverTextbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipserverTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipserverTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ipserverTextbox.HoverState.Parent = this.ipserverTextbox;
            this.ipserverTextbox.Location = new System.Drawing.Point(422, 116);
            this.ipserverTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipserverTextbox.Name = "ipserverTextbox";
            this.ipserverTextbox.PasswordChar = '\0';
            this.ipserverTextbox.PlaceholderText = "";
            this.ipserverTextbox.SelectedText = "";
            this.ipserverTextbox.ShadowDecoration.Parent = this.ipserverTextbox;
            this.ipserverTextbox.Size = new System.Drawing.Size(186, 46);
            this.ipserverTextbox.TabIndex = 6;
            // 
            // portTextbox
            // 
            this.portTextbox.BorderColor = System.Drawing.Color.Khaki;
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
            this.portTextbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.portTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.portTextbox.HoverState.Parent = this.portTextbox;
            this.portTextbox.Location = new System.Drawing.Point(422, 232);
            this.portTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.PasswordChar = '\0';
            this.portTextbox.PlaceholderText = "";
            this.portTextbox.SelectedText = "";
            this.portTextbox.SelectionStart = 4;
            this.portTextbox.ShadowDecoration.Parent = this.portTextbox;
            this.portTextbox.Size = new System.Drawing.Size(186, 46);
            this.portTextbox.TabIndex = 7;
            // 
            // connectButton
            // 
            this.connectButton.BorderRadius = 20;
            this.connectButton.CheckedState.Parent = this.connectButton;
            this.connectButton.CustomImages.Parent = this.connectButton;
            this.connectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.connectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.connectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.connectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.connectButton.DisabledState.Parent = this.connectButton;
            this.connectButton.FillColor = System.Drawing.Color.Khaki;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.Black;
            this.connectButton.HoverState.Parent = this.connectButton;
            this.connectButton.Location = new System.Drawing.Point(422, 340);
            this.connectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.ShadowDecoration.Parent = this.connectButton;
            this.connectButton.Size = new System.Drawing.Size(186, 50);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BorderRadius = 20;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Orange;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(512, 452);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(104, 50);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BorderRadius = 20;
            this.stopButton.CheckedState.Parent = this.stopButton;
            this.stopButton.CustomImages.Parent = this.stopButton;
            this.stopButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stopButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stopButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stopButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stopButton.DisabledState.Parent = this.stopButton;
            this.stopButton.FillColor = System.Drawing.Color.Khaki;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.HoverState.Parent = this.stopButton;
            this.stopButton.Location = new System.Drawing.Point(422, 452);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.ShadowDecoration.Parent = this.stopButton;
            this.stopButton.Size = new System.Drawing.Size(82, 50);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // FConnectToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(669, 539);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.ipserverTextbox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipserverLabel);
            this.Controls.Add(this.connectServerLabel);
            this.Controls.Add(this.goldImgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(686, 584);
            this.Name = "FConnectToServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOLD RATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goldImgPanel;
        private System.Windows.Forms.Label connectServerLabel;
        private System.Windows.Forms.Label ipserverLabel;
        private System.Windows.Forms.Label portLabel;
        private Guna.UI2.WinForms.Guna2TextBox ipserverTextbox;
        private Guna.UI2.WinForms.Guna2TextBox portTextbox;
        private Guna.UI2.WinForms.Guna2Button connectButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button stopButton;
    }
}