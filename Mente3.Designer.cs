﻿namespace AGssistant_V2
{
    partial class Mente3
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
            label1 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.image_31;
            label1.Location = new Point(0, -5);
            label1.Name = "label1";
            label1.Size = new Size(1351, 152);
            label1.TabIndex = 5;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.Vector_1_;
            label5.Location = new Point(24, 21);
            label5.Name = "label5";
            label5.Size = new Size(112, 112);
            label5.TabIndex = 18;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Image = Properties.Resources.iconInterrogakhazix2;
            label7.Location = new Point(1229, 32);
            label7.Name = "label7";
            label7.Size = new Size(109, 98);
            label7.TabIndex = 19;
            label7.Click += label7_Click;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.image_34;
            label3.Location = new Point(1, 154);
            label3.Name = "label3";
            label3.Size = new Size(893, 577);
            label3.TabIndex = 20;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.image_26;
            label4.Location = new Point(949, 171);
            label4.Name = "label4";
            label4.Size = new Size(355, 116);
            label4.TabIndex = 21;
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = Properties.Resources.pexels_photo_8939845_2;
            label6.Location = new Point(973, 425);
            label6.Name = "label6";
            label6.Size = new Size(305, 283);
            label6.TabIndex = 22;
            // 
            // Mente3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Mente3";
            Text = "Mente3";
            Load += Mente3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}