namespace LUDO_V2._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBoxDado_Azul = new TextBox();
            buttonDado_Azul = new Button();
            labelPuntaje_Azul = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label6 = new Label();
            textBoxDado_Amarillo = new TextBox();
            buttonDado_Amarillo = new Button();
            labelPuntaje_Amarillo = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBoxDado_Rojo = new TextBox();
            buttonDado_Rojo = new Button();
            labelPuntaje_Rojo = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            textBoxDado_Verde = new TextBox();
            buttonDado_Verde = new Button();
            labelPuntaje_Verde = new Label();
            label12 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label11 = new Label();
            labelTiempoAzul = new Label();
            labelTiempoAmarillo = new Label();
            labelTiempoRojo = new Label();
            labelTiempoVerde = new Label();
            timerAzul = new System.Windows.Forms.Timer(components);
            timerRojo = new System.Windows.Forms.Timer(components);
            timerAmarillo = new System.Windows.Forms.Timer(components);
            timerVerde = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxDado_Azul);
            groupBox1.Controls.Add(buttonDado_Azul);
            groupBox1.Controls.Add(labelPuntaje_Azul);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(165, 183);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "BLUE PLAYER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 100);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "DICE:";
            // 
            // textBoxDado_Azul
            // 
            textBoxDado_Azul.Location = new Point(70, 94);
            textBoxDado_Azul.Name = "textBoxDado_Azul";
            textBoxDado_Azul.Size = new Size(47, 26);
            textBoxDado_Azul.TabIndex = 6;
            // 
            // buttonDado_Azul
            // 
            buttonDado_Azul.Location = new Point(34, 147);
            buttonDado_Azul.Name = "buttonDado_Azul";
            buttonDado_Azul.Size = new Size(92, 30);
            buttonDado_Azul.TabIndex = 2;
            buttonDado_Azul.Text = "ROLL";
            buttonDado_Azul.UseVisualStyleBackColor = true;
            buttonDado_Azul.Click += buttonDado_Azul_Click;
            // 
            // labelPuntaje_Azul
            // 
            labelPuntaje_Azul.AutoSize = true;
            labelPuntaje_Azul.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Azul.Location = new Point(101, 39);
            labelPuntaje_Azul.Name = "labelPuntaje_Azul";
            labelPuntaje_Azul.Size = new Size(19, 20);
            labelPuntaje_Azul.TabIndex = 1;
            labelPuntaje_Azul.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "SCORE: ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(textBoxDado_Amarillo);
            groupBox5.Controls.Add(buttonDado_Amarillo);
            groupBox5.Controls.Add(labelPuntaje_Amarillo);
            groupBox5.Controls.Add(label8);
            groupBox5.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(2, 431);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(165, 183);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "YELLOW PLAYER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 100);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 7;
            label6.Text = "DICE:";
            // 
            // textBoxDado_Amarillo
            // 
            textBoxDado_Amarillo.Location = new Point(70, 97);
            textBoxDado_Amarillo.Name = "textBoxDado_Amarillo";
            textBoxDado_Amarillo.Size = new Size(47, 26);
            textBoxDado_Amarillo.TabIndex = 6;
            // 
            // buttonDado_Amarillo
            // 
            buttonDado_Amarillo.Location = new Point(34, 147);
            buttonDado_Amarillo.Name = "buttonDado_Amarillo";
            buttonDado_Amarillo.Size = new Size(92, 30);
            buttonDado_Amarillo.TabIndex = 2;
            buttonDado_Amarillo.Text = "ROLL";
            buttonDado_Amarillo.UseVisualStyleBackColor = true;
            buttonDado_Amarillo.Click += buttonDado_Amarillo_Click;
            // 
            // labelPuntaje_Amarillo
            // 
            labelPuntaje_Amarillo.AutoSize = true;
            labelPuntaje_Amarillo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Amarillo.Location = new Point(101, 39);
            labelPuntaje_Amarillo.Name = "labelPuntaje_Amarillo";
            labelPuntaje_Amarillo.Size = new Size(19, 20);
            labelPuntaje_Amarillo.TabIndex = 1;
            labelPuntaje_Amarillo.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 39);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 0;
            label8.Text = "SCORE: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxDado_Rojo);
            groupBox2.Controls.Add(buttonDado_Rojo);
            groupBox2.Controls.Add(labelPuntaje_Rojo);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(816, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(165, 183);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "RED PLAYER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 100);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "DICE:";
            // 
            // textBoxDado_Rojo
            // 
            textBoxDado_Rojo.Location = new Point(70, 94);
            textBoxDado_Rojo.Name = "textBoxDado_Rojo";
            textBoxDado_Rojo.Size = new Size(47, 26);
            textBoxDado_Rojo.TabIndex = 6;
            // 
            // buttonDado_Rojo
            // 
            buttonDado_Rojo.Location = new Point(34, 147);
            buttonDado_Rojo.Name = "buttonDado_Rojo";
            buttonDado_Rojo.Size = new Size(92, 30);
            buttonDado_Rojo.TabIndex = 2;
            buttonDado_Rojo.Text = "ROLL";
            buttonDado_Rojo.UseVisualStyleBackColor = true;
            buttonDado_Rojo.Click += buttonDado_Rojo_Click;
            // 
            // labelPuntaje_Rojo
            // 
            labelPuntaje_Rojo.AutoSize = true;
            labelPuntaje_Rojo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Rojo.Location = new Point(101, 39);
            labelPuntaje_Rojo.Name = "labelPuntaje_Rojo";
            labelPuntaje_Rojo.Size = new Size(19, 20);
            labelPuntaje_Rojo.TabIndex = 1;
            labelPuntaje_Rojo.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(8, 39);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 0;
            label9.Text = "SCORE: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBoxDado_Verde);
            groupBox3.Controls.Add(buttonDado_Verde);
            groupBox3.Controls.Add(labelPuntaje_Verde);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(816, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(165, 183);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "GREEN PLAYER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 100);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 7;
            label10.Text = "DICE:";
            // 
            // textBoxDado_Verde
            // 
            textBoxDado_Verde.Location = new Point(70, 94);
            textBoxDado_Verde.Name = "textBoxDado_Verde";
            textBoxDado_Verde.Size = new Size(47, 26);
            textBoxDado_Verde.TabIndex = 6;
            // 
            // buttonDado_Verde
            // 
            buttonDado_Verde.Location = new Point(34, 147);
            buttonDado_Verde.Name = "buttonDado_Verde";
            buttonDado_Verde.Size = new Size(92, 30);
            buttonDado_Verde.TabIndex = 2;
            buttonDado_Verde.Text = "ROLL";
            buttonDado_Verde.UseVisualStyleBackColor = true;
            buttonDado_Verde.Click += buttonDado_Verde_Click;
            // 
            // labelPuntaje_Verde
            // 
            labelPuntaje_Verde.AutoSize = true;
            labelPuntaje_Verde.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Verde.Location = new Point(101, 39);
            labelPuntaje_Verde.Name = "labelPuntaje_Verde";
            labelPuntaje_Verde.Size = new Size(19, 20);
            labelPuntaje_Verde.TabIndex = 1;
            labelPuntaje_Verde.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(8, 39);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 0;
            label12.Text = "SCORE: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 12;
            label2.Text = "TIEMPO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(2, 398);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 13;
            label4.Text = "TIEMPO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(828, 9);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 14;
            label7.Text = "TIEMPO:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(828, 398);
            label11.Name = "label11";
            label11.Size = new Size(84, 20);
            label11.TabIndex = 15;
            label11.Text = "TIEMPO:";
            // 
            // labelTiempoAzul
            // 
            labelTiempoAzul.AutoSize = true;
            labelTiempoAzul.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoAzul.Location = new Point(92, 9);
            labelTiempoAzul.Name = "labelTiempoAzul";
            labelTiempoAzul.Size = new Size(28, 20);
            labelTiempoAzul.TabIndex = 16;
            labelTiempoAzul.Text = "30";
            // 
            // labelTiempoAmarillo
            // 
            labelTiempoAmarillo.AutoSize = true;
            labelTiempoAmarillo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoAmarillo.Location = new Point(92, 398);
            labelTiempoAmarillo.Name = "labelTiempoAmarillo";
            labelTiempoAmarillo.Size = new Size(28, 20);
            labelTiempoAmarillo.TabIndex = 17;
            labelTiempoAmarillo.Text = "30";
            // 
            // labelTiempoRojo
            // 
            labelTiempoRojo.AutoSize = true;
            labelTiempoRojo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoRojo.Location = new Point(918, 9);
            labelTiempoRojo.Name = "labelTiempoRojo";
            labelTiempoRojo.Size = new Size(28, 20);
            labelTiempoRojo.TabIndex = 18;
            labelTiempoRojo.Text = "30";
            // 
            // labelTiempoVerde
            // 
            labelTiempoVerde.AutoSize = true;
            labelTiempoVerde.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempoVerde.Location = new Point(918, 398);
            labelTiempoVerde.Name = "labelTiempoVerde";
            labelTiempoVerde.Size = new Size(28, 20);
            labelTiempoVerde.TabIndex = 19;
            labelTiempoVerde.Text = "30";
            // 
            // timerAzul
            // 
            timerAzul.Interval = 1000;
            timerAzul.Tick += timerAzul_Tick;
            // 
            // timerRojo
            // 
            timerRojo.Interval = 1000;
            timerRojo.Tick += timerRojo_Tick;
            // 
            // timerAmarillo
            // 
            timerAmarillo.Interval = 1000;
            timerAmarillo.Tick += timerAmarillo_Tick;
            // 
            // timerVerde
            // 
            timerVerde.Interval = 1000;
            timerVerde.Tick += timerVerde_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tablero2;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(984, 661);
            Controls.Add(labelTiempoVerde);
            Controls.Add(labelTiempoRojo);
            Controls.Add(labelTiempoAmarillo);
            Controls.Add(labelTiempoAzul);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBoxDado_Azul;
        private Button buttonDado_Azul;
        private Label labelPuntaje_Azul;
        private Label label1;
        private GroupBox groupBox5;
        private Label label6;
        private TextBox textBoxDado_Amarillo;
        private Button buttonDado_Amarillo;
        private Label labelPuntaje_Amarillo;
        private Label label8;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBoxDado_Rojo;
        private Button buttonDado_Rojo;
        private Label labelPuntaje_Rojo;
        private Label label9;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox textBoxDado_Verde;
        private Button buttonDado_Verde;
        private Label labelPuntaje_Verde;
        private Label label12;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label11;
        private Label labelTiempoAzul;
        private Label labelTiempoAmarillo;
        private Label labelTiempoRojo;
        private Label labelTiempoVerde;
        private System.Windows.Forms.Timer timerAzul;
        private System.Windows.Forms.Timer timerRojo;
        private System.Windows.Forms.Timer timerAmarillo;
        private System.Windows.Forms.Timer timerVerde;
    }
}