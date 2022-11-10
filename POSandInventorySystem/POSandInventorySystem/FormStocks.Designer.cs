
namespace POSandInventorySystem
{
    partial class FormStocks
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
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addStocksButton = new System.Windows.Forms.Button();
            this.stockinstockoutButton = new System.Windows.Forms.Button();
            this.stockoutTextBox = new System.Windows.Forms.TextBox();
            this.clearcancelButton = new System.Windows.Forms.Button();
            this.updatestocksButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.stockinTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reorderlevelTextBox = new System.Windows.Forms.TextBox();
            this.saveupdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.unitmeasurementTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(372, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(1193, 53);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Search";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(400, 29);
            this.searchTextBox.TabIndex = 23;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Search";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1458, 86);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 86);
            this.panel1.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_14;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(292, 686);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(274, 79);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.addStocksButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.stockinstockoutButton);
            this.panel2.Controls.Add(this.stockoutTextBox);
            this.panel2.Controls.Add(this.clearcancelButton);
            this.panel2.Controls.Add(this.updatestocksButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.stockinTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.reorderlevelTextBox);
            this.panel2.Controls.Add(this.saveupdateButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.unitmeasurementTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.categoryComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1596, 787);
            this.panel2.TabIndex = 5;
            // 
            // addStocksButton
            // 
            this.addStocksButton.BackColor = System.Drawing.Color.Transparent;
            this.addStocksButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_112;
            this.addStocksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStocksButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.addStocksButton.FlatAppearance.BorderSize = 0;
            this.addStocksButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addStocksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addStocksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addStocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStocksButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addStocksButton.Location = new System.Drawing.Point(153, 0);
            this.addStocksButton.Name = "addStocksButton";
            this.addStocksButton.Size = new System.Drawing.Size(274, 76);
            this.addStocksButton.TabIndex = 25;
            this.addStocksButton.UseVisualStyleBackColor = false;
            this.addStocksButton.Click += new System.EventHandler(this.addStocksButton_Click);
            // 
            // stockinstockoutButton
            // 
            this.stockinstockoutButton.BackColor = System.Drawing.Color.Transparent;
            this.stockinstockoutButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_12__1_;
            this.stockinstockoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockinstockoutButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.stockinstockoutButton.FlatAppearance.BorderSize = 0;
            this.stockinstockoutButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.stockinstockoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stockinstockoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stockinstockoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockinstockoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockinstockoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockinstockoutButton.Location = new System.Drawing.Point(153, 437);
            this.stockinstockoutButton.Name = "stockinstockoutButton";
            this.stockinstockoutButton.Size = new System.Drawing.Size(274, 79);
            this.stockinstockoutButton.TabIndex = 46;
            this.stockinstockoutButton.UseVisualStyleBackColor = false;
            this.stockinstockoutButton.Click += new System.EventHandler(this.stockinstockoutButton_Click);
            // 
            // stockoutTextBox
            // 
            this.stockoutTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockoutTextBox.Enabled = false;
            this.stockoutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockoutTextBox.Location = new System.Drawing.Point(153, 645);
            this.stockoutTextBox.Name = "stockoutTextBox";
            this.stockoutTextBox.Size = new System.Drawing.Size(274, 29);
            this.stockoutTextBox.TabIndex = 44;
            this.stockoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stockoutTextBox.TextChanged += new System.EventHandler(this.stockoutTextBox_TextChanged);
            this.stockoutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockoutTextBox_KeyPress);
            // 
            // clearcancelButton
            // 
            this.clearcancelButton.BackColor = System.Drawing.Color.Transparent;
            this.clearcancelButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_14;
            this.clearcancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearcancelButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.clearcancelButton.FlatAppearance.BorderSize = 0;
            this.clearcancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clearcancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearcancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearcancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearcancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearcancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clearcancelButton.Location = new System.Drawing.Point(292, 366);
            this.clearcancelButton.Name = "clearcancelButton";
            this.clearcancelButton.Size = new System.Drawing.Size(274, 79);
            this.clearcancelButton.TabIndex = 26;
            this.clearcancelButton.UseVisualStyleBackColor = false;
            this.clearcancelButton.Click += new System.EventHandler(this.clearcancelButton_Click);
            // 
            // updatestocksButton
            // 
            this.updatestocksButton.BackColor = System.Drawing.Color.Transparent;
            this.updatestocksButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_13__1_;
            this.updatestocksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatestocksButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.updatestocksButton.FlatAppearance.BorderSize = 0;
            this.updatestocksButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.updatestocksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.updatestocksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.updatestocksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatestocksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestocksButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatestocksButton.Location = new System.Drawing.Point(12, 686);
            this.updatestocksButton.Name = "updatestocksButton";
            this.updatestocksButton.Size = new System.Drawing.Size(274, 79);
            this.updatestocksButton.TabIndex = 46;
            this.updatestocksButton.UseVisualStyleBackColor = false;
            this.updatestocksButton.Click += new System.EventHandler(this.updatestocksButton_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(153, 607);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(274, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Stock Out";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_9;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editButton.Location = new System.Drawing.Point(12, 366);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(274, 79);
            this.editButton.TabIndex = 45;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // stockinTextBox
            // 
            this.stockinTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockinTextBox.Enabled = false;
            this.stockinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockinTextBox.Location = new System.Drawing.Point(153, 575);
            this.stockinTextBox.Name = "stockinTextBox";
            this.stockinTextBox.Size = new System.Drawing.Size(274, 29);
            this.stockinTextBox.TabIndex = 42;
            this.stockinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stockinTextBox.TextChanged += new System.EventHandler(this.stockinTextBox_TextChanged);
            this.stockinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockinTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(153, 532);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(274, 35);
            this.label6.TabIndex = 41;
            this.label6.Text = "Stock In";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reorderlevelTextBox
            // 
            this.reorderlevelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reorderlevelTextBox.Enabled = false;
            this.reorderlevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderlevelTextBox.Location = new System.Drawing.Point(153, 337);
            this.reorderlevelTextBox.Name = "reorderlevelTextBox";
            this.reorderlevelTextBox.Size = new System.Drawing.Size(274, 29);
            this.reorderlevelTextBox.TabIndex = 40;
            this.reorderlevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reorderlevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reorderlevelTextBox_KeyPress);
            // 
            // saveupdateButton
            // 
            this.saveupdateButton.BackColor = System.Drawing.Color.Transparent;
            this.saveupdateButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_7;
            this.saveupdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveupdateButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.saveupdateButton.FlatAppearance.BorderSize = 0;
            this.saveupdateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.saveupdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveupdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveupdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveupdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveupdateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.saveupdateButton.Location = new System.Drawing.Point(12, 366);
            this.saveupdateButton.Name = "saveupdateButton";
            this.saveupdateButton.Size = new System.Drawing.Size(274, 79);
            this.saveupdateButton.TabIndex = 47;
            this.saveupdateButton.UseVisualStyleBackColor = false;
            this.saveupdateButton.Click += new System.EventHandler(this.saveupdateButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(153, 294);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(274, 35);
            this.label5.TabIndex = 39;
            this.label5.Text = "Reorder Level";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_10;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(292, 366);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(274, 79);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // unitmeasurementTextBox
            // 
            this.unitmeasurementTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unitmeasurementTextBox.Enabled = false;
            this.unitmeasurementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitmeasurementTextBox.Location = new System.Drawing.Point(153, 261);
            this.unitmeasurementTextBox.Name = "unitmeasurementTextBox";
            this.unitmeasurementTextBox.Size = new System.Drawing.Size(274, 29);
            this.unitmeasurementTextBox.TabIndex = 38;
            this.unitmeasurementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitmeasurementTextBox.TextChanged += new System.EventHandler(this.unitmeasurementTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(153, 218);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(274, 35);
            this.label4.TabIndex = 37;
            this.label4.Text = "Unit Measurement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 29;
            this.categoryComboBox.Location = new System.Drawing.Point(153, 180);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(274, 35);
            this.categoryComboBox.TabIndex = 36;
            this.categoryComboBox.UseSelectable = true;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(153, 140);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(153, 111);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 29);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(153, 72);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(274, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(434, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 777);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "#";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 47;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 57;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 122;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Unit Measurement";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Reorder Level";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 170;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 115;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Status";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 96;
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 863);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addStocksButton;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox reorderlevelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitmeasurementTextBox;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private System.Windows.Forms.Button clearcancelButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updatestocksButton;
        private System.Windows.Forms.Button saveupdateButton;
        private System.Windows.Forms.Button stockinstockoutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox stockoutTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stockinTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}