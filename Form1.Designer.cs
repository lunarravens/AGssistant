namespace AGssistant_V2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            AGssistant = new Label();
            panel2 = new Panel();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(AGssistant);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 106);
            panel1.TabIndex = 0;
            // 
            // AGssistant
            // 
            AGssistant.AutoSize = true;
            AGssistant.BackColor = Color.Transparent;
            AGssistant.Cursor = Cursors.IBeam;
            AGssistant.Font = new Font("Cambria Math", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AGssistant.ForeColor = SystemColors.ButtonHighlight;
            AGssistant.Location = new Point(578, -115);
            AGssistant.Name = "AGssistant";
            AGssistant.Size = new Size(377, 301);
            AGssistant.TabIndex = 0;
            AGssistant.Text = "AGssistant";
            AGssistant.TextAlign = ContentAlignment.TopCenter;
            AGssistant.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Location = new Point(487, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 676);
            panel2.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Image = Properties.Resources.idoso2;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(469, 676);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoEllipsis = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Cambria Math", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(629, 9);
            label2.Name = "label2";
            label2.Size = new Size(251, 97);
            label2.TabIndex = 1;
            label2.Text = "Página inicial";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1520, 825);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ImageList imageList1;
        private Label AGssistant;
        private Label label2;
    }
}
