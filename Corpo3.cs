using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AGssistant_V2
{
    public partial class Corpo3 : Form
    {
        public Corpo3()
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
            label5.BackColor = ColorTranslator.FromHtml("#1c5560");
        }

        private async void Corpo3_Load(object sender, EventArgs e)
        {
            // Inicializa o WebView2
            await webView21.EnsureCoreWebView2Async();

            // Carregar o primeiro vídeo
            LoadVideo("5Mmq-Mr05Oc");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Corpo2 corpo2 = new Corpo2();
            corpo2.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Close();
            creditos.Show();
        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void LoadVideo(string videoId)
        {
            var embedHtml = $@"
                <html>
                    <head>
                        <meta http-equiv='X-UA-Compatible' content='IE=edge' />
                        <style>
                            body {{ margin: 0; overflow: hidden; }}
                            iframe {{ width: 100%; height: 100%; border: none; }}
                        </style>
                    </head>
                    <body>
                        <iframe 
                            src='https://www.youtube.com/embed/{videoId}?autoplay=1' 
                            allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; fullscreen' 
                            allowfullscreen>
                        </iframe>
                    </body>
                </html>";

            // Carrega o HTML no WebView2
            webView21.NavigateToString(embedHtml);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadVideo("5Mmq-Mr05Oc"); // Novo vídeo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadVideo("L6ZgzJKfERM"); // Volta para o primeiro vídeo
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoadVideo("5Mmq-Mr05Oc");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoadVideo("9cKe2I-Ta14");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoadVideo("fq3usJz2uEw");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            LoadVideo("g4HpK7vd1VI");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LoadVideo("OwCTukZyEmA");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
