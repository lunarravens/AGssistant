using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGssistant_V2
{
    public partial class MenteInicial : Form
    {
        public MenteInicial()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa só pra fechar a aba
            this.Text = "AGssistant - Para a Mente"; //Nome da guia, sempre mudar de uma guia pra outra :)
            this.Size = new Size(1366, 768);
            MinimizeBox = false;
            MaximizeBox = false;
            this.CenterToScreen();

            label6.BackColor = ColorTranslator.FromHtml("#1c5560");
        }

        private void MenteInicial_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mente2 mente2 = new Mente2();
            this.Hide();
            mente2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
