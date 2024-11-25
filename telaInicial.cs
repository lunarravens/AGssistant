using System.Diagnostics;

namespace AGssistant_V2
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Deixa sem poder redimensionar
            MaximizeBox = false; // Deixa só pra fechar a aba
            this.Text = "AGssistant - Página Inicial"; //Nome da guia, sempre mudar de uma guia pra outra :)
            this.Size = new Size(1366, 768);
            MinimizeBox = false;
            MaximizeBox = false;

            label1.BackColor = ColorTranslator.FromHtml("#1c5560");
            label16.BackColor = ColorTranslator.FromHtml("#1c5560");
            label18.BackColor = ColorTranslator.FromHtml("#1c5560");

            this.CenterToScreen();
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        // Botão para redirecionar ao formulário
        private void label17_Click(object sender, EventArgs e)
        {
            string url = "https://forms.gle/dW7cwo1Yv61Jkt2a8";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            SegurancaInicial segurancaInicial = new SegurancaInicial();
            this.Hide();
            segurancaInicial.Show();
        }

        // Botão para redirecionar ao formulário
        private void label16_Click_1(object sender, EventArgs e)
        {
            string url = "https://forms.gle/dW7cwo1Yv61Jkt2a8";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Corpo corpo = new Corpo();
            this.Hide();
            corpo.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            menteInicial menteInicial = new menteInicial();
            this.Hide();
            menteInicial.Show();
        }
    }
}
