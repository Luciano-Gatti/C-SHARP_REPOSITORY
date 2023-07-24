using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V3._0
{
    internal class Fichas
    {
        private PictureBox ficha;
        private bool salida;
        private int posicionFicha;
        private int[,] posicionInicial = { { 0, 0 } };

        public Fichas(PictureBox ficha, bool salida)
        {
            this.ficha = ficha;
            this.salida = salida;
            posicionFicha = 0;
        }


        public PictureBox Ficha { get => ficha; set => ficha = value; }
        public bool Salida { get => salida; set => salida = value; }
        public int PosicionFicha { get => posicionFicha; set => posicionFicha = value; }
        public int[,] PosicionInicial { get => posicionInicial; set => posicionInicial = value; }
    }
}
