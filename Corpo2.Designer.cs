namespace AGssistant_V2
{
    partial class Corpo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corpo2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.headerCorpo;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(1352, 159);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.image_28;
            label2.Location = new Point(4, 156);
            label2.Name = "label2";
            label2.Size = new Size(879, 578);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(941, 156);
            label3.Name = "label3";
            label3.Size = new Size(355, 116);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Image = Properties.Resources.image_26;
            label4.Location = new Point(941, 272);
            label4.Name = "label4";
            label4.Size = new Size(355, 116);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(941, 388);
            label5.Name = "label5";
            label5.Size = new Size(369, 332);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = Properties.Resources.Vector_1_;
            label6.Location = new Point(24, 21);
            label6.Name = "label6";
            label6.Size = new Size(112, 112);
            label6.TabIndex = 5;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Image = Properties.Resources.iconInterrogakhazix2;
            label7.Location = new Point(1229, 32);
            label7.Name = "label7";
            label7.Size = new Size(109, 98);
            label7.TabIndex = 12;
            label7.Click += label7_Click;
            // 
            // Corpo2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Corpo2";
            Text = "Corpo2";
            Load += Corpo2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}