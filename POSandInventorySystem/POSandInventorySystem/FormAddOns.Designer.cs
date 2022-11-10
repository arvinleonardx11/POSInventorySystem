
namespace POSandInventorySystem
{
    partial class FormAddOns
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.categoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.saveButton2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nameAddonsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.clearButton2);
            this.panel3.Controls.Add(this.saveButton2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 398);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.OldLace;
            this.panel9.Controls.Add(this.categoryComboBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 205);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(598, 50);
            this.panel9.TabIndex = 31;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.ItemHeight = 29;
            this.categoryComboBox.Location = new System.Drawing.Point(97, 0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(400, 35);
            this.categoryComboBox.TabIndex = 36;
            this.categoryComboBox.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(0, 170);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(598, 35);
            this.label7.TabIndex = 30;
            this.label7.Text = "Add-Ons For";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton2
            // 
            this.clearButton2.BackColor = System.Drawing.Color.Transparent;
            this.clearButton2.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_13;
            this.clearButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton2.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.clearButton2.FlatAppearance.BorderSize = 0;
            this.clearButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton2.Location = new System.Drawing.Point(304, 261);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(268, 73);
            this.clearButton2.TabIndex = 29;
            this.clearButton2.UseVisualStyleBackColor = false;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // saveButton2
            // 
            this.saveButton2.BackColor = System.Drawing.Color.Transparent;
            this.saveButton2.BackgroundImage = global::POSandInventorySystem.Properties.Resources.Asset_7;
            this.saveButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton2.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.saveButton2.FlatAppearance.BorderSize = 0;
            this.saveButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton2.Location = new System.Drawing.Point(36, 261);
            this.saveButton2.Name = "saveButton2";
            this.saveButton2.Size = new System.Drawing.Size(274, 84);
            this.saveButton2.TabIndex = 28;
            this.saveButton2.UseVisualStyleBackColor = false;
            this.saveButton2.Click += new System.EventHandler(this.saveButton2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.OldLace;
            this.panel8.Controls.Add(this.priceTextBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(598, 50);
            this.panel8.TabIndex = 20;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(97, 0);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(400, 29);
            this.priceTextBox.TabIndex = 0;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(0, 85);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(598, 35);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OldLace;
            this.panel7.Controls.Add(this.nameAddonsTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(598, 50);
            this.panel7.TabIndex = 18;
            // 
            // nameAddonsTextBox
            // 
            this.nameAddonsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameAddonsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAddonsTextBox.Location = new System.Drawing.Point(97, 0);
            this.nameAddonsTextBox.Name = "nameAddonsTextBox";
            this.nameAddonsTextBox.Size = new System.Drawing.Size(400, 29);
            this.nameAddonsTextBox.TabIndex = 0;
            this.nameAddonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameAddonsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameAddonsTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(598, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddOns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddOns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button saveButton2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox nameAddonsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private MetroFramework.Controls.MetroComboBox categoryComboBox;
        private System.Windows.Forms.Label label7;
    }
}