namespace App_Bancaria
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton_CC = new RadioButton();
            radioButton_CA = new RadioButton();
            button_CrearCuenta = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker_Creacion = new DateTimePicker();
            label9 = new Label();
            textBox_Nombre = new TextBox();
            textBox_Usuario = new TextBox();
            textBox_Apellido = new TextBox();
            textBox_Contraseña = new TextBox();
            textBox_Contraseña2 = new TextBox();
            textBox_Email = new TextBox();
            textBox_Telefono = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 163);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuario :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 211);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 1;
            label2.Text = "Contraseña :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 255);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 2;
            label3.Text = "Repita la contraseña :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 74);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 3;
            label4.Text = "Nombre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 115);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 4;
            label5.Text = "Apellido :";
            // 
            // radioButton_CC
            // 
            radioButton_CC.AutoSize = true;
            radioButton_CC.Location = new Point(36, 25);
            radioButton_CC.Name = "radioButton_CC";
            radioButton_CC.Size = new Size(115, 19);
            radioButton_CC.TabIndex = 5;
            radioButton_CC.TabStop = true;
            radioButton_CC.Text = "Cuenta Corriente";
            radioButton_CC.UseVisualStyleBackColor = true;
            // 
            // radioButton_CA
            // 
            radioButton_CA.AutoSize = true;
            radioButton_CA.Location = new Point(222, 25);
            radioButton_CA.Name = "radioButton_CA";
            radioButton_CA.Size = new Size(107, 19);
            radioButton_CA.TabIndex = 6;
            radioButton_CA.TabStop = true;
            radioButton_CA.Text = "Caja de Ahorro ";
            radioButton_CA.UseVisualStyleBackColor = true;
            // 
            // button_CrearCuenta
            // 
            button_CrearCuenta.BackColor = Color.MidnightBlue;
            button_CrearCuenta.FlatAppearance.BorderSize = 0;
            button_CrearCuenta.FlatStyle = FlatStyle.Flat;
            button_CrearCuenta.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_CrearCuenta.ForeColor = SystemColors.ActiveCaptionText;
            button_CrearCuenta.Location = new Point(132, 511);
            button_CrearCuenta.Name = "button_CrearCuenta";
            button_CrearCuenta.Size = new Size(161, 31);
            button_CrearCuenta.TabIndex = 7;
            button_CrearCuenta.Text = "CREAR CUENTA";
            button_CrearCuenta.UseVisualStyleBackColor = false;
            button_CrearCuenta.Click += button1_Click;
            button_CrearCuenta.MouseLeave += button_CrearCuenta_MouseLeave;
            button_CrearCuenta.MouseHover += button_CrearCuenta_MouseHover;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 304);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 8;
            label6.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 352);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 9;
            label7.Text = "Telefono :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(115, 27);
            label8.Name = "label8";
            label8.Size = new Size(186, 24);
            label8.TabIndex = 10;
            label8.Text = "Crear nueva cuenta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_CA);
            groupBox1.Controls.Add(radioButton_CC);
            groupBox1.Location = new Point(25, 438);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 61);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de cuenta";
            // 
            // dateTimePicker_Creacion
            // 
            dateTimePicker_Creacion.Location = new Point(180, 395);
            dateTimePicker_Creacion.Name = "dateTimePicker_Creacion";
            dateTimePicker_Creacion.Size = new Size(228, 23);
            dateTimePicker_Creacion.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 401);
            label9.Name = "label9";
            label9.Size = new Size(135, 17);
            label9.TabIndex = 13;
            label9.Text = "Fecha de creacion :";
            // 
            // textBox_Nombre
            // 
            textBox_Nombre.Location = new Point(180, 68);
            textBox_Nombre.Name = "textBox_Nombre";
            textBox_Nombre.Size = new Size(228, 23);
            textBox_Nombre.TabIndex = 14;
            // 
            // textBox_Usuario
            // 
            textBox_Usuario.Location = new Point(180, 157);
            textBox_Usuario.Name = "textBox_Usuario";
            textBox_Usuario.Size = new Size(228, 23);
            textBox_Usuario.TabIndex = 15;
            // 
            // textBox_Apellido
            // 
            textBox_Apellido.Location = new Point(180, 114);
            textBox_Apellido.Name = "textBox_Apellido";
            textBox_Apellido.Size = new Size(228, 23);
            textBox_Apellido.TabIndex = 16;
            // 
            // textBox_Contraseña
            // 
            textBox_Contraseña.Location = new Point(180, 205);
            textBox_Contraseña.Name = "textBox_Contraseña";
            textBox_Contraseña.Size = new Size(228, 23);
            textBox_Contraseña.TabIndex = 17;
            // 
            // textBox_Contraseña2
            // 
            textBox_Contraseña2.Location = new Point(180, 249);
            textBox_Contraseña2.Name = "textBox_Contraseña2";
            textBox_Contraseña2.Size = new Size(228, 23);
            textBox_Contraseña2.TabIndex = 18;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(180, 298);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(228, 23);
            textBox_Email.TabIndex = 19;
            // 
            // textBox_Telefono
            // 
            textBox_Telefono.Location = new Point(180, 346);
            textBox_Telefono.Name = "textBox_Telefono";
            textBox_Telefono.Size = new Size(228, 23);
            textBox_Telefono.TabIndex = 20;
            textBox_Telefono.KeyPress += textBox_Telefono_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 554);
            Controls.Add(textBox_Telefono);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Contraseña2);
            Controls.Add(textBox_Contraseña);
            Controls.Add(textBox_Apellido);
            Controls.Add(textBox_Usuario);
            Controls.Add(textBox_Nombre);
            Controls.Add(label9);
            Controls.Add(dateTimePicker_Creacion);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button_CrearCuenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Crear Cuenta";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton_CC;
        private RadioButton radioButton_CA;
        private Button button_CrearCuenta;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker_Creacion;
        private Label label9;
        private TextBox textBox_Nombre;
        private TextBox textBox_Usuario;
        private TextBox textBox_Apellido;
        private TextBox textBox_Contraseña;
        private TextBox textBox_Contraseña2;
        private TextBox textBox_Email;
        private TextBox textBox_Telefono;
    }
}