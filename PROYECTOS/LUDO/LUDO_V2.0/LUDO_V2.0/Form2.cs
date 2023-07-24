using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDO_V2._0
{
    public partial class Form2 : Form
    {
        Jugador jugador_Azul = new Jugador("azul", "cpu");
        Jugador jugador_Rojo = new Jugador("rojo", "none");
        Jugador jugador_Amarillo = new Jugador("amarillo", "none");
        Jugador jugador_Verde = new Jugador("verde", "none");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F5EEDC");
            EmpezarJuego();
        }

        public void EmpezarJuego()
        {
            if (jugador_Azul.Tipo == "cpu" || jugador_Azul.Tipo == "player")
            {
                jugador_Azul.CrearFichas();
            }
            if (jugador_Rojo.Tipo == "cpu" || jugador_Rojo.Tipo == "player")
            {
                jugador_Rojo.CrearFichas();
            }
            if (jugador_Amarillo.Tipo == "cpu" || jugador_Amarillo.Tipo == "player")
            {
                jugador_Amarillo.CrearFichas();
            }
            if (jugador_Verde.Tipo == "cpu" || jugador_Verde.Tipo == "player")
            {
                jugador_Verde.CrearFichas();
            }
        }
    }
}
