namespace LUDO_V2._0
{
    public partial class Form1 : Form
    {
        string jugadorAzul_tipo = "";
        string jugadorRojo_tipo = "";
        string jugadorAmarillo_tipo = "";
        string jugadorVerde_tipo = "";
        bool jugadorAzul = false;
        bool jugadorRojo = false;
        bool jugadorAmarillo = false;
        bool jugadorVerde = false;
        int azul, rojo, amarillo, verde, numero;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F5EEDC");
            buttonJugar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(jugadorAzul_tipo, jugadorRojo_tipo, jugadorAmarillo_tipo, jugadorVerde_tipo);
            form2.Show();
            this.Hide();
        }

        private void radioButton_cpuAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAzul_tipo = "cpu";
            jugadorAzul = true;
            numero = 0;
            azul = 1;
            controlarEntradas();
        }

        private void radioButton_playerAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAzul_tipo = "player";
            jugadorAzul = true;
            numero = 0;
            azul = 1;
            controlarEntradas();
        }

        private void radioButton_noneAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAzul_tipo = "none";
            jugadorAzul = true;
            numero = 0;
            azul = 0;
            controlarEntradas();
        }

        private void radioButton_cpuRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorRojo_tipo = "cpu";
            jugadorRojo = true;
            numero = 0;
            rojo = 1;
            controlarEntradas();
        }

        private void radioButton_playerRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorRojo_tipo = "player";
            jugadorRojo = true;
            numero = 0;
            rojo = 1;
            controlarEntradas();
        }

        private void radioButton_noneRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorRojo_tipo = "none";
            jugadorRojo = true;
            numero = 0;
            rojo = 0;
            controlarEntradas();
        }

        private void radioButton_cpuAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAmarillo_tipo = "cpu";
            jugadorAmarillo = true;
            numero = 0;
            amarillo = 1;
            controlarEntradas();
        }

        private void radioButton_playerAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAmarillo_tipo = "player";
            jugadorAmarillo = true; 
            numero = 0;
            amarillo = 1;
            controlarEntradas();
        }

        private void radioButton_noneAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugadorAmarillo_tipo = "none";
            jugadorAmarillo = true;
            numero = 0;
            amarillo = 0;
            controlarEntradas();
        }

        private void radioButton_cpuVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugadorVerde_tipo = "cpu";
            jugadorVerde = true;
            numero = 0;
            verde = 1;
            controlarEntradas();
        }

        private void radioButton_playerVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugadorVerde_tipo = "player";
            jugadorVerde = true;
            numero = 0;
            verde = 1;
            controlarEntradas();
        }

        private void radioButton_noneVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugadorVerde_tipo = "none";
            jugadorVerde = true;
            numero = 0;
            verde = 0;
            controlarEntradas();
        }

        public void controlarEntradas()
        {
            numero = azul + amarillo + rojo + verde;
            if (jugadorRojo && jugadorAzul && jugadorVerde && jugadorAmarillo)
            {
                if (numero >= 2)
                {
                    buttonJugar.Enabled = true;
                }
                else
                {
                    buttonJugar.Enabled = false;
                }
            }
           
        }
    }
}