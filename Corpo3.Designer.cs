﻿namespace AGssistant_V2
{
    partial class Corpo3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkbox1 = new CheckBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.headerCorpo;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1355, 159);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.image_29;
            label2.Location = new Point(0, 159);
            label2.Name = "label2";
            label2.Size = new Size(877, 576);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.image_26;
            label3.Location = new Point(936, 158);
            label3.Name = "label3";
            label3.Size = new Size(358, 119);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.image_11;
            label4.Location = new Point(974, 270);
            label4.Name = "label4";
            label4.Size = new Size(281, 275);
            label4.TabIndex = 3;
            // 
            // label6
            // 
            label6.Image = Properties.Resources.Vector_1_;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(112, 112);
            label6.TabIndex = 6;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Image = Properties.Resources.iconInterrogakhazix2;
            label5.Location = new Point(1229, 32);
            label5.Name = "label5";
            label5.Size = new Size(109, 98);
            label5.TabIndex = 12;
            label5.Click += label5_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.FromArgb(28, 85, 96);
            checkBox3.Font = new Font("Calibri", 15.75F);
            checkBox3.ForeColor = SystemColors.ButtonHighlight;
            checkBox3.Location = new Point(926, 642);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(303, 30);
            checkBox3.TabIndex = 25;
            checkBox3.Text = "Estou com meus exames em dia";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.FromArgb(28, 85, 96);
            checkBox2.Font = new Font("Calibri", 15.75F);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(926, 678);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(297, 30);
            checkBox2.TabIndex = 24;
            checkBox2.Text = "Tive uma alimentação regulada";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkbox1
            // 
            checkbox1.AutoSize = true;
            checkbox1.BackColor = Color.FromArgb(28, 85, 96);
            checkbox1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox1.ForeColor = SystemColors.ButtonHighlight;
            checkbox1.Location = new Point(926, 607);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(389, 30);
            checkbox1.TabIndex = 23;
            checkbox1.Text = "Assisti e pratiquei aos videos educacionais";
            checkbox1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Image = Properties.Resources.oquevis;
            label7.Location = new Point(899, 547);
            label7.Name = "label7";
            label7.Size = new Size(439, 182);
            label7.TabIndex = 22;
            // 
            // Corpo3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkbox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Corpo3";
            Text = "Corpo3";
            Load += Corpo3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkbox1;
        private Label label7;
    }
}