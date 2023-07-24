using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V2._0
{
    internal class Fichas
    {
        PictureBox ficha;
        bool ficha_salio;

        public Fichas(PictureBox ficha, bool ficha_salio)
        {
            this.ficha = ficha;
            this.ficha_salio = ficha_salio;
        }


        public bool Ficha_salio { get => ficha_salio; set => ficha_salio = value; }
        public PictureBox Ficha { get => ficha; set => ficha = value; }
    }
}
