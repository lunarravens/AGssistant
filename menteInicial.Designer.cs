namespace AGssistant_V2
{
    partial class MenteInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenteInicial));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Image = Properties.Resources.image_311;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1350, 148);
            label2.TabIndex = 10;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.image_32;
            label3.Location = new Point(0, 148);
            label3.Name = "label3";
            label3.Size = new Size(893, 578);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.mental1;
            label4.Location = new Point(961, 398);
            label4.Name = "label4";
            label4.Size = new Size(335, 308);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(961, 160);
            label5.Name = "label5";
            label5.Size = new Size(335, 161);
            label5.TabIndex = 13;
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.Vector_1_;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 112);
            label1.TabIndex = 14;
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = Properties.Resources.iconInterrogakhazix2;
            label6.Location = new Point(1229, 32);
            label6.Name = "label6";
            label6.Size = new Size(109, 98);
            label6.TabIndex = 15;
            label6.Click += label6_Click;
            // 
            // menteInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 255, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "menteInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Para a mente - Página 1";
            Load += menteInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label6;
    }
}