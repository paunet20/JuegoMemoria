namespace JuegoMemoria
{
    public partial class Form1 : Form
    {
        int nivelQueQuiere = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonNivel1_Click(object sender, EventArgs e)
        {
            nivelQueQuiere = 1;
            abrirJuego();
        }

        private void botonNivel2_Click(object sender, EventArgs e)
        {
            nivelQueQuiere = 2;
            abrirJuego();
        }

        private void botonNivel3_Click(object sender, EventArgs e)
        {
            nivelQueQuiere = 3;
            abrirJuego();
        }

        private void abrirJuego()
        {
            Form2 f = new Form2(nivelQueQuiere);
            f.Show();
            this.Hide();
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
