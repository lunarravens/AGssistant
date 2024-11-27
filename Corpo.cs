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
    public partial class Corpo : Form
    {
        public Corpo()
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

            label2.BackColor = ColorTranslator.FromHtml("#1c5560");
            label6.BackColor = ColorTranslator.FromHtml("#1c5560");

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeuForm_FormClosing);
        }

        private void MeuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Corpo2 corpo2 = new Corpo2();
            corpo2.Show();
            this.Hide();
        }

        private void Corpo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
