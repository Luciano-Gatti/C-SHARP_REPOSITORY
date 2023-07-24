namespace Archivo2
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(52, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(448, 349);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 406);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 4;
            button1.Text = "Buscar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(198, 423);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 5;
            button2.Text = "Opción 1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.CommonDocuments;
            folderBrowserDialog1.Tag = "*.txt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 18);
            label1.TabIndex = 6;
            label1.Text = "Seleccione un archivo de texto ";
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(327, 423);
            button4.Name = "button4";
            button4.Size = new Size(85, 23);
            button4.TabIndex = 7;
            button4.Text = "Opción 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(445, 423);
            button5.Name = "button5";
            button5.Size = new Size(85, 23);
            button5.TabIndex = 8;
            button5.Text = "Opción 3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 406);
            label2.Name = "label2";
            label2.Size = new Size(223, 14);
            label2.TabIndex = 9;
            label2.Text = "CONTAR LA CANTIDAD DE LINEAS: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}