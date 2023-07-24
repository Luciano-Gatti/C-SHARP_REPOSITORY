using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net.Security;
using System.Reflection;
using System.Security.AccessControl;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Archivo2
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                int lineas = File.ReadAllLines(filePath).Length;
                listBox1.Items.Add("*****************");
                listBox1.Items.Add("Path: " + filePath);
                listBox1.Items.Add("\nCantidad de lineas: " + lineas);
                listBox1.Items.Add("*****************");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                int lineas2 = File.ReadLines(filePath).Count();
                listBox1.Items.Add("*****************");
                listBox1.Items.Add("Path: " + filePath);
                listBox1.Items.Add("\nCantidad de lineas: " + lineas2);
                listBox1.Items.Add("*****************");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                string lin;
                int cont = 0;
                FileStream fs2 = File.OpenRead(filePath);
                using (StreamReader sr = new StreamReader(fs2))
                {
                    while ((lin = sr.ReadLine()) != null)
                    {
                        cont++;
                    }
                }
                listBox1.Items.Add("*****************");
                listBox1.Items.Add("Path: " + filePath);
                listBox1.Items.Add("\nCantidad de lineas: " + cont);
                listBox1.Items.Add("*****************");
            }
        }
    }
}