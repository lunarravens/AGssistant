using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;

namespace AGssistant_V2
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa s� pra fechar a aba
            this.Text = "AGssistant - P�gina Inicial"; //Nome da guia, sempre mudar de uma guia pra outra :)
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Bot�o para redirecionar a tela de cr�ditos
        private void button2_Click(object sender, EventArgs e)
        {
            Creditos Creditos = new Creditos();
            this.Hide();
            Creditos.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        // Bot�o para redirecionar ao formul�rio
        private void label17_Click(object sender, EventArgs e)
        {
            string url = "https://forms.gle/dW7cwo1Yv61Jkt2a8";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
