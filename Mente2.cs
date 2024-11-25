﻿using System;
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
    public partial class Mente2 : Form
    {
        public Mente2()
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

        private void label2_Click(object sender, EventArgs e)
        {
            Mente3 mente3 = new Mente3();
            this.Hide();
            mente3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MenteInicial menteInicial = new MenteInicial();
            this.Hide();
            menteInicial.Show();
        }
    }
}