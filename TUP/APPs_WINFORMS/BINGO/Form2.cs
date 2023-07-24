using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form2 : Form
    {
        Jugador jugador1;
        Random random;
        int numeroGenerado;

        public Form2(Jugador jugador)
        {
            InitializeComponent();
            jugador1 = jugador;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelNCarton.Text = jugador1.NumeroCarton.ToString();
            labelNombre.Text = jugador1.Nombre;
            for (int i = 0; i < 75; i++)
            {
                jugador1.NumerosSorteados.Add(i + 1);
            }
            for (int i = 0; i < jugador1.Botones.Length; i++)
            {
                jugador1.Botones[i] = false;
            }
            for (int i = 0; i < 16; i++)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int numero = rnd.Next(1, 76);
                if (!jugador1.ListaNumeros.Contains(numero))
                {
                    jugador1.ListaNumeros.Add(numero);
                }
                else
                {
                    i--;
                }
            }
            jugador1.ListaNumeros.Sort();
            button1.Text = jugador1.ListaNumeros[0].ToString();
            button2.Text = jugador1.ListaNumeros[1].ToString();
            button3.Text = jugador1.ListaNumeros[2].ToString();
            button4.Text = jugador1.ListaNumeros[3].ToString();
            button5.Text = jugador1.ListaNumeros[4].ToString();
            button6.Text = jugador1.ListaNumeros[5].ToString();
            button7.Text = jugador1.ListaNumeros[6].ToString();
            button8.Text = jugador1.ListaNumeros[7].ToString();
            button9.Text = jugador1.ListaNumeros[8].ToString();
            button10.Text = jugador1.ListaNumeros[9].ToString();
            button11.Text = jugador1.ListaNumeros[10].ToString();
            button12.Text = jugador1.ListaNumeros[11].ToString();
            button13.Text = jugador1.ListaNumeros[12].ToString();
            button14.Text = jugador1.ListaNumeros[13].ToString();
            button15.Text = jugador1.ListaNumeros[14].ToString();
            button16.Text = jugador1.ListaNumeros[15].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == numeroGenerado.ToString() && !jugador1.Botones[0])
            {
                button1.BackColor = Color.Green;
                button1.Enabled = false;
                jugador1.Botones[0] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == numeroGenerado.ToString() && !jugador1.Botones[1])
            {
                button2.BackColor = Color.Green;
                button2.Enabled = false;
                jugador1.Botones[1] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == numeroGenerado.ToString() && !jugador1.Botones[2])
            {
                button3.BackColor = Color.Green;
                button3.Enabled = false;
                jugador1.Botones[2] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == numeroGenerado.ToString() && !jugador1.Botones[3])
            {
                button4.BackColor = Color.Green;
                button4.Enabled = false;
                jugador1.Botones[3] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == numeroGenerado.ToString() && !jugador1.Botones[4])
            {
                button5.BackColor = Color.Green;
                button5.Enabled = false;
                jugador1.Botones[4] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == numeroGenerado.ToString() && !jugador1.Botones[5])
            {
                button6.BackColor = Color.Green;
                button6.Enabled = false;
                jugador1.Botones[5] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == numeroGenerado.ToString() && !jugador1.Botones[6])
            {
                button7.BackColor = Color.Green;
                button7.Enabled = false;
                jugador1.Botones[6] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == numeroGenerado.ToString() && !jugador1.Botones[7])
            {
                button8.BackColor = Color.Green;
                button8.Enabled = false;
                jugador1.Botones[7] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == numeroGenerado.ToString() && !jugador1.Botones[8])
            {
                button9.BackColor = Color.Green;
                button9.Enabled = false;
                jugador1.Botones[8] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == numeroGenerado.ToString() && !jugador1.Botones[9])
            {
                button10.BackColor = Color.Green;
                button10.Enabled = false;
                jugador1.Botones[9] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == numeroGenerado.ToString() && !jugador1.Botones[10])
            {
                button11.BackColor = Color.Green;
                button11.Enabled = false;
                jugador1.Botones[10] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == numeroGenerado.ToString() && !jugador1.Botones[11])
            {
                button12.BackColor = Color.Green;
                button12.Enabled = false;
                jugador1.Botones[11] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == numeroGenerado.ToString() && !jugador1.Botones[12])
            {
                button13.BackColor = Color.Green;
                button13.Enabled = false;
                jugador1.Botones[12] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == numeroGenerado.ToString() && !jugador1.Botones[13])
            {
                button14.BackColor = Color.Green;
                button14.Enabled = false;
                jugador1.Botones[13] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == numeroGenerado.ToString() && !jugador1.Botones[14])
            {
                button15.BackColor = Color.Green;
                button15.Enabled = false;
                jugador1.Botones[14] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == numeroGenerado.ToString() && !jugador1.Botones[15])
            {
                button16.BackColor = Color.Green;
                button16.Enabled = false;
                jugador1.Botones[15] = true;
                jugador1.NumerosAcertados.Add(numeroGenerado);
                controlarColumna();
                controlarLinea();
                controlarDiagonal();
            }
        }
        public void controlarLinea()
        {
            if (jugador1.Botones[0] && jugador1.Botones[1] && jugador1.Botones[2] && jugador1.Botones[3])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[4] && jugador1.Botones[5] && jugador1.Botones[6] && jugador1.Botones[7])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[8] && jugador1.Botones[9] && jugador1.Botones[10] && jugador1.Botones[11])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[12] && jugador1.Botones[13] && jugador1.Botones[14] && jugador1.Botones[15])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
        }
        public void controlarColumna()
        {
            if (jugador1.Botones[0] && jugador1.Botones[4] && jugador1.Botones[8] && jugador1.Botones[12])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[1] && jugador1.Botones[5] && jugador1.Botones[9] && jugador1.Botones[13])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[2] && jugador1.Botones[6] && jugador1.Botones[10] && jugador1.Botones[14])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[3] && jugador1.Botones[7] && jugador1.Botones[11] && jugador1.Botones[15])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
        }
        public void controlarDiagonal()
        {
            if (jugador1.Botones[0] && jugador1.Botones[5] && jugador1.Botones[10] && jugador1.Botones[15])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
            else if (jugador1.Botones[3] && jugador1.Botones[6] && jugador1.Botones[9] && jugador1.Botones[12])
            {
                MessageBox.Show("YOU WIN!!! CONGRATULATIONS");
                button17.Enabled = false;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {

            if (jugador1.NumerosSorteados != null)
            {
                random = new Random(DateTime.Now.Millisecond);
                int numero = random.Next(0, jugador1.NumerosSorteados.Count);
                labelNGenerado.Text = jugador1.NumerosSorteados[numero].ToString();
                numeroGenerado = jugador1.NumerosSorteados[numero];
                jugador1.NumerosSorteados.RemoveAt(numero);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\lucia\\OneDrive\\Documentos\\LUCIANO\\TUP\\PORG_III\\WINFORMS\\Bingo\\Jugador\\partidas.txt";
            FileInfo file = new FileInfo(path);
            var options = new JsonSerializerOptions {WriteIndented = true};
            string serializacion = JsonSerializer.Serialize(jugador1, options);
            FileStream fs = file.Create();
            StreamWriter sw = new StreamWriter(fs); 
            sw.WriteLine(serializacion);
            sw.Close();
            fs.Close();
        }
    }
}
