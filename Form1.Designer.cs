﻿namespace SuprememartPOS
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
            Shehara = new Button();
            SuspendLayout();
            // 
            // Shehara
            // 
            Shehara.BackColor = SystemColors.MenuHighlight;
            Shehara.Location = new Point(186, 166);
            Shehara.Name = "Shehara";
            Shehara.Size = new Size(75, 23);
            Shehara.TabIndex = 0;
            Shehara.Text = "Shehara";
            Shehara.UseVisualStyleBackColor = false;
            Shehara.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
            Controls.Add(Shehara);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Shehara;
    }
}
