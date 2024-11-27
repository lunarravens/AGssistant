using System.Windows.Forms;

namespace AGssistant_V2
{
    partial class telaInicial
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            imageList1 = new ImageList(components);
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label16 = new Label();
            label18 = new Label();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Image = Properties.Resources.iconInterroga;
            label4.Location = new Point(1437, 556);
            label4.Name = "label4";
            label4.Size = new Size(169, 159);
            label4.TabIndex = 8;
            label4.Click += label4_Click_1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Image = Properties.Resources.HeaderInicial1366;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1350, 148);
            label2.TabIndex = 9;
            label2.Click += label2_Click_2;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Image = Properties.Resources.iconInterrogakhazix2;
            label1.Location = new Point(1229, 32);
            label1.Name = "label1";
            label1.Size = new Size(109, 98);
            label1.TabIndex = 10;
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.BemVindo;
            label3.Location = new Point(474, 169);
            label3.Name = "label3";
            label3.Size = new Size(427, 551);
            label3.TabIndex = 11;
            label3.Click += label3_Click_2;
            // 
            // label5
            // 
            label5.Image = Properties.Resources.idoso;
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(456, 568);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.Image = Properties.Resources.image_7;
            label6.Location = new Point(897, 169);
            label6.Name = "label6";
            label6.Size = new Size(453, 88);
            label6.TabIndex = 13;
            label6.Click += label6_Click_1;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Image = Properties.Resources.image_10;
            label7.Location = new Point(918, 424);
            label7.Name = "label7";
            label7.Size = new Size(409, 85);
            label7.TabIndex = 14;
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(918, 257);
            label8.Name = "label8";
            label8.Size = new Size(409, 81);
            label8.TabIndex = 15;
            label8.Click += label8_Click_1;
            // 
            // label9
            // 
            label9.Cursor = Cursors.Hand;
            label9.Image = Properties.Resources.image_9;
            label9.Location = new Point(918, 338);
            label9.Name = "label9";
            label9.Size = new Size(409, 86);
            label9.TabIndex = 16;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.Location = new Point(918, 509);
            label10.Name = "label10";
            label10.Size = new Size(409, 214);
            label10.TabIndex = 17;
            // 
            // label16
            // 
            label16.Cursor = Cursors.Hand;
            label16.Image = (Image)resources.GetObject("label16.Image");
            label16.Location = new Point(975, 586);
            label16.Name = "label16";
            label16.Size = new Size(300, 124);
            label16.TabIndex = 18;
            label16.Text = "         ";
            label16.Click += label16_Click_1;
            // 
            // label18
            // 
            label18.Cursor = Cursors.Hand;
            label18.Image = Properties.Resources.Vector_1_;
            label18.Location = new Point(24, 21);
            label18.Name = "label18";
            label18.Size = new Size(112, 112);
            label18.TabIndex = 19;
            label18.Click += label18_Click;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 255, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "telaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGssistant";
            Load += telaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ImageList imageList1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button2;
        private Label label17;
        private Label label11;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label16;
        private Label label18;
    }
}
