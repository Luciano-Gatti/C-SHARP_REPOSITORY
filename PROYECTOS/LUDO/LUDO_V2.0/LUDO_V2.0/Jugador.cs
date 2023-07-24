using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V2._0
{
    internal class Jugador
    {
        //Atributos de cada jugador
        private string color_jugador;
        private string tipo;        
        private List <Fichas> fichas;
        private bool ganador;

        //Posiciones iniciales de las fichas de acuerdo al color
        private int[,] posInicial_Verdes = { { 609, 456 }, { 695, 456 }, { 610, 544 }, { 695, 544 } };
        private int[,] posInicial_Azules = { { 609, 456 }, { 695, 456 }, { 610, 544 }, { 695, 544 } };
        private int[,] posInicial_Amarillas = { { 609, 456 }, { 695, 456 }, { 610, 544 }, { 695, 544 } };
        private int[,] posInicial_Rojas = { { 609, 456 }, { 695, 456 }, { 610, 544 }, { 695, 544 } };

        public Jugador(string color, string tipo)
        {
            this.color_jugador = color;
            this.tipo = tipo;
            this.fichas = new List <Fichas>();
            this.ganador = false;
        }

        //Getters y Setters
        public string Color_jugador { get => color_jugador; set => color_jugador = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Ganador { get => ganador; set => ganador = value; }
        internal List<Fichas> Fichas { get => fichas; set => fichas = value; }

        //Metodos de la clase
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
                fichas.Add(ficha);                              //Se agrega la ficha al arreglo de fichas
            }

            //Ahora se asignan los datos que varian de acuerdo al color de las fichas 
            if (color_jugador == "azul")
            {
                for(int i = 0;i< 4; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        fichas[i].Ficha.Image = Properties.Resources.blue_g5; //Imagen de cada ficha azul
                        fichas[i].Ficha.Location = new Point(posInicial_Azules[i,j], posInicial_Azules[i,j+1]); //Posicion de cada ficha azul           
                    }
                }
            }
            else if (color_jugador == "rojo")
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        fichas[i].Ficha.Location = new Point(posInicial_Rojas[i, j], posInicial_Rojas[i, j + 1]); //Posicion de cada ficha roja     
                        fichas[i].Ficha.Image = Properties.Resources.blue_g5; //Imagen de cada ficha roja   

                    }
                }
            }
            else if (color_jugador == "amarillo")
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        fichas[i].Ficha.Location = new Point(posInicial_Amarillas[i, j], posInicial_Amarillas[i, j + 1]); //Posicion de cada ficha amarilla 
                        fichas[i].Ficha.Image = Image.FromFile(@"C:\Users\lucia\OneDrive\Documentos\LUCIANO\TUP\PORG_III\WINFORMS\LUDO_V2.0\Resource\yellow_g5.png"); //Imagen de cada ficha amarilla 

                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        fichas[i].Ficha.Location = new Point(posInicial_Verdes[i, j], posInicial_Verdes[i, j + 1]); //Posicion de cada ficha verde 
                        fichas[i].Ficha.Image = Image.FromFile(@"C:\Users\lucia\OneDrive\Documentos\LUCIANO\TUP\PORG_III\WINFORMS\LUDO_V2.0\Resource\yellow_g5.png"); //Imagen de cada ficha verde  

                    }
                }
            }
        }        
    }
}
