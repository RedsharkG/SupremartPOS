﻿namespace SuprememartPOS
{
    partial class sales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            salesss = new Label();
            dataGridViewsales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsales).BeginInit();
            SuspendLayout();
            // 
            // salesss
            // 
<<<<<<< HEAD
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(16, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 1;
            label1.Text = "Sales";
            label1.Click += label1_Click;
=======
            salesss.AutoSize = true;
            salesss.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            salesss.Location = new Point(16, 29);
            salesss.Margin = new Padding(2, 0, 2, 0);
            salesss.Name = "salesss";
            salesss.Size = new Size(60, 28);
            salesss.TabIndex = 1;
            salesss.Text = "Sales";
            salesss.Click += label1_Click;
>>>>>>> 93cb31fdf699c60abca5a4642b7d3c4e39492c17
            // 
            // dataGridViewsales
            // 
            dataGridViewsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsales.Location = new Point(16, 73);
            dataGridViewsales.Margin = new Padding(2, 1, 2, 1);
            dataGridViewsales.Name = "dataGridViewsales";
            dataGridViewsales.RowHeadersWidth = 82;
            dataGridViewsales.Size = new Size(1494, 749);
            dataGridViewsales.TabIndex = 3;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewsales);
            Controls.Add(salesss);
            Margin = new Padding(2, 1, 2, 1);
            Name = "sales";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewsales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salesss;
        private DataGridView dataGridViewsales;
    }
}
