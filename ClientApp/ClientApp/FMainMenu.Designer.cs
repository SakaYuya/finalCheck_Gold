
namespace ClientApp
{
    partial class FMainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            this.goldRateLabel = new System.Windows.Forms.Label();
            this.datetimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.goldDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goldRateLabel
            // 
            this.goldRateLabel.AutoSize = true;
            this.goldRateLabel.BackColor = System.Drawing.Color.Khaki;
            this.goldRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldRateLabel.ForeColor = System.Drawing.Color.Black;
            this.goldRateLabel.Location = new System.Drawing.Point(12, 9);
            this.goldRateLabel.Name = "goldRateLabel";
            this.goldRateLabel.Size = new System.Drawing.Size(411, 73);
            this.goldRateLabel.TabIndex = 1;
            this.goldRateLabel.Text = "GOLD RATE";
            // 
            // datetimePicker
            // 
            this.datetimePicker.BorderRadius = 10;
            this.datetimePicker.Checked = true;
            this.datetimePicker.CheckedState.Parent = this.datetimePicker;
            this.datetimePicker.CustomFormat = "MM/dd/yyyy";
            this.datetimePicker.FillColor = System.Drawing.Color.Khaki;
            this.datetimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.datetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimePicker.HoverState.Parent = this.datetimePicker;
            this.datetimePicker.Location = new System.Drawing.Point(12, 130);
            this.datetimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimePicker.Name = "datetimePicker";
            this.datetimePicker.ShadowDecoration.Parent = this.datetimePicker;
            this.datetimePicker.Size = new System.Drawing.Size(249, 52);
            this.datetimePicker.TabIndex = 2;
            this.datetimePicker.Value = new System.DateTime(2021, 12, 24, 0, 0, 0, 0);
            this.datetimePicker.ValueChanged += new System.EventHandler(this.datetimePicker_ValueChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AllowDrop = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownHeight = 400;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.DropDownWidth = 200;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.Khaki;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "--All--",
            "",
            "",
            "",
            "",
            ""});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(341, 146);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(113, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 3;
            this.guna2ComboBox1.Tag = "";
            this.guna2ComboBox1.SelectedValueChanged += new System.EventHandler(this.guna2ComboBox1_SelectedValueChanged);
            this.guna2ComboBox1.Click += new System.EventHandler(this.guna2ComboBox1_Click);
            // 
            // goldDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.goldDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.goldDataGridView.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.goldDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goldDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.goldDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goldDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.goldDataGridView.ColumnHeadersHeight = 40;
            this.goldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buy,
            this.sell,
            this.company,
            this.Brand,
            this.Updated,
            this.Brand1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goldDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.goldDataGridView.EnableHeadersVisualStyles = false;
            this.goldDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.Location = new System.Drawing.Point(12, 203);
            this.goldDataGridView.Name = "goldDataGridView";
            this.goldDataGridView.RowHeadersVisible = false;
            this.goldDataGridView.RowHeadersWidth = 51;
            this.goldDataGridView.RowTemplate.Height = 24;
            this.goldDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goldDataGridView.Size = new System.Drawing.Size(934, 538);
            this.goldDataGridView.TabIndex = 4;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.goldDataGridView.ThemeStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.goldDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.goldDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.goldDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.goldDataGridView.ThemeStyle.ReadOnly = false;
            this.goldDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.goldDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.goldDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.goldDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.goldDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.goldDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // buy
            // 
            this.buy.HeaderText = "Buy";
            this.buy.Name = "buy";
            this.buy.ReadOnly = true;
            // 
            // sell
            // 
            this.sell.HeaderText = "Sell";
            this.sell.Name = "sell";
            this.sell.ReadOnly = true;
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Updated
            // 
            this.Updated.HeaderText = "Updated";
            this.Updated.Name = "Updated";
            this.Updated.ReadOnly = true;
            // 
            // Brand1
            // 
            this.Brand1.HeaderText = "Brand1";
            this.Brand1.Name = "Brand1";
            this.Brand1.ReadOnly = true;
            // 
            // searchButton
            // 
            this.searchButton.BorderRadius = 10;
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.DisabledState.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.Khaki;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Location = new System.Drawing.Point(527, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(156, 45);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BorderRadius = 10;
            this.resetButton.CheckedState.Parent = this.resetButton;
            this.resetButton.CustomImages.Parent = this.resetButton;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.DisabledState.Parent = this.resetButton;
            this.resetButton.FillColor = System.Drawing.Color.Khaki;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.HoverState.Parent = this.resetButton;
            this.resetButton.Location = new System.Drawing.Point(734, 137);
            this.resetButton.Name = "resetButton";
            this.resetButton.ShadowDecoration.Parent = this.resetButton;
            this.resetButton.Size = new System.Drawing.Size(141, 45);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusLabel.Location = new System.Drawing.Point(944, 147);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(207, 36);
            this.serverStatusLabel.TabIndex = 7;
            this.serverStatusLabel.Text = "Server Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.statusTextBox.DefaultText = "";
            this.statusTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.statusTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.statusTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusTextBox.DisabledState.Parent = this.statusTextBox;
            this.statusTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.statusTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusTextBox.FocusedState.Parent = this.statusTextBox;
            this.statusTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusTextBox.HoverState.Parent = this.statusTextBox;
            this.statusTextBox.Location = new System.Drawing.Point(952, 203);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.PasswordChar = '\0';
            this.statusTextBox.PlaceholderText = "";
            this.statusTextBox.SelectedText = "";
            this.statusTextBox.ShadowDecoration.Parent = this.statusTextBox;
            this.statusTextBox.Size = new System.Drawing.Size(294, 451);
            this.statusTextBox.TabIndex = 10;
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
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
            this.exitButton.Location = new System.Drawing.Point(1039, 671);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(138, 61);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1053, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "username:";
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1256, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.goldDataGridView);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.datetimePicker);
            this.Controls.Add(this.goldRateLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1274, 800);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOLD RATE";
            ((System.ComponentModel.ISupportInitialize)(this.goldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label goldRateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView goldDataGridView;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox statusTextBox;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}