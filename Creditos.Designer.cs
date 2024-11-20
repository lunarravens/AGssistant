namespace AGssistant_V2
{
    partial class Creditos
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
            Label label7;
            Label label6;
            panel1 = new Panel();
            label11 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.BackColor = Color.Transparent;
            label7.CausesValidation = false;
            label7.Cursor = Cursors.IBeam;
            label7.Font = new Font("Gadugi", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(703, 59);
            label7.Name = "label7";
            label7.Size = new Size(106, 35);
            label7.TabIndex = 6;
            label7.Text = "Créditos";
            label7.UseCompatibleTextRendering = true;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.BackColor = Color.Transparent;
            label6.CausesValidation = false;
            label6.Cursor = Cursors.IBeam;
            label6.Font = new Font("Bahnschrift SemiBold", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(543, 14);
            label6.Name = "label6";
            label6.Size = new Size(423, 45);
            label6.TabIndex = 6;
            label6.Text = "AGssistant";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 85, 96);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 110);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Image = Properties.Resources.homeButton;
            label11.Location = new Point(16, 5);
            label11.Name = "label11";
            label11.Size = new Size(87, 101);
            label11.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(28, 85, 96);
            panel6.Location = new Point(16, 132);
            panel6.Name = "panel6";
            panel6.Size = new Size(793, 94);
            panel6.TabIndex = 7;
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 255, 205);
            ClientSize = new Size(1520, 825);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Creditos";
            Text = "Creditos";
            Load += Creditos_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Panel panel6;
    }
}