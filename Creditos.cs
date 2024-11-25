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
using static System.Windows.Forms.DataFormats;

namespace AGssistant_V2
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa só pra fechar a aba
            this.Text = "AGssistant - Informações"; //Nome da guia, sempre mudar de uma guia pra outra :)
            this.Size = new Size(1366, 768);
            MinimizeBox = false;
            MaximizeBox = false;

            label2.BackColor = ColorTranslator.FromHtml("#1c5560");

            this.CenterToScreen();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/isabela-boni-53500a277/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/jean-yoshida-90285b325/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label11_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/joão-vitor-gozzo-bruschi-36447522a/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/elysiumrev/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            this.Hide();
        }
    }
}
