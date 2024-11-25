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
    public partial class Seguranca2 : Form
    {
        public Seguranca2()
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

        private void Seguranca2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            this.Hide();
            telaInicial.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SegurancaInicial segurancaInicial = new SegurancaInicial();
            this.Hide();
            segurancaInicial.Show();
        }
    }
}
