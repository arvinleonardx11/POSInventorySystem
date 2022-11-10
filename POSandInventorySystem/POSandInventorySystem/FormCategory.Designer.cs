
namespace POSandInventorySystem
{
    partial class FormCategory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.addonsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.sugarlevelComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.clearButton1);
            this.panel2.Controls.Add(this.saveButton1);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 398);
            this.panel2.TabIndex = 7;
            // 
            // clearButton1
            // 
            this.clearButton1.BackColor = System.Drawing.Color.Transparent;
            this.clearButton1.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_13;
            this.clearButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton1.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.clearButton1.FlatAppearance.BorderSize = 0;
            this.clearButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton1.Location = new System.Drawing.Point(307, 328);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(279, 71);
            this.clearButton1.TabIndex = 27;
            this.clearButton1.UseVisualStyleBackColor = false;
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // saveButton1
            // 
            this.saveButton1.BackColor = System.Drawing.Color.Transparent;
            this.saveButton1.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_7;
            this.saveButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton1.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.saveButton1.FlatAppearance.BorderSize = 0;
            this.saveButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton1.Location = new System.Drawing.Point(31, 328);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(270, 78);
            this.saveButton1.TabIndex = 26;
            this.saveButton1.UseVisualStyleBackColor = false;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.OldLace;
            this.panel12.Controls.Add(this.addonsComboBox);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 290);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(598, 50);
            this.panel12.TabIndex = 24;
            // 
            // addonsComboBox
            // 
            this.addonsComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.addonsComboBox.FormattingEnabled = true;
            this.addonsComboBox.ItemHeight = 29;
            this.addonsComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.addonsComboBox.Location = new System.Drawing.Point(97, 0);
            this.addonsComboBox.Name = "addonsComboBox";
            this.addonsComboBox.Size = new System.Drawing.Size(400, 35);
            this.addonsComboBox.TabIndex = 36;
            this.addonsComboBox.UseSelectable = true;
            this.addonsComboBox.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(0, 255);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(598, 35);
            this.label3.TabIndex = 23;
            this.label3.Text = "With Add-Ons";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.OldLace;
            this.panel11.Controls.Add(this.sugarlevelComboBox);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 205);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(598, 50);
            this.panel11.TabIndex = 22;
            // 
            // sugarlevelComboBox
            // 
            this.sugarlevelComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.sugarlevelComboBox.FormattingEnabled = true;
            this.sugarlevelComboBox.ItemHeight = 29;
            this.sugarlevelComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.sugarlevelComboBox.Location = new System.Drawing.Point(97, 0);
            this.sugarlevelComboBox.Name = "sugarlevelComboBox";
            this.sugarlevelComboBox.Size = new System.Drawing.Size(400, 35);
            this.sugarlevelComboBox.TabIndex = 36;
            this.sugarlevelComboBox.UseSelectable = true;
            this.sugarlevelComboBox.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(0, 170);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(598, 35);
            this.label2.TabIndex = 21;
            this.label2.Text = "With Sugar Level";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.OldLace;
            this.panel9.Controls.Add(this.categoryComboBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 120);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(598, 50);
            this.panel9.TabIndex = 20;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 29;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Menu",
            "Stocks"});
            this.categoryComboBox.Location = new System.Drawing.Point(97, 0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(400, 35);
            this.categoryComboBox.TabIndex = 36;
            this.categoryComboBox.UseSelectable = true;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(0, 85);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(598, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "Category For";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OldLace;
            this.panel6.Controls.Add(this.nameCategoryTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(598, 50);
            this.panel6.TabIndex = 18;
            // 
            // nameCategoryTextBox
            // 
            this.nameCategoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameCategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCategoryTextBox.Location = new System.Drawing.Point(97, 0);
            this.nameCategoryTextBox.Name = "nameCategoryTextBox";
            this.nameCategoryTextBox.Size = new System.Drawing.Size(400, 29);
            this.nameCategoryTextBox.TabIndex = 0;
            this.nameCategoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameCategoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameCategoryTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(598, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.Panel panel12;
        private MetroFramework.Controls.MetroComboBox addonsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private MetroFramework.Controls.MetroComboBox sugarlevelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox nameCategoryTextBox;
        private System.Windows.Forms.Label label4;
    }
}