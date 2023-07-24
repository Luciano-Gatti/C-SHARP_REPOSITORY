namespace SIMON_V1._0
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer sound1 = new System.Media.SoundPlayer("C:\\Users\\lucia\\OneDrive\\Documentos\\LUCIANO\\TUP\\PORG_III\\WINFORMS\\SIMON_V1.0\\Resource\\sonido1.wav");
        System.Media.SoundPlayer sound2 = new System.Media.SoundPlayer("C:\\Users\\lucia\\OneDrive\\Documentos\\LUCIANO\\TUP\\PORG_III\\WINFORMS\\SIMON_V1.0\\Resource\\sonido2.wav");
        System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer("C:\\Users\\lucia\\OneDrive\\Documentos\\LUCIANO\\TUP\\PORG_III\\WINFORMS\\SIMON_V1.0\\Resource\\sonido3.wav");
        System.Media.SoundPlayer sound4 = new System.Media.SoundPlayer("C:\\Users\\lucia\\OneDrive\\Documentos\\LUCIANO\\TUP\\PORG_III\\WINFORMS\\SIMON_V1.0\\Resource\\sonido4.wav");
        List<int> indexButtons = new List<int>();
        List<int> rdmsButtons = new List<int>();
        bool control;
        int buttonSelected;
        Random random = new Random(DateTime.Now.Millisecond);
        int numeroButton_Rndm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button2.BackColor = Color.FromArgb(64, 0, 0);
            button3.BackColor = Color.FromArgb(64, 64, 0);
            button4.BackColor = Color.FromArgb(0, 0, 64);
            BackColor = Color.FromArgb(0, 0, 0);
            timerButtons.Interval = 200;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            sound1.Play();
            indexButtons.Add(1);
            button1.BackColor = Color.FromArgb(192, 255, 192);
            timerButtons.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            sound2.Play();
            indexButtons.Add(2);
            button2.BackColor = Color.FromArgb(255, 192, 192);
            timerButtons.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            sound3.Play();
            indexButtons.Add(3);
            button3.BackColor = Color.FromArgb(255, 255, 192);
            timerButtons.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            sound4.Play();
            indexButtons.Add(4);
            button4.BackColor = Color.FromArgb(192, 192, 255);
            timerButtons.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            indexButtons.Clear();
            rdmsButtons.Clear();
            control = true;
            jugar(control);
        }

        private void jugar(bool control)
        {
            if (control)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                numeroButton_Rndm = random.Next(1, 5);
                rdmsButtons.Add(numeroButton_Rndm);
                foreach (var i in rdmsButtons)
                {
                    timerMostrar.Start();
                    if (i == 1)
                    {
                        sound1.Play();
                        button1.BackColor = Color.FromArgb(192, 255, 192);
                    }
                    else if (i == 2)
                    {
                        sound2.Play();
                        button2.BackColor = Color.FromArgb(255, 192, 192);
                    }
                    else if (i == 3)
                    {
                        sound3.Play();
                        button3.BackColor = Color.FromArgb(255, 255, 192);
                    }
                    else if (i == 4)
                    {
                        sound4.Play();
                        button4.BackColor = Color.FromArgb(192, 192, 255);
                    }
                    else
                    {
                        MessageBox.Show("ERROR. Try to uninstall the game and over install it.");
                    }
                }
                //for (int i = 0; i < rdmsButtons.Count; i++)
                //{
                //    if (rdmsButtons[i] == 1)
                //    {
                //        sound1.Play();
                //        button1.BackColor = Color.FromArgb(192, 255, 192);
                //        buttonSelected = 1;
                //    }
                //    else if (rdmsButtons[i] == 2)
                //    {
                //        sound2.Play();
                //        button2.BackColor = Color.FromArgb(255, 192, 192);
                //        buttonSelected = 2;
                //    }
                //    else if (rdmsButtons[i] == 3)
                //    {
                //        sound3.Play();
                //        button3.BackColor = Color.FromArgb(255, 255, 192);
                //        buttonSelected = 3;
                //    }
                //    else if (rdmsButtons[i] == 4)
                //    {
                //        sound4.Play();
                //        button4.BackColor = Color.FromArgb(192, 192, 255);
                //        buttonSelected = 4;
                //    }
                //    else
                //    {
                //        MessageBox.Show("ERROR. Try to uninstall the game and over install it.");
                //    }
                //    timerMostrar.Start();
                //}
                jugador();
            }
        }

        private async void jugador()
        {
            indexButtons.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            while (indexButtons.Count < rdmsButtons.Count)
            {
                await Task.Delay(1000);
            }
            for (int i = 0; i < rdmsButtons.Count; i++)
            {
                if (rdmsButtons[i] == indexButtons[i])
                {
                    control = true;
                }
                else
                {
                    control = false;
                    MessageBox.Show("YOU ARE A LOSER.");
                    button5.Enabled = true;
                    break;
                }
            }
            jugar(control);
        }

        private void timerButtons_Tick(object sender, EventArgs e)
        {
            timerButtons.Stop();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.BackColor = Color.FromArgb(0, 64, 0);               
            button2.BackColor = Color.FromArgb(64, 0, 0);   
            button3.BackColor = Color.FromArgb(64, 64, 0);         
            button4.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void timerMostrar_Tick(object sender, EventArgs e)
        {
            timerMostrar.Stop();           
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button2.BackColor = Color.FromArgb(64, 0, 0);          
            button3.BackColor = Color.FromArgb(64, 64, 0);
            button4.BackColor = Color.FromArgb(0, 0, 64);        
        }
    }
}