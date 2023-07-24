namespace LUDO_V3._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTablero = new Panel();
            groupBox1 = new GroupBox();
            labelPuntaje_Amarillo = new Label();
            labelPuntaje_Azul = new Label();
            labelPuntaje_Rojo = new Label();
            label4 = new Label();
            label3 = new Label();
            labelPuntaje_Verde = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonDado = new Button();
            label5 = new Label();
            labelDado = new Label();
            label7 = new Label();
            labelTiempo = new Label();
            groupBoxTurnos = new GroupBox();
            label_InformarAccion = new Label();
            buttonSalir = new Button();
            buttonNuevoJuego = new Button();
            groupBox1.SuspendLayout();
            groupBoxTurnos.SuspendLayout();
            SuspendLayout();
            // 
            // panelTablero
            // 
            panelTablero.BackgroundImage = Properties.Resources.tablero2;
            panelTablero.BackgroundImageLayout = ImageLayout.Stretch;
            panelTablero.Location = new Point(2, 1);
            panelTablero.Name = "panelTablero";
            panelTablero.Size = new Size(635, 659);
            panelTablero.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPuntaje_Amarillo);
            groupBox1.Controls.Add(labelPuntaje_Azul);
            groupBox1.Controls.Add(labelPuntaje_Rojo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelPuntaje_Verde);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(640, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 254);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PUNTUACION JUGADORES";
            // 
            // labelPuntaje_Amarillo
            // 
            labelPuntaje_Amarillo.AutoSize = true;
            labelPuntaje_Amarillo.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Amarillo.Location = new Point(205, 196);
            labelPuntaje_Amarillo.Name = "labelPuntaje_Amarillo";
            labelPuntaje_Amarillo.Size = new Size(16, 16);
            labelPuntaje_Amarillo.TabIndex = 8;
            labelPuntaje_Amarillo.Text = "0";
            // 
            // labelPuntaje_Azul
            // 
            labelPuntaje_Azul.AutoSize = true;
            labelPuntaje_Azul.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Azul.Location = new Point(205, 46);
            labelPuntaje_Azul.Name = "labelPuntaje_Azul";
            labelPuntaje_Azul.Size = new Size(16, 16);
            labelPuntaje_Azul.TabIndex = 7;
            labelPuntaje_Azul.Text = "0";
            // 
            // labelPuntaje_Rojo
            // 
            labelPuntaje_Rojo.AutoSize = true;
            labelPuntaje_Rojo.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Rojo.Location = new Point(205, 94);
            labelPuntaje_Rojo.Name = "labelPuntaje_Rojo";
            labelPuntaje_Rojo.Size = new Size(16, 16);
            labelPuntaje_Rojo.TabIndex = 6;
            labelPuntaje_Rojo.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 199);
            label4.Name = "label4";
            label4.Size = new Size(157, 16);
            label4.TabIndex = 3;
            label4.Text = "JUGADOR AMARILLO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 146);
            label3.Name = "label3";
            label3.Size = new Size(134, 16);
            label3.TabIndex = 2;
            label3.Text = "JUGADOR VERDE: ";
            // 
            // labelPuntaje_Verde
            // 
            labelPuntaje_Verde.AutoSize = true;
            labelPuntaje_Verde.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPuntaje_Verde.Location = new Point(205, 143);
            labelPuntaje_Verde.Name = "labelPuntaje_Verde";
            labelPuntaje_Verde.Size = new Size(16, 16);
            labelPuntaje_Verde.TabIndex = 5;
            labelPuntaje_Verde.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(121, 16);
            label2.TabIndex = 1;
            label2.Text = "JUGADOR ROJO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 0;
            label1.Text = "JUGADOR AZUL:";
            // 
            // buttonDado
            // 
            buttonDado.BackColor = Color.Transparent;
            buttonDado.FlatStyle = FlatStyle.Popup;
            buttonDado.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDado.Location = new Point(6, 144);
            buttonDado.Name = "buttonDado";
            buttonDado.Size = new Size(221, 73);
            buttonDado.TabIndex = 2;
            buttonDado.Text = "TIRAR DADO";
            buttonDado.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 92);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 3;
            label5.Text = "DADO:";
            // 
            // labelDado
            // 
            labelDado.AutoSize = true;
            labelDado.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDado.Location = new Point(125, 92);
            labelDado.Name = "labelDado";
            labelDado.Size = new Size(21, 20);
            labelDado.TabIndex = 4;
            labelDado.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 44);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 5;
            label7.Text = "TIEMPO:";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempo.Location = new Point(125, 44);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(33, 20);
            labelTiempo.TabIndex = 6;
            labelTiempo.Text = "30";
            // 
            // groupBoxTurnos
            // 
            groupBoxTurnos.Controls.Add(label7);
            groupBoxTurnos.Controls.Add(buttonDado);
            groupBoxTurnos.Controls.Add(labelDado);
            groupBoxTurnos.Controls.Add(labelTiempo);
            groupBoxTurnos.Controls.Add(label5);
            groupBoxTurnos.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxTurnos.Location = new Point(640, 397);
            groupBoxTurnos.Name = "groupBoxTurnos";
            groupBoxTurnos.Size = new Size(234, 223);
            groupBoxTurnos.TabIndex = 7;
            groupBoxTurnos.TabStop = false;
            groupBoxTurnos.Text = "TURNO DEL JUGADOR AZUL";
            // 
            // label_InformarAccion
            // 
            label_InformarAccion.AutoSize = true;
            label_InformarAccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_InformarAccion.Location = new Point(646, 326);
            label_InformarAccion.Name = "label_InformarAccion";
            label_InformarAccion.Size = new Size(225, 15);
            label_InformarAccion.TabIndex = 8;
            label_InformarAccion.Text = "EL JUGADOR AMARILLO ESTA TIRANDO...";
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Location = new Point(643, 626);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(101, 29);
            buttonSalir.TabIndex = 9;
            buttonSalir.Text = "SALIR";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonNuevoJuego
            // 
            buttonNuevoJuego.FlatStyle = FlatStyle.Popup;
            buttonNuevoJuego.Location = new Point(773, 626);
            buttonNuevoJuego.Name = "buttonNuevoJuego";
            buttonNuevoJuego.Size = new Size(101, 29);
            buttonNuevoJuego.TabIndex = 10;
            buttonNuevoJuego.Text = "NUEVO JUEGO";
            buttonNuevoJuego.UseVisualStyleBackColor = true;
            buttonNuevoJuego.Click += buttonNuevoJuego_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 661);
            Controls.Add(buttonNuevoJuego);
            Controls.Add(buttonSalir);
            Controls.Add(label_InformarAccion);
            Controls.Add(groupBoxTurnos);
            Controls.Add(groupBox1);
            Controls.Add(panelTablero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxTurnos.ResumeLayout(false);
            groupBoxTurnos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTablero;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonDado;
        private Label label5;
        private Label labelDado;
        private Label label7;
        private Label labelTiempo;
        private GroupBox groupBoxTurnos;
        private Label label_InformarAccion;
        private Button buttonSalir;
        private Button buttonNuevoJuego;
        private Label labelPuntaje_Amarillo;
        private Label labelPuntaje_Azul;
        private Label labelPuntaje_Rojo;
        private Label labelPuntaje_Verde;
    }
}