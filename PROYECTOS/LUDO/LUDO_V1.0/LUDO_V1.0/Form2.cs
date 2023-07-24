using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUDO_V1._0
{
    public partial class Form2 : Form
    {

        int dado_azul, cont_fichaAzul1;
        bool controlarBotones = true;
        bool salida_fichaAzul1 = true;
        int[,] movimientosAzul = {{428,45},{428,90},{428,134},{428,178},{429,221},{386,266},{343,265},{301,265},
        {258,265},{216,265},{174,265},{174,309},{173,353},{215,353},{258,353},{301,353},{344,353},
        {386,353},{428,397}, {429,441},{427,485},{428,529},{428,574},{428,617},{470,617},{513,617},
        {512,573},{513,529},{512,485},{513,441},{512,397},{555,353},{598,353},{640,353},{682,353},
        {725,353},{768,353},{767,309},{767,265},{725,265},{682,265},{640,265},{598,265},{555,265},
        {512,221},{512,177},{512,134},{512,90},{512,45},{512,1},{470,1},{470,45},{470,89},{470,134},
        {470,177},{470,221},{470,269}};


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Se controla los jugadores y se establece como transparente el color de fondo de las imagenes de las fichas
            //Ademas se desactivan los botones de los dados hasta que sea el turno de cada jugador
            //Si algun color no es ocupado se eliminan las fichas del tablero

            //fichas azules
            ficha_azul1.BackColor = Color.Transparent;
            ficha_azul2.BackColor = Color.Transparent;
            ficha_azul3.BackColor = Color.Transparent;
            ficha_azul4.BackColor = Color.Transparent;
            buttonDado_Azul.Enabled = false;
            salida_fichaAzul1 = false;
            //Liberamos los recursos utilizados.
            //ficha_azul1.Dispose();
            //ficha_azul2.Dispose();
            //ficha_azul3.Dispose();
            //ficha_azul4.Dispose();

            //Establecemos a "null" los controles ficha_azul.
            //ficha_azul1 = null;
            //ficha_azul2 = null;
            //ficha_azul3 = null;
            //ficha_azul4 = null;


            //if (jugador_rojo == "player" || jugador_rojo == "cpu")
            //{
            //    //fichas rojas
            //    ficha_roja1.BackColor = Color.Transparent;
            //    ficha_roja2.BackColor = Color.Transparent;
            //    ficha_roja3.BackColor = Color.Transparent;
            //    ficha_roja4.BackColor = Color.Transparent;
            //    buttonDado_Rojo.Enabled = false;
            //}
            //else
            //{
            //Liberamos los recursos utilizados.
            ficha_roja1.Dispose();
            ficha_roja2.Dispose();
            ficha_roja3.Dispose();
            ficha_roja4.Dispose();

            //Establecemos a "null" los controles ficha_roja.
            ficha_roja1 = null;
            ficha_roja2 = null;
            ficha_roja3 = null;
            ficha_roja4 = null;
            //}
            //if (jugador_amarillo == "player" || jugador_amarillo == "cpu")
            //{
            //    //fichas amarillas
            //    ficha_amarilla1.BackColor = Color.Transparent;
            //    ficha_amarilla2.BackColor = Color.Transparent;
            //    ficha_amarilla3.BackColor = Color.Transparent;
            //    ficha_amarilla4.BackColor = Color.Transparent;
            //    buttonDado_Amarillo.Enabled = false;
            //}
            //else
            //{
            //Liberamos los recursos utilizados.
            ficha_amarilla1.Dispose();
            ficha_amarilla2.Dispose();
            ficha_amarilla3.Dispose();
            ficha_amarilla4.Dispose();

            //Establecemos a "null" los controles ficha_amarilla.
            ficha_amarilla1 = null;
            ficha_amarilla2 = null;
            ficha_amarilla3 = null;
            ficha_amarilla4 = null;

            //}
            //if (jugador_verde == "player" || jugador_verde == "cpu")
            //{
            //    //fichas verdes
            //    ficha_verde1.BackColor = Color.Transparent;
            //    ficha_verde2.BackColor = Color.Transparent;
            //    ficha_verde3.BackColor = Color.Transparent;
            //    ficha_verde4.BackColor = Color.Transparent;
            //    buttonDado_Verde.Enabled = false;
            //}
            //else
            //{
            //Liberamos los recursos utilizados.
            ficha_verde1.Dispose();
            ficha_verde2.Dispose();
            ficha_verde3.Dispose();
            ficha_verde4.Dispose();

            //Establecemos a "null" los controles ficha_verde.
            ficha_verde1 = null;
            ficha_verde2 = null;
            ficha_verde3 = null;
            ficha_verde4 = null;
            //}
            jugar();
        }

        public void jugar()
        {
            buttonDado_Azul.Enabled = true;
        }

        private void buttonDado_Azul_Click(object sender, EventArgs e)
        {
            Random rdm = new Random(DateTime.Now.Millisecond);
            dado_azul = rdm.Next(1, 7);
            textBoxDado_Azul.Text = dado_azul.ToString();
            if (dado_azul == 6 && !salida_fichaAzul1)
            {
                ficha_azul1.Size = new Size(42, 42);
                ficha_azul1.Location = new Point(428, 45);
                salida_fichaAzul1 = true;
            }
            else
            {
                if (salida_fichaAzul1 && (cont_fichaAzul1 <= movimientosAzul.Length - 1))
                {
                    cont_fichaAzul1 += dado_azul;
                    ficha_azul1.Location = new Point(movimientosAzul[cont_fichaAzul1, 0], movimientosAzul[cont_fichaAzul1, 1]);
                }
            }
        }




        private void buttonDado_Rojo_Click(object sender, EventArgs e)
        {
            Random rdm = new Random(DateTime.Now.Millisecond);
            //dado_rojo = rdm.Next(1, 7).ToString();
        }

        private void buttonDado_Amarillo_Click(object sender, EventArgs e)
        {
            Random rdm = new Random(DateTime.Now.Millisecond);
            //dado_amarillo = rdm.Next(1, 7).ToString();
        }

        private void buttonDado_Verde_Click(object sender, EventArgs e)
        {
            Random rdm = new Random(DateTime.Now.Millisecond);
            //dado_verde = rdm.Next(1, 7).ToString();
        }
    }
}
