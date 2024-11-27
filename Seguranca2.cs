using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeuForm_FormClosing);
        }

        private void MeuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SegurancaInicial segurancaInicial = new SegurancaInicial();
            this.Hide();
            segurancaInicial.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            string url = "https://www.konsi.com.br/postagens/dicas-para-evitar-fraudes-e-golpes-a-idosos-aposentados-e-pensionistas";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string url = "https://www.kdcare.com.br/acessibilidade-para-idosos-5-dicas-para-deixar-sua-casa-mais/ ";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
