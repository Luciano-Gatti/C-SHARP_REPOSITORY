using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V2._0
{
    internal class Fichas
    {
        private PictureBox ficha;
        private bool salida;
             
        public Fichas(PictureBox ficha, bool salida)
        {
            this.ficha = ficha;
            this.salida = salida;            
        }

        public PictureBox Ficha { get => ficha; set => ficha = value; }
        public bool Salida { get => salida; set => salida = value; }
    }
}
