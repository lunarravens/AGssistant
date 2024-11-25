namespace AGssistant_V2
{
    partial class SegurancaInicial
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
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.image_35;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1354, 154);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Image = Properties.Resources.iconInterrogakhazix2;
            label2.Location = new Point(1229, 32);
            label2.Name = "label2";
            label2.Size = new Size(109, 98);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Image = Properties.Resources.Vector_1_;
            label3.Location = new Point(24, 21);
            label3.Name = "label3";
            label3.Size = new Size(112, 112);
            label3.TabIndex = 12;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.image_36;
            label4.Location = new Point(0, 154);
            label4.Name = "label4";
            label4.Size = new Size(877, 576);
            label4.TabIndex = 13;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Image = Properties.Resources.image_25;
            label5.Location = new Point(948, 167);
            label5.Name = "label5";
            label5.Size = new Size(325, 148);
            label5.TabIndex = 14;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = Properties.Resources.Transport;
            label6.Location = new Point(965, 437);
            label6.Name = "label6";
            label6.Size = new Size(305, 283);
            label6.TabIndex = 15;
            // 
            // SegurancaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 205);
            ClientSize = new Size(1350, 729);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SegurancaInicial";
            Text = "SegurancaInicial";
            Load += SegurancaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}