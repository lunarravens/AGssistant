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
    public partial class SegurancaInicial : Form
    {
        public SegurancaInicial()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa só pra fechar a aba
            this.Text = "AGssistant - Para o Segurança"; //Nome da guia, sempre mudar de uma guia pra outra :)
            this.Size = new Size(1366, 768);
            MinimizeBox = false;
            MaximizeBox = false;

            this.CenterToScreen();
            label2.BackColor = ColorTranslator.FromHtml("#1c5560");
            label3.BackColor = ColorTranslator.FromHtml("#1c5560");
        }

        private void SegurancaInicial_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Seguranca2 seguranca2 = new Seguranca2();
            this.Hide();
            seguranca2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
