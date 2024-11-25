using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGssistant_V2
{
    public partial class Corpo2 : Form
    {
        public Corpo2()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa só pra fechar a aba
            this.Text = "AGssistant - Para o Corpo"; //Nome da guia, sempre mudar de uma guia pra outra :)
            this.Size = new Size(1366, 768);
            MinimizeBox = false;
            MaximizeBox = false;

            this.CenterToScreen();
            label6.BackColor = ColorTranslator.FromHtml("#1c5560");
            label7.BackColor = ColorTranslator.FromHtml("#1c5560");
        }

        private void Corpo2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Corpo3 corpo3 = new Corpo3();
            corpo3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Corpo corpo = new Corpo();
            corpo.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }
    }
}
