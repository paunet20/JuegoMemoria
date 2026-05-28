using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMemoria
{
    public partial class Form2 : Form
    {
        //Variable para guardar la ruta de nuestras imagenes
        List<Clase1> lista = new List<Clase1>();

        List<Button> botones = new List<Button>();
        Clase1[,] matriz;
        Button[,] matrizBotones;

        Button boton1 = null;
        Button boton2 = null;

        Clase1 carta1 = null;
        Clase1 carta2 = null;

        int nivel = 1;
        int filas = 2;
        int columnas = 4;
        int tiempo = 30;

        int puntos = 0;
        int parejas = 0;
        int totalParejas = 4;

        bool noTocar = false;

        public Form2(int n)
        {
            InitializeComponent();

            nivel = n;
            ponerNivel();
            empezar();
        }

        //Funcion para asignar el nivel elegido por el usuario
        private void ponerNivel()
        {
            if (nivel == 1)
            {
                filas = 2;
                columnas = 4;
                tiempo = 30;
            }

            if (nivel == 2)
            {
                filas = 3;
                columnas = 6;
                tiempo = 60;
            }

            if (nivel == 3)
            {
                filas = 4;
                columnas = 8;
                tiempo = 120;
            }

            totalParejas = (filas * columnas) / 2;
        }

        private void empezar()
        {
            lista.Clear();
            botones.Clear();
            panelJuego.Controls.Clear();

            puntos = 0;
            parejas = 0;
            noTocar = false;
            carta1 = null;
            carta2 = null;
            boton1 = null;
            boton2 = null;

            ponerNivel();

            labelNivel.Text = "Nivel: " + nivel;
            labelPuntos.Text = "Puntos: 0";
            labelParejas.Text = "Parejas: 0/" + totalParejas;
            labelTiempo.Text = "Tiempo: " + tiempo;

            crearLista();
            revolver();
            crearBotones();

            reloj.Stop();
            reloj.Start();
        }

        private void crearLista()
        {
            int cantidad = filas * columnas;
            int mitad = cantidad / 2;

            for (int i = 1; i <= mitad; i++)
            {
                string ruta = Path.Combine(Application.StartupPath, "Imagenes", "img" + i + ".png");

                lista.Add(new Clase1(i, ruta));
                lista.Add(new Clase1(i, ruta));
            }
        }

        private void revolver()
        {
            Random r = new Random();

            for (int i = lista.Count - 1; i > 0; i--)
            {
                int p = r.Next(i + 1);

                Clase1 aux = lista[i];
                lista[i] = lista[p];
                lista[p] = aux;
            }
        }

        private void crearBotones()
        {
            int margen = 8;

            int ancho = (panelJuego.Width - ((columnas + 1) * margen)) / columnas;
            int alto = (panelJuego.Height - ((filas + 1) * margen)) / filas;

            matriz = new Clase1[filas, columnas];
            matrizBotones = new Button[filas, columnas];

            int cont = 0;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = lista[cont];

                    Button b = new Button();

                    b.Name = "carta" + f + c;
                    b.Text = "?";
                    b.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                    b.Size = new Size(ancho, alto);
                    b.Location = new Point(margen + c * (ancho + margen), margen + f * (alto + margen));
                    b.Tag = f + "," + c;
                    b.BackColor = Color.White;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    b.Click += tocarCarta;

                    ponerTapa(b);

                    matrizBotones[f, c] = b;

                    panelJuego.Controls.Add(b);
                    botones.Add(b);

                    cont++;
                }
            }
        }

        private void ponerTapa(Button b)
        {
            string tapa = Path.Combine(Application.StartupPath, "Imagenes", "tapa.png");

            if (b.BackgroundImage != null)
            {
                b.BackgroundImage.Dispose();
                b.BackgroundImage = null;
            }

            if (File.Exists(tapa))
            {
                using (Image img = Image.FromFile(tapa))
                {
                    b.Text = "";
                    b.BackgroundImage = new Bitmap(img);
                }
            }
            else
            {
                b.Text = "?";
                b.BackgroundImage = null;
            }
        }

        private void ponerImagen(Button b, string ruta)
        {
            limpiarImagenBoton(b);

            if (File.Exists(ruta))
            {
                try
                {
                    byte[] datos = File.ReadAllBytes(ruta);

                    using (MemoryStream ms = new MemoryStream(datos))
                    using (Image img = Image.FromStream(ms))
                    {
                        b.Text = "";
                        b.BackgroundImage = new Bitmap(img, b.Width, b.Height);
                    }
                }
                catch
                {
                    b.BackgroundImage = null;
                    b.Text = "Error";
                }
            }
            else
            {
                b.BackgroundImage = null;
                b.Text = "No";
            }
        }

        private async void tocarCarta(object sender, EventArgs e)
        {
            if (noTocar == true)
            {
                return;
            }

            Button b = sender as Button;

            if (b == null)
            {
                return;
            }

            string[] datos = b.Tag.ToString().Split(',');

            int fila = Convert.ToInt32(datos[0]);
            int columna = Convert.ToInt32(datos[1]);

            Clase1 c = matriz[fila, columna];

            if (c.yaSalio == true)
            {
                return;
            }

            if (b == boton1)
            {
                return;
            }

            ponerImagen(b, c.foto);

            if (carta1 == null)
            {
                carta1 = c;
                boton1 = b;
            }
            else
            {
                carta2 = c;
                boton2 = b;

                noTocar = true;

                if (carta1.numero == carta2.numero)
                {
                    carta1.yaSalio = true;
                    carta2.yaSalio = true;

                    boton1.Enabled = false;
                    boton2.Enabled = false;

                    puntos = puntos + 100;
                    parejas = parejas + 1;

                    labelPuntos.Text = "Puntos: " + puntos;
                    labelParejas.Text = "Parejas: " + parejas + "/" + totalParejas;

                    if (parejas == totalParejas)
                    {
                        reloj.Stop();

                        int bono = tiempo * 5;
                        puntos = puntos + bono;

                        MessageBox.Show("Ganaste. Bono de tiempo: " + bono + ". Puntaje final: " + puntos);
                        labelPuntos.Text = "Puntos: " + puntos;
                    }
                }
                else
                {
                    puntos = puntos - 10;

                    if (puntos < 0)
                    {
                        puntos = 0;
                    }

                    labelPuntos.Text = "Puntos: " + puntos;

                    await Task.Delay(800);

                    ponerTapa(boton1);
                    ponerTapa(boton2);
                }

                carta1 = null;
                carta2 = null;
                boton1 = null;
                boton2 = null;

                noTocar = false;
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo - 1;

            labelTiempo.Text = "Tiempo: " + tiempo;

            if (tiempo <= 10)
            {
                labelTiempo.ForeColor = Color.Red;
            }
            else
            {
                labelTiempo.ForeColor = Color.Black;
            }

            if (tiempo <= 0)
            {
                reloj.Stop();
                noTocar = true;

                MessageBox.Show("Se acabó el tiempo. Parejas encontradas: " + parejas + "/" + totalParejas + ". Puntaje final: " + puntos);
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            reloj.Stop();
            empezar();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            reloj.Stop();

            Form1 f = new Form1();
            f.Show();

            this.Close();
        }
        private void limpiarImagenBoton(Button b)
        {
            if (b.BackgroundImage != null)
            {
                Image vieja = b.BackgroundImage;
                b.BackgroundImage = null;
                vieja.Dispose();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
