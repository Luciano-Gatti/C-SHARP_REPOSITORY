namespace LUDO_V1._0
{
    public partial class Form1 : Form
    {
        string jugador_azul;
        string jugador_rojo;
        string jugador_amarillo;
        string jugador_verde;
        bool control_azul;
        bool control_rojo;
        bool control_amarillo;
        bool control_verde;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 juego = new Form2();
            juego.Show();
            this.Hide();
        }

        private void radioButton_cpuAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugador_azul = "cpu";
            control_azul = true;
        }

        private void radioButton_playerAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugador_azul = "player";
            control_azul = true;
        }

        private void radioButton_noneAzul_CheckedChanged(object sender, EventArgs e)
        {
            jugador_azul = "none";
            control_azul = true;
        }

        private void radioButton_cpuRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_rojo = "cpu";
            control_rojo = true;
        }

        private void radioButton_playerRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_rojo = "player";
            control_rojo = true;
        }

        private void radioButton_noneRojo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_rojo = "none";
            control_rojo = true;
        }

        private void radioButton_cpuAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_amarillo = "cpu";
            control_amarillo = true;
        }

        private void radioButton_playerAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_amarillo = "player";
            control_amarillo = true;
        }

        private void radioButton_noneAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            jugador_amarillo = "none";
            control_amarillo = true;
        }

        private void radioButton_cpuVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugador_verde = "cpu";
            control_verde = true;
        }

        private void radioButton_playerVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugador_verde = "player";
            control_verde = true;
        }

        private void radioButton_noneVerde_CheckedChanged(object sender, EventArgs e)
        {
            jugador_verde = "none"; 
            control_verde = true;
        }
    }
}