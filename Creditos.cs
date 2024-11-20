using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            this.Text = "AGssistant - Créditos";
        }

        // Leva de volta pra tela inicial
        private void Creditos_Load(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
