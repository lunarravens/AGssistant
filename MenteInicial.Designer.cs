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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.image_31;
            label1.Location = new Point(-1, -4);
            label1.Name = "label1";
            label1.Size = new Size(1351, 152);
            label1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.image_32;
            label3.Location = new Point(0, 155);
            label3.Name = "label3";
            label3.Size = new Size(893, 579);
            label3.TabIndex = 3;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(957, 155);
            label5.Name = "label5";
            label5.Size = new Size(335, 161);
            label5.TabIndex = 5;
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.Nature;
            label2.Location = new Point(973, 445);
            label2.Name = "label2";
            label2.Size = new Size(307, 275);
            label2.TabIndex = 6;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Image = Properties.Resources.iconInterrogakhazix2;
            label4.Location = new Point(1229, 32);
            label4.Name = "label4";
            label4.Size = new Size(109, 98);
            label4.TabIndex = 12;
            // 
            // label6
            // 
            label6.Image = Properties.Resources.Vector_1_;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(112, 112);
            label6.TabIndex = 13;
            label6.Click += label6_Click;
            // 
            // MenteInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "MenteInicial";
            Text = "MenteInicial";
            Load += MenteInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label6;
    }
}