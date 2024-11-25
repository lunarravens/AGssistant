namespace AGssistant_V2
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
            label3.Location = new Point(936, 159);
            label3.Name = "label3";
            label3.Size = new Size(358, 119);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.image_11;
            label4.Location = new Point(963, 278);
            label4.Name = "label4";
            label4.Size = new Size(303, 293);
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
            // Corpo3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
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
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}