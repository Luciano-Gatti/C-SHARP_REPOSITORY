using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V2._0
{
    internal class Jugador  
    {
        //Atributos de cada Jugador
        private string color_jugador;
        private string tipo;        
        private List <Fichas> listFichas;
        private bool ganador;
        private int contFichas;

        //coordenadas de las posiciones iniciales de las fichas de acuerdo al color
        private int[,] posInicial_Verdes = { {609,456},{695,456},{610,544},{695,544}};
        private int[,] posInicial_Azules = { {228,60},{315,61},{229,148},{314,148}};
        private int[,] posInicial_Amarillas = {{229,459},{315,456},{230,544},{315,544}};
        private int[,] posInicial_Rojas = {{609,60},{695,60},{610,148},{695,148}};

        //Coordenadas de movimientos que puede realizar cada pictureBox de acuerdo al color
        int[,] movimientosAzul = {{428,45},{428,90},{428,134},{428,178},{429,221},{386,266},{343,265},{301,265},
            {258,265},{216,265},{174,265},{174,309},{173,353},{215,353},{258,353},{301,353},{344,353},
            {386,353},{428,397}, {429,441},{427,485},{428,529},{428,574},{428,617},{470,617},{513,617},
            {512,573},{513,529},{512,485},{513,441},{512,397},{555,353},{598,353},{640,353},{682,353},
            {725,353},{768,353},{767,309},{767,265},{725,265},{682,265},{640,265},{598,265},{555,265},
            {512,221},{512,177},{512,134},{512,90},{512,45},{512,1},{470,1},{470,45},{470,89},{470,134},
            {470,177},{470,221},{470,269}};

        int[,] movimientosRojo = {{725,265},{682,265},{640,265},{598,265},{555,265},{512,221},{512,177}
            ,{512,134},{512,90},{512,45},{512,1},{470,1},{428,45},{428,90},{428,134},{428,178},{429,221},{386,266},{343,265},{301,265},
            {258,265},{216,265},{174,265},{174,309},{173,353},{215,353},{258,353},{301,353},{344,353},
            {386,353},{428,397}, {429,441},{427,485},{428,529},{428,574},{428,617},{470,617},{513,617},
            {512,573},{513,529},{512,485},{513,441},{512,397},{555,353},{598,353},{640,353},{682,353},
            {725,353},{768,353},{767,309},{725,309},{682,309},{640,309},{597,309},{555,309},{510,310}};

        int[,] movimientosAmarillo = {{215,353},{258,353},{301,353},{344,353},{386,353},
            {428,397}, {429,441},{427,485},{428,529},{428,574},{428,617},{470,617},{513,617},
            {512,573},{513,529},{512,485},{513,441},{512,397},{555,353},{598,353},{640,353},{682,353},
            {725,353},{768,353},{767,309},{767,265},{725,265},{682,265},{640,265},{598,265},{555,265},
            {512,221},{512,177},{512,134},{512,90},{512,45},{512,1},{470,1},{428,45},{428,90},{428,134},
            {428,178},{429,221},{386,266},{343,265},{301,265},{258,265},{216,265},{174,265},{174,309},{215,309},
            {258,309},{301,309},{343,309},{385,309},{429,309}};

        int[,] movimientosVerde = {{512,573},{513,529},{512,485},{513,441},{512,397},{555,353},{598,353},{640,353},{682,353},
            {725,353},{768,353},{767,309},{767,265},{725,265},{682,265},{640,265},{598,265},{555,265},{512,221},{512,177},
            {512,134},{512,90},{512,45},{512,1},{470,1},{428,45},{428,90},{428,134},{428,178},{429,221},{386,266},{343,265},
            {301,265},{258,265},{216,265},{174,265},{174,309},{215,353},{258,353},{301,353},{344,353},{386,353},{428,397}, 
            {429,441},{427,485},{428,529},{428,574},{428,617},{470,617},{470,573},{470,529},{470,485},{470,441},{470,397},{470,352}};
        

        //Constructor de la clase Jugador
        public Jugador(string color, string tipo)
        {
            this.color_jugador = color;
            this.tipo = tipo;
            this.listFichas = new List <Fichas>();
            this.ganador = false;
            this.contFichas = 0;
        }

        //Getters y Setters
        public string Color_jugador { get => color_jugador; set => color_jugador = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Ganador { get => ganador; set => ganador = value; }
        internal List<Fichas> ListFichas { get => listFichas; set => listFichas = value; }
        public int[,] PosInicial_Verdes { get => posInicial_Verdes; set => posInicial_Verdes = value; }
        public int[,] PosInicial_Azules { get => posInicial_Azules; set => posInicial_Azules = value; }
        public int[,] PosInicial_Amarillas { get => posInicial_Amarillas; set => posInicial_Amarillas = value; }
        public int[,] PosInicial_Rojas { get => posInicial_Rojas; set => posInicial_Rojas = value; }

        //Metodos de la clase
        //***********Creacion de fichas***************
        public void CrearFichas()
        {
            //Se crean las fichas y se le asignan los datos que son iguales independientemente del color
            for (int i = 0; i < 4; i++)
            {
                bool salida = false; 
                PictureBox crearficha = new PictureBox();
                crearficha.BackColor = Color.Transparent;     //Color del fondo de la ficha
                crearficha.Size = new Size(55, 55);            //Tamaño de la ficha
                crearficha.SizeMode = PictureBoxSizeMode.Zoom; //Adaptacion de la imagen de la ficha en el pictureBox
                Fichas ficha = new Fichas(crearficha, salida);              //Se crea una ficha               
                ListFichas.Add(ficha);                              //Se agrega la ficha al arreglo de fichas
            }

            //Ahora se asignan los datos que varian de acuerdo al color de las fichas 
            if (color_jugador == "azul")
            {
                for(int i = 0;i< 4; i++)
                {
                    ListFichas[i].Ficha.Location = new Point(PosInicial_Azules[i, 0], PosInicial_Azules[i, 1]); //Posicion de cada ficha azul  
                    ListFichas[i].PosicionInicial[0,0] = posInicial_Azules[i,0];
                    ListFichas[i].PosicionInicial[0,1] = posInicial_Azules[i,1];
                    ListFichas[i].Ficha.Image = Properties.Resources.blue_g5; //Imagen de cada ficha azul                                      
                }
            }
            else if (color_jugador == "rojo")
            {
                for (int i = 0; i < 4; i++)
                {
                    ListFichas[i].Ficha.Location = new Point(PosInicial_Rojas[i, 0], PosInicial_Rojas[i, 1]); //Posicion de cada ficha roja                                                                                                   
                    ListFichas[i].PosicionInicial[0,0] = posInicial_Rojas[i,0];
                    ListFichas[i].PosicionInicial[0,1] = posInicial_Rojas[i,1];
                    ListFichas[i].Ficha.Image = Properties.Resources.red_g5; //Imagen de cada ficha roja   
                }
            }
            else if (color_jugador == "amarillo")
            {
                for (int i = 0; i < 4; i++)
                {
                    ListFichas[i].Ficha.Location = new Point(PosInicial_Amarillas[i, 0], PosInicial_Amarillas[i, 1]); //Posicion de cada ficha amarilla 
                    ListFichas[i].PosicionInicial[0,0] = posInicial_Amarillas[i,0];
                    ListFichas[i].PosicionInicial[0,1] = posInicial_Amarillas[i,1];
                    ListFichas[i].Ficha.Image = Properties.Resources.yellow_g5; //Imagen de cada ficha amarilla 
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    ListFichas[i].Ficha.Location = new Point(PosInicial_Verdes[i, 0], PosInicial_Verdes[i, 1]); //Posicion de cada ficha verde 
                    ListFichas[i].PosicionInicial[0,0] = posInicial_Verdes[i,0];
                    ListFichas[i].PosicionInicial[0,1] = posInicial_Verdes[i,1];
                    ListFichas[i].Ficha.Image = Properties.Resources.green_g5; //Imagen de cada ficha verde         
                }
            }
        }        

        //**********Control de la carcel de fichas*****************
        public bool ControlarContenedor(out int id_ficha)
        {
            bool controlar = true;
            int cont = -1;
            foreach (Fichas ficha in ListFichas)
            {
                cont++;
                if (ficha.Salida)
                {
                    controlar = true;
                }
                else
                {
                    controlar = false;                    
                    break;
                }
            }
            id_ficha = cont;
            return controlar;
        }

        //********Control de fichas en coordenadas de la posicion de salida************
        public bool ControlarSalida()
        {   
            bool controlar = true;
            foreach (Fichas ficha in ListFichas) 
            {
                if (color_jugador == "azul")
                {
                    if (ficha.Salida && (ficha.Ficha.Location.X == 428 && ficha.Ficha.Location.Y == 45))
                    {
                        controlar = false;
                        break;
                    }
                    else
                    {
                        controlar = true;
                    }
                }else if (color_jugador == "rojo")
                {
                    if (ficha.Salida && (ficha.Ficha.Location.X == 725 && ficha.Ficha.Location.Y == 265))
                    {
                        controlar = false;
                        break;
                    }
                    else
                    {
                        controlar = true;
                    }
                }else if (color_jugador == "amarillo")
                {
                    if (ficha.Salida && (ficha.Ficha.Location.X == 215  && ficha.Ficha.Location.Y == 353))
                    {
                        controlar = false;
                        break;
                    }
                    else
                    {
                        controlar = true;
                    }
                }
                else
                {
                    if (ficha.Salida && (ficha.Ficha.Location.X == 512 && ficha.Ficha.Location.Y == 573))
                    {
                        controlar = false;
                        break;
                    }
                    else
                    {
                        controlar = true;
                    }
                }
                
            }
            return controlar;
        }

        //********Control de fichas en el tablero**********
        public bool FichaAfuera()
        {
            bool control = true;
            foreach (Fichas i in ListFichas)
            {
                if (i.Salida)
                {
                    control = true;
                    break;
                }
                else
                {
                    control = false;  
                }
            }

            return control;
        }

        //*******Comer a otra ficha*************
        public void ComerFicha(Fichas ficha, Jugador jugador1, Jugador jugador2, Jugador jugador3)
        {
            bool control = false;
            int cont = -1;

            foreach (Fichas f in jugador1.ListFichas)
            {
                cont++;
                if (ficha.Ficha.Location.X == f.Ficha.Location.X && ficha.Ficha.Location.Y == f.Ficha.Location.Y)
                {
                    control = true;
                    break;
                }
                else
                {
                    control = false;
                }    
            }
            if (control)
            {
                jugador1.ListFichas[cont].Ficha.Size = new Size(55,55);
                jugador1.ListFichas[cont].Ficha.Location = new Point(jugador1.listFichas[cont].PosicionInicial[0,0], jugador1.listFichas[cont].PosicionInicial[0,1]);
                jugador1.ListFichas[cont].Salida = true;
            }

            cont = -1;
            foreach (Fichas f in jugador2.ListFichas)
            {
                cont++;
                if (ficha.Ficha.Location.X == f.Ficha.Location.X && ficha.Ficha.Location.Y == f.Ficha.Location.Y)
                {
                    control = true;
                    break;
                }
                else
                {
                    control = false;
                }
            }
            if (control)
            {
                jugador2.ListFichas[cont].Ficha.Size = new Size(55, 55);
                jugador2.ListFichas[cont].Ficha.Location = new Point(jugador2.listFichas[cont].PosicionInicial[0, 0], jugador2.listFichas[cont].PosicionInicial[0, 1]);
                jugador2.ListFichas[cont].Salida = true;
            }

            cont = -1;
            foreach (Fichas f in jugador3.ListFichas)
            {
                cont++;
                if (ficha.Ficha.Location.X == f.Ficha.Location.X && ficha.Ficha.Location.Y == f.Ficha.Location.Y)
                {
                    control = true;
                    break;
                }
                else
                {
                    control = false;
                }
            }
            if (control)
            {
                jugador3.ListFichas[cont].Ficha.Size = new Size(55, 55);
                jugador3.ListFichas[cont].Ficha.Location = new Point(jugador3.listFichas[cont].PosicionInicial[0,0], jugador3.listFichas[cont].PosicionInicial[0,1]);
                jugador3.ListFichas[cont].Salida = true;
            }
        }

        //*******Movimiento de fichas*********
        public void MoverFichas_Azul (int movimiento, Fichas ficha, Label label)
        {
            int tamArrg;
            ficha.PosicionFicha += movimiento;
            tamArrg = (movimientosAzul.Length / 2) - 1;

            if (ficha.PosicionFicha < tamArrg)
            {                
                ficha.Ficha.Location = new Point(movimientosAzul[ficha.PosicionFicha,0], movimientosAzul[ficha.PosicionFicha,1]);
            }
            else
            {
                if (ficha.PosicionFicha == tamArrg)
                {
                    //Se liberan los recursos del picturbox y se setea la imagen a null
                    ficha.Ficha.Image.Dispose();
                    ficha.Ficha.Image = null;
                    contFichas++;
                    label.Text = contFichas.ToString();
                    if (contFichas == 4)
                    {
                        ganador = true;
                        MessageBox.Show("JUGADOR AZUL HA GANADO");
                    }
                }
                else
                {
                    ficha.PosicionFicha -= movimiento;
                }
            } 
        }
        public void MoverFichas_Amarilla(int movimiento, Fichas ficha, Label label)
        {
            int tamArrg;
            ficha.PosicionFicha += movimiento;
            tamArrg = (movimientosAmarillo.Length / 2) - 1;

            if (ficha.PosicionFicha < tamArrg)
            {
                ficha.Ficha.Location = new Point(movimientosAmarillo[ficha.PosicionFicha, 0], movimientosAmarillo[ficha.PosicionFicha, 1]);
            }
            else
            {
                if (ficha.PosicionFicha == tamArrg)
                {
                    //Se liberan los recursos del picturbox y se setea la imagen a null
                    ficha.Ficha.Image.Dispose();
                    ficha.Ficha.Image = null;
                    contFichas++;
                    label.Text = contFichas.ToString();
                    if (contFichas == 4)
                    {
                        ganador = true;
                        MessageBox.Show("JUGADOR AMARILLO HA GANADO");
                    }
                }
                else
                {
                    ficha.PosicionFicha -= movimiento;
                }
            }
        }
        public void MoverFichas_Rojo(int movimiento, Fichas ficha, Label label)
        {
            int tamArrg;
            ficha.PosicionFicha += movimiento;
            tamArrg = (movimientosRojo.Length / 2) - 1;

            if (ficha.PosicionFicha < tamArrg)
            {
                ficha.Ficha.Location = new Point(movimientosRojo[ficha.PosicionFicha, 0], movimientosRojo[ficha.PosicionFicha, 1]);
            }
            else
            {
                if (ficha.PosicionFicha == tamArrg)
                {
                    //Se liberan los recursos del picturbox y se setea la imagen a null
                    ficha.Ficha.Image.Dispose();
                    ficha.Ficha.Image = null;
                    contFichas++;
                    label.Text = contFichas.ToString();
                    if (contFichas == 4)
                    {
                        ganador = true;
                        MessageBox.Show("JUGADOR ROJO HA GANADO");
                    }
                }
                else
                {
                    ficha.PosicionFicha -= movimiento;
                }
            }
        }
        public void MoverFichas_Verde(int movimiento, Fichas ficha, Label label)
        {
            int tamArrg;
            ficha.PosicionFicha += movimiento;
            tamArrg = (movimientosVerde.Length / 2) - 1;

            if (ficha.PosicionFicha < tamArrg)
            {
                ficha.Ficha.Location = new Point(movimientosVerde[ficha.PosicionFicha, 0], movimientosVerde[ficha.PosicionFicha, 1]);
            }
            else
            {
                if (ficha.PosicionFicha == tamArrg)
                {
                    //Se liberan los recursos del picturbox y se setea la imagen a null
                    ficha.Ficha.Image.Dispose();
                    ficha.Ficha.Image = null;
                    contFichas++;
                    label.Text = contFichas.ToString();
                    if (contFichas == 4)
                    {
                        ganador = true;
                        MessageBox.Show("JUGADOR VERDE HA GANADO");
                    }
                }
                else
                {
                    ficha.PosicionFicha -= movimiento;
                }
            }
        }
    }
}
