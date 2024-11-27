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
    public partial class Mente3 : Form
    {
        public Mente3()
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

            label5.BackColor = ColorTranslator.FromHtml("#1c5560");
            label7.BackColor = ColorTranslator.FromHtml("#1c5560");

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeuForm_FormClosing);
        }

        private void MeuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Mente3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Mente2 mente2 = new Mente2();
            this.Hide();
            mente2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            this.Hide();
            telaInicial.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            string url = "https://www.geniol.com.br/passatempos/jogo-da-memoria/#google_vignette";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string url = "https://rachacuca.com.br/palavras/palavras-cruzadas/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label11_Click(object sender, EventArgs e)
        {
            string url = "https://sudoku.com/pt";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string url = "https://term.ooo";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string url = "https://rachacuca.com.br/palavras/caca-palavras/";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
