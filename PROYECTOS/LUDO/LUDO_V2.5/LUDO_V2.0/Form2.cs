using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDO_V2._0
{
    public partial class Form2 : Form
    {
        int movimientos, indiceBoton = -1, tiempo;
        Jugador jugadorAzul, jugadorAmarillo, jugadorVerde, jugadorRojo;

        //Se cargan los componenetes y se crea 4 objetos de tipo Jugador, que son referenciados por las variables globales definidas (jugadorAzul, jugadorAmarillo, jugadorVerde y jugadorRojo).
        public Form2(string tipoJugador_Azul, string tipoJugador_Rojo, string tipoJugador_Amarillo, string tipoJugador_Verde)
        {
            jugadorRojo = new Jugador("rojo", tipoJugador_Rojo);
            jugadorVerde = new Jugador("verde", tipoJugador_Verde);
            jugadorAmarillo = new Jugador("amarillo", tipoJugador_Amarillo);
            jugadorAzul = new Jugador("azul", tipoJugador_Azul);
            InitializeComponent();
        }

        //Se le asigna el fondo de color al tablero, se desactivan los botones de los dados y se ejecutan los metodos CrearTablero y EmpezarJuego
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F5EEDC");
            buttonDado_Amarillo.Enabled = false;
            buttonDado_Verde.Enabled = false;
            buttonDado_Azul.Enabled = false;
            buttonDado_Rojo.Enabled = false;
            CrearTablero();
            EmpezarJuego();
        }

        //*******CrearTablero*********
        //Se controla que el jugador sea distinto de none, en caso de que esto se cumpla (jugador sea igual a "cpu" o "player"):
        //Paso 1: Se crean los pictureBox (fichas), mediante un metodo de la clase Jugador.
        //Paso 2: Se añaden los pictureBox al formulario.
        //Paso 3: Se crean los Eventos de click de cada pictureBox.
        public void CrearTablero()
        {
            if (jugadorAzul.Tipo == "cpu" || jugadorAzul.Tipo == "player")
            {
                //Paso 1
                jugadorAzul.CrearFichas();

                // Paso 2
                foreach (Fichas i in jugadorAzul.ListFichas)
                {
                    this.Controls.Add(i.Ficha);
                }

                //Paso 3
                this.jugadorAzul.ListFichas[0].Ficha.Click += new System.EventHandler(this.FichaAzul1_Click);
                this.jugadorAzul.ListFichas[1].Ficha.Click += new System.EventHandler(this.FichaAzul2_Click);
                this.jugadorAzul.ListFichas[2].Ficha.Click += new System.EventHandler(this.FichaAzul3_Click);
                this.jugadorAzul.ListFichas[3].Ficha.Click += new System.EventHandler(this.FichaAzul4_Click);

            }
            if (jugadorRojo.Tipo == "cpu" || jugadorRojo.Tipo == "player")
            {
                //Paso 1
                jugadorRojo.CrearFichas();

                //Paso 2
                foreach (Fichas i in jugadorRojo.ListFichas)
                {
                    this.Controls.Add(i.Ficha);
                }

                //Paso 3
                jugadorRojo.ListFichas[0].Ficha.Click += new System.EventHandler(FichaRoja1_Click);
                jugadorRojo.ListFichas[1].Ficha.Click += new System.EventHandler(FichaRoja2_Click);
                jugadorRojo.ListFichas[2].Ficha.Click += new System.EventHandler(FichaRoja3_Click);
                jugadorRojo.ListFichas[3].Ficha.Click += new System.EventHandler(FichaRoja4_Click);
            }
            if (jugadorAmarillo.Tipo == "cpu" || jugadorAmarillo.Tipo == "player")
            {
                //Paso 1
                jugadorAmarillo.CrearFichas();

                //Paso 2
                foreach (Fichas i in jugadorAmarillo.ListFichas)
                {
                    this.Controls.Add(i.Ficha);
                }

                //Paso 3
                jugadorAmarillo.ListFichas[0].Ficha.Click += new System.EventHandler(FichaAmarilla1_Click);
                jugadorAmarillo.ListFichas[1].Ficha.Click += new System.EventHandler(FichaAmarilla2_Click);
                jugadorAmarillo.ListFichas[2].Ficha.Click += new System.EventHandler(FichaAmarilla3_Click);
                jugadorAmarillo.ListFichas[3].Ficha.Click += new System.EventHandler(FichaAmarilla4_Click);
            }
            if (jugadorVerde.Tipo == "cpu" || jugadorVerde.Tipo == "player")
            {
                //Paso 1
                jugadorVerde.CrearFichas();

                //Paso 2
                foreach (Fichas i in jugadorVerde.ListFichas)
                {
                    this.Controls.Add(i.Ficha);
                }

                //Paso 3
                jugadorVerde.ListFichas[0].Ficha.Click += new System.EventHandler(FichaVerde1_Click);
                jugadorVerde.ListFichas[1].Ficha.Click += new System.EventHandler(FichaVerde2_Click);
                jugadorVerde.ListFichas[2].Ficha.Click += new System.EventHandler(FichaVerde3_Click);
                jugadorVerde.ListFichas[3].Ficha.Click += new System.EventHandler(FichaVerde4_Click);
            }
        }

        //*******EmpezarJuego*********
        public void EmpezarJuego()
        {
            if (jugadorAzul.Tipo != "none")
            {
                TurnoAzul();
            }else if (jugadorRojo.Tipo != "none")
            {
                TurnoRojo();
            }else
            {
                TurnoVerde();
            }               
        }

        //*********Turnos de los jugadores**************
        public void TurnoAzul()
        {
            buttonDado_Azul.Enabled = true;
            timerAzul.Enabled = true;
            tiempo = 30;
            timerAzul.Start();
        }
        public void TurnoRojo()
        {
            buttonDado_Rojo.Enabled = true;
            timerRojo.Enabled = true;
            tiempo = 30;
            timerRojo.Start();
        }
        public void TurnoAmarillo()
        {
            buttonDado_Amarillo.Enabled = true;
            timerAmarillo.Enabled = true;
            tiempo = 30;
            timerAmarillo.Start();
        }
        public void TurnoVerde()
        {
            buttonDado_Verde.Enabled = true;
            timerVerde.Enabled = true;
            tiempo = 30;
            timerVerde.Start();
        }

        //*******Eventos de los pictureBox fichas**********
        //Se controla que la ficha este en el tablero
        //True: se setea el int indiceBoton con el indice de la ficha 
        public void FichaAzul1_Click(object? sender, EventArgs e)
        {
            if (jugadorAzul.ListFichas[0].Salida)
            {
                indiceBoton = 0;
            }
        }
        public void FichaAzul2_Click(object? sender, EventArgs e)
        {
            if (jugadorAzul.ListFichas[1].Salida)
            {
                indiceBoton = 1;
            }
        }
        public void FichaAzul3_Click(object? sender, EventArgs e)
        {
            if (jugadorAzul.ListFichas[2].Salida)
            {
                indiceBoton = 2;
            }
        }
        public void FichaAzul4_Click(object? sender, EventArgs e)
        {
            if (jugadorAzul.ListFichas[3].Salida)
            {
                indiceBoton = 3;
            }
        }
        public void FichaRoja1_Click(object? sender, EventArgs e)
        {
            if (jugadorRojo.ListFichas[0].Salida)
            {
                indiceBoton = 0;
            }
        }
        public void FichaRoja2_Click(object? sender, EventArgs e)
        {
            if (jugadorRojo.ListFichas[1].Salida)
            {
                indiceBoton = 1;
            }
        }
        public void FichaRoja3_Click(object? sender, EventArgs e)
        {
            if (jugadorRojo.ListFichas[2].Salida)
            {
                indiceBoton = 2;
            }
        }
        public void FichaRoja4_Click(object? sender, EventArgs e)
        {
            if (jugadorRojo.ListFichas[3].Salida)
            {
                indiceBoton = 3;
            }
        }
        public void FichaAmarilla1_Click(object? sender, EventArgs e)
        {
            if (jugadorAmarillo.ListFichas[0].Salida)
            {
                indiceBoton = 0;
            }
        }
        public void FichaAmarilla2_Click(object? sender, EventArgs e)
        {
            if (jugadorAmarillo.ListFichas[1].Salida)
            {
                indiceBoton = 1;
            }
        }
        public void FichaAmarilla3_Click(object? sender, EventArgs e)
        {
            if (jugadorAmarillo.ListFichas[2].Salida)
            {
                indiceBoton = 2;
            }
        }
        public void FichaAmarilla4_Click(object? sender, EventArgs e)
        {
            if (jugadorAmarillo.ListFichas[3].Salida)
            {
                indiceBoton = 3;
            }

        }
        public void FichaVerde1_Click(object? sender, EventArgs e)
        {
            if (jugadorVerde.ListFichas[0].Salida)
            {
                indiceBoton = 0;
            }
        }
        public void FichaVerde2_Click(object? sender, EventArgs e)
        {
            if (jugadorVerde.ListFichas[1].Salida)
            {
                indiceBoton = 1;
            }
        }
        public void FichaVerde3_Click(object? sender, EventArgs e)
        {
            if (jugadorVerde.ListFichas[2].Salida)
            {
                indiceBoton = 2;
            }
        }
        public void FichaVerde4_Click(object? sender, EventArgs e)
        {
            if (jugadorVerde.ListFichas[3].Salida)
            {
                indiceBoton = 3;
            }
        }

        //******Eventos de los botones dados*******
        //Paso 1: Se genera un numero Random el cual va a corresponder al movimiento de la ficha y se lo muestra por el textbox, si el numero es igual a 6 se setea a true el "btn+Color_Jugador" para que pueda tirar devuelta.
        //Paso 2: Si sale 6 se controla si hay fichas en la carcel y que no haya ninguna ficha en la posicion inicial de salida.
        //Paso 2.1: True: se mueve una ficha a la poscion inicial.
        //Paso 2.2: False: Se controla si hay fichas afuera, en caso de que haya, se espera hasta que el jugador elija la ficha para moverla.
        private async void buttonDado_Azul_Click(object sender, EventArgs e)
        {
            //Paso 1
            int id_ficha;
            Random rdm = new Random(DateTime.Now.Millisecond);
            movimientos = rdm.Next(1, 7);
            textBoxDado_Azul.Text = movimientos.ToString();

            //Paso 2
            if (movimientos == 6 && !jugadorAzul.ControlarContenedor(out id_ficha) && jugadorAzul.ControlarSalida())
            {
                               
                jugadorAzul.ListFichas[id_ficha].Ficha.Size = new Size(42, 42);
                jugadorAzul.ListFichas[id_ficha].Ficha.Location = new Point(428, 45);
                jugadorAzul.ListFichas[id_ficha].Salida = true;
                jugadorAzul.ComerFicha(jugadorAzul.ListFichas[id_ficha], jugadorRojo, jugadorVerde, jugadorAmarillo);
                buttonDado_Azul.Enabled = false;            
            }
            else
            {
                //Paso 2.2
                if (jugadorAzul.FichaAfuera())
                {
                    do
                    {
                        buttonDado_Azul.Enabled = false;
                        await Task.Delay(100);
                    }
                    while (indiceBoton == -1);                   
                    jugadorAzul.MoverFichas_Azul(movimientos, jugadorAzul.ListFichas[indiceBoton], labelPuntaje_Azul);
                    jugadorAzul.ComerFicha(jugadorAzul.ListFichas[indiceBoton], jugadorRojo, jugadorVerde, jugadorAmarillo);
                    indiceBoton = -1;
                }
            }
            if (movimientos == 6 && !jugadorAzul.Ganador)
            {
                timerAzul.Stop();
                timerRojo.Enabled = false;
                labelTiempoAzul.Text = "30";
                buttonDado_Azul.Enabled = false;
                TurnoAzul();
            }
            else
            {
                timerAzul.Stop();
                buttonDado_Azul.Enabled = false;
                labelTiempoAzul.Text = "30";
                if (jugadorRojo.Tipo != "none")
                {
                    TurnoRojo();
                }else if (jugadorVerde.Tipo != "none")
                {
                    TurnoVerde();
                }else 
                {
                    TurnoAmarillo();
                }                
            }
        }
        private async void buttonDado_Amarillo_Click(object sender, EventArgs e)
        {
            //Paso 1
            int id_ficha;
            Random rdm = new Random(DateTime.Now.Millisecond);
            movimientos = rdm.Next(1, 7);
            textBoxDado_Amarillo.Text = movimientos.ToString();
          

            //Paso 2
            if (movimientos == 6 && !jugadorAmarillo.ControlarContenedor(out id_ficha) && jugadorAmarillo.ControlarSalida())
            {                
                jugadorAmarillo.ListFichas[id_ficha].Ficha.Size = new Size(42, 42);
                jugadorAmarillo.ListFichas[id_ficha].Ficha.Location = new Point(215, 353);
                jugadorAmarillo.ListFichas[id_ficha].Salida = true;
                jugadorAmarillo.ComerFicha(jugadorAmarillo.ListFichas[id_ficha], jugadorRojo, jugadorVerde, jugadorAzul);
                buttonDado_Amarillo.Enabled = false;                                 
            }
            else
            {
                //Paso 2.2
                if (jugadorAmarillo.FichaAfuera())
                {
                    do
                    {
                        buttonDado_Amarillo.Enabled = false;
                        await Task.Delay(100);
                    }
                    while (indiceBoton == -1);                   
                    jugadorAmarillo.MoverFichas_Amarilla(movimientos, jugadorAmarillo.ListFichas[indiceBoton], labelPuntaje_Amarillo);
                    jugadorAmarillo.ComerFicha(jugadorAmarillo.ListFichas[indiceBoton], jugadorRojo, jugadorVerde, jugadorAzul);
                    indiceBoton = -1;
                }
            }
            if (movimientos == 6 && !jugadorAmarillo.Ganador)
            {
                timerAmarillo.Stop();
                timerAmarillo.Enabled = false;
                labelTiempoAmarillo.Text = "30";
                buttonDado_Amarillo.Enabled = false;
                TurnoAmarillo();
            }
            else
            {
                timerAzul.Stop();
                buttonDado_Amarillo.Enabled = false;
                labelTiempoAmarillo.Text = "30";
                if (jugadorAzul.Tipo != "none")
                {
                    TurnoAzul();
                }
                else if (jugadorRojo.Tipo != "none")
                {
                    TurnoRojo();
                }
                else
                {
                    TurnoVerde();
                }
            }
        }
        private async void buttonDado_Verde_Click(object sender, EventArgs e)
        {
            //Paso 1
            int id_ficha;
            Random rdm = new Random(DateTime.Now.Millisecond);
            movimientos = rdm.Next(1, 7);
            textBoxDado_Verde.Text = movimientos.ToString();
            
            //Paso 2
            if (movimientos == 6 && !jugadorVerde.ControlarContenedor(out id_ficha) && jugadorVerde.ControlarSalida())
            {
                //Paso 2.1
                jugadorVerde.ListFichas[id_ficha].Ficha.Size = new Size(42, 42);
                jugadorVerde.ListFichas[id_ficha].Ficha.Location = new Point(512, 573);
                jugadorVerde.ListFichas[id_ficha].Salida = true;
                jugadorVerde.ComerFicha(jugadorVerde.ListFichas[id_ficha], jugadorAzul, jugadorRojo, jugadorAmarillo);
                buttonDado_Verde.Enabled = false;
            }
            else
            {
                //Paso 2.2
                if (jugadorVerde.FichaAfuera())
                {
                    do
                    {
                        buttonDado_Verde.Enabled = false;
                        await Task.Delay(100);
                    }
                    while (indiceBoton == -1);
                    jugadorVerde.MoverFichas_Verde(movimientos, jugadorVerde.ListFichas[indiceBoton], labelPuntaje_Verde);
                    jugadorVerde.ComerFicha(jugadorVerde.ListFichas[indiceBoton], jugadorRojo, jugadorAzul, jugadorAmarillo);
                    indiceBoton = -1;
                }
            }
            if (movimientos == 6 && !jugadorVerde.Ganador)
            {
                timerVerde.Stop();
                timerVerde.Enabled = false;
                labelTiempoVerde.Text = "30";
                buttonDado_Verde.Enabled = false;
                TurnoVerde();
            }
            else
            {
                timerAzul.Stop();
                buttonDado_Verde.Enabled = false;
                labelTiempoVerde.Text = "30";
                if (jugadorAmarillo.Tipo != "none")
                {
                    TurnoAmarillo();
                }
                else if (jugadorAzul.Tipo != "none")
                {
                    TurnoAzul();
                }
                else
                {
                    TurnoRojo();
                }
            }
        }
        private async void buttonDado_Rojo_Click(object sender, EventArgs e)
        {
            //Paso 1
            int id_ficha;
            Random rdm = new Random(DateTime.Now.Millisecond);
            movimientos = rdm.Next(1, 7);
            textBoxDado_Rojo.Text = movimientos.ToString();

            //Paso 2
            if (movimientos == 6 && !jugadorRojo.ControlarContenedor(out id_ficha) && jugadorRojo.ControlarSalida())
            {
                //Paso 2.1
                jugadorRojo.ListFichas[id_ficha].Ficha.Size = new Size(42, 42);
                jugadorRojo.ListFichas[id_ficha].Ficha.Location = new Point(725, 265);
                jugadorRojo.ListFichas[id_ficha].Salida = true;
                jugadorRojo.ComerFicha(jugadorRojo.ListFichas[id_ficha], jugadorAzul, jugadorVerde, jugadorAmarillo);
                buttonDado_Rojo.Enabled = false;
            }
            else
            {
                //Paso 2.2
                if (jugadorRojo.FichaAfuera())
                {
                    do
                    {
                        buttonDado_Rojo.Enabled = false;
                        await Task.Delay(100);
                    }
                    while (indiceBoton == -1);
                    jugadorRojo.MoverFichas_Rojo(movimientos, jugadorRojo.ListFichas[indiceBoton], labelPuntaje_Rojo);
                    jugadorRojo.ComerFicha(jugadorRojo.ListFichas[indiceBoton], jugadorAzul, jugadorVerde, jugadorAmarillo);
                    indiceBoton = -1;
                }
            }
            if (movimientos == 6 && !jugadorRojo.Ganador)
            {
                timerRojo.Stop();
                timerRojo.Enabled = false;
                labelTiempoRojo.Text = "30";
                buttonDado_Rojo.Enabled = false;
                TurnoRojo();
            }
            else
            {
                timerAzul.Stop();
                buttonDado_Rojo.Enabled = false;
                labelTiempoRojo.Text = "30";
                if (jugadorVerde.Tipo != "none")
                {
                    TurnoVerde();
                }
                else if (jugadorVerde.Tipo != "none")
                {
                    TurnoAmarillo();
                }
                else
                {
                    TurnoAzul();
                }
            }
        }


        //***********Eventos de los Timers************
        private void timerAzul_Tick(object sender, EventArgs e)
        {
            tiempo--;
            labelTiempoAzul.Text = tiempo.ToString();
            if (tiempo == 0 && !jugadorAzul.Ganador)
            {
                buttonDado_Azul.Enabled = false;
                timerAzul.Stop();
                labelTiempoAzul.Text = "30";
                if (jugadorRojo.Tipo != "none")
                {
                    TurnoRojo();
                }
                else if (jugadorVerde.Tipo != "none")
                {
                    TurnoVerde();
                }
                else
                {
                    TurnoAmarillo();
                }
            }
        }
        private void timerRojo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            labelTiempoRojo.Text = tiempo.ToString();
            if (tiempo == 0 && !jugadorRojo.Ganador)
            {
                buttonDado_Rojo.Enabled = false;
                timerRojo.Stop();
                labelTiempoAzul.Text = "30";
                if (jugadorVerde.Tipo != "none")
                {
                    TurnoVerde();
                }
                else if (jugadorVerde.Tipo != "none")
                {
                    TurnoAmarillo();
                }
                else
                {
                    TurnoAzul();
                }
            }
        }
        private void timerAmarillo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            labelTiempoAmarillo.Text = tiempo.ToString();
            if (tiempo == 0 && !jugadorAmarillo.Ganador)
            {
                buttonDado_Amarillo.Enabled = false;
                timerAmarillo.Stop();
                labelTiempoAzul.Text = "30";
                if (jugadorAzul.Tipo != "none")
                {
                    TurnoAzul();
                }
                else if (jugadorRojo.Tipo != "none")
                {
                    TurnoRojo();
                }
                else
                {
                    TurnoVerde();
                }
            }
        }
        private void timerVerde_Tick(object sender, EventArgs e)
        {
            tiempo--;
            labelTiempoVerde.Text = tiempo.ToString();
            if (tiempo == 0 && !jugadorVerde.Ganador)
            {
                buttonDado_Verde.Enabled = false;
                timerVerde.Stop();
                labelTiempoAzul.Text = "30";
                if (jugadorAmarillo.Tipo != "none")
                {
                    TurnoAmarillo();
                }
                else if (jugadorAzul.Tipo != "none")
                {
                    TurnoAzul();
                }
                else
                {
                    TurnoRojo();
                }
            }
        }
    }
}
