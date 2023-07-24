using System.Diagnostics;

namespace Archivo
{
    public partial class Form1 : Form
    {
        string archivo;
        DirectoryInfo dr_info;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            archivo = folderBrowserDialog1.SelectedPath.ToString();
            dr_info = new DirectoryInfo(@archivo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo[] imageFile = dr_info.GetFiles("*.jpg", SearchOption.AllDirectories);
            foreach (FileInfo file in imageFile)
            {
                listBox1.Items.Add("*****************");
                listBox1.Items.Add(file.Name);
                listBox1.Items.Add(file.Length);
                listBox1.Items.Add(file.CreationTime);
                listBox1.Items.Add(file.Attributes);
                listBox1.Items.Add("*****************");
            }
        }
    }
}