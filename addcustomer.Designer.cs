﻿namespace SuprememartPOS
{
    partial class addcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcustomer));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            add = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(595, 86);
            label1.Name = "label1";
            label1.Size = new Size(391, 54);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(491, 214);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(658, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 34);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(491, 280);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(658, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 34);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(491, 336);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 5;
            label4.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(491, 400);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 6;
            label5.Text = "NIC Number:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(658, 336);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(658, 400);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 34);
            textBox4.TabIndex = 8;
            // 
            // add
            // 
            add.BackColor = Color.Transparent;
            add.BackgroundImage = (Image)resources.GetObject("add.BackgroundImage");
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Location = new Point(658, 504);
            add.Name = "add";
            add.Size = new Size(188, 57);
            add.TabIndex = 9;
            add.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(541, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "addcustomer";
            Size = new Size(1540, 922);
            Load += addcustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button add;
        private PictureBox pictureBox1;

    }
}
