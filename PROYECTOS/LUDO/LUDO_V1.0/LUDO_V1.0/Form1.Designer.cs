﻿namespace LUDO_V1._0
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEmpezar = new Button();
            groupBox_Azul = new GroupBox();
            groupBox_Rojo = new GroupBox();
            groupBox_Amarillo = new GroupBox();
            groupBox_Verde = new GroupBox();
            pictureBox_Azul = new PictureBox();
            pictureBox_Rojo = new PictureBox();
            pictureBox_Amarillo = new PictureBox();
            pictureBox_Verde = new PictureBox();
            radioButton_cpuAzul = new RadioButton();
            radioButton_noneAzul = new RadioButton();
            radioButton_playerAzul = new RadioButton();
            radioButton_playerRojo = new RadioButton();
            radioButton_noneRojo = new RadioButton();
            radioButton_cpuRojo = new RadioButton();
            radioButton_playerAmarillo = new RadioButton();
            radioButton_noneAmarillo = new RadioButton();
            radioButton_cpuAmarillo = new RadioButton();
            radioButton_playerVerde = new RadioButton();
            radioButton_noneVerde = new RadioButton();
            radioButton_cpuVerde = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            groupBox_Azul.SuspendLayout();
            groupBox_Rojo.SuspendLayout();
            groupBox_Amarillo.SuspendLayout();
            groupBox_Verde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Azul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Rojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Amarillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Verde).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox_Verde, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox_Amarillo, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox_Rojo, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox_Azul, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(686, 486);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonEmpezar
            // 
            buttonEmpezar.Location = new Point(288, 493);
            buttonEmpezar.Name = "buttonEmpezar";
            buttonEmpezar.Size = new Size(113, 35);
            buttonEmpezar.TabIndex = 1;
            buttonEmpezar.Text = "START GAME";
            buttonEmpezar.UseVisualStyleBackColor = true;
            buttonEmpezar.Click += button1_Click_1;
            // 
            // groupBox_Azul
            // 
            groupBox_Azul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Azul.Controls.Add(radioButton_playerAzul);
            groupBox_Azul.Controls.Add(radioButton_noneAzul);
            groupBox_Azul.Controls.Add(radioButton_cpuAzul);
            groupBox_Azul.Controls.Add(pictureBox_Azul);
            groupBox_Azul.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Azul.Location = new Point(3, 3);
            groupBox_Azul.Name = "groupBox_Azul";
            groupBox_Azul.RightToLeft = RightToLeft.No;
            groupBox_Azul.Size = new Size(337, 237);
            groupBox_Azul.TabIndex = 0;
            groupBox_Azul.TabStop = false;
            groupBox_Azul.Text = "BLUE PLAYER";
            // 
            // groupBox_Rojo
            // 
            groupBox_Rojo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Rojo.Controls.Add(radioButton_playerRojo);
            groupBox_Rojo.Controls.Add(radioButton_noneRojo);
            groupBox_Rojo.Controls.Add(pictureBox_Rojo);
            groupBox_Rojo.Controls.Add(radioButton_cpuRojo);
            groupBox_Rojo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Rojo.Location = new Point(346, 3);
            groupBox_Rojo.Name = "groupBox_Rojo";
            groupBox_Rojo.RightToLeft = RightToLeft.No;
            groupBox_Rojo.Size = new Size(337, 237);
            groupBox_Rojo.TabIndex = 1;
            groupBox_Rojo.TabStop = false;
            groupBox_Rojo.Text = "RED PLAYER";
            // 
            // groupBox_Amarillo
            // 
            groupBox_Amarillo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Amarillo.Controls.Add(radioButton_playerAmarillo);
            groupBox_Amarillo.Controls.Add(radioButton_noneAmarillo);
            groupBox_Amarillo.Controls.Add(pictureBox_Amarillo);
            groupBox_Amarillo.Controls.Add(radioButton_cpuAmarillo);
            groupBox_Amarillo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Amarillo.Location = new Point(3, 246);
            groupBox_Amarillo.Name = "groupBox_Amarillo";
            groupBox_Amarillo.RightToLeft = RightToLeft.No;
            groupBox_Amarillo.Size = new Size(337, 237);
            groupBox_Amarillo.TabIndex = 1;
            groupBox_Amarillo.TabStop = false;
            groupBox_Amarillo.Text = "YELLOW PLAYER";
            // 
            // groupBox_Verde
            // 
            groupBox_Verde.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Verde.Controls.Add(radioButton_playerVerde);
            groupBox_Verde.Controls.Add(radioButton_noneVerde);
            groupBox_Verde.Controls.Add(pictureBox_Verde);
            groupBox_Verde.Controls.Add(radioButton_cpuVerde);
            groupBox_Verde.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox_Verde.Location = new Point(346, 246);
            groupBox_Verde.Name = "groupBox_Verde";
            groupBox_Verde.RightToLeft = RightToLeft.No;
            groupBox_Verde.Size = new Size(337, 237);
            groupBox_Verde.TabIndex = 1;
            groupBox_Verde.TabStop = false;
            groupBox_Verde.Text = "GREEN PLAYER";
            // 
            // pictureBox_Azul
            // 
            pictureBox_Azul.Image = Properties.Resources.blue_g5;
            pictureBox_Azul.Location = new Point(103, 38);
            pictureBox_Azul.Name = "pictureBox_Azul";
            pictureBox_Azul.Size = new Size(115, 104);
            pictureBox_Azul.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Azul.TabIndex = 0;
            pictureBox_Azul.TabStop = false;
            // 
            // pictureBox_Rojo
            // 
            pictureBox_Rojo.Image = Properties.Resources.red_g5;
            pictureBox_Rojo.Location = new Point(110, 38);
            pictureBox_Rojo.Name = "pictureBox_Rojo";
            pictureBox_Rojo.Size = new Size(115, 104);
            pictureBox_Rojo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Rojo.TabIndex = 1;
            pictureBox_Rojo.TabStop = false;
            // 
            // pictureBox_Amarillo
            // 
            pictureBox_Amarillo.Image = Properties.Resources.yellow_g5;
            pictureBox_Amarillo.Location = new Point(103, 41);
            pictureBox_Amarillo.Name = "pictureBox_Amarillo";
            pictureBox_Amarillo.Size = new Size(115, 104);
            pictureBox_Amarillo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Amarillo.TabIndex = 2;
            pictureBox_Amarillo.TabStop = false;
            // 
            // pictureBox_Verde
            // 
            pictureBox_Verde.Image = Properties.Resources.green_g5;
            pictureBox_Verde.Location = new Point(110, 41);
            pictureBox_Verde.Name = "pictureBox_Verde";
            pictureBox_Verde.Size = new Size(115, 104);
            pictureBox_Verde.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Verde.TabIndex = 3;
            pictureBox_Verde.TabStop = false;
            // 
            // radioButton_cpuAzul
            // 
            radioButton_cpuAzul.AutoSize = true;
            radioButton_cpuAzul.Location = new Point(8, 194);
            radioButton_cpuAzul.Name = "radioButton_cpuAzul";
            radioButton_cpuAzul.Size = new Size(62, 24);
            radioButton_cpuAzul.TabIndex = 1;
            radioButton_cpuAzul.TabStop = true;
            radioButton_cpuAzul.Text = "CPU";
            radioButton_cpuAzul.UseVisualStyleBackColor = true;
            radioButton_cpuAzul.CheckedChanged += radioButton_cpuAzul_CheckedChanged;
            // 
            // radioButton_noneAzul
            // 
            radioButton_noneAzul.AutoSize = true;
            radioButton_noneAzul.Location = new Point(245, 194);
            radioButton_noneAzul.Name = "radioButton_noneAzul";
            radioButton_noneAzul.Size = new Size(74, 24);
            radioButton_noneAzul.TabIndex = 2;
            radioButton_noneAzul.TabStop = true;
            radioButton_noneAzul.Text = "NONE";
            radioButton_noneAzul.UseVisualStyleBackColor = true;
            radioButton_noneAzul.CheckedChanged += radioButton_noneAzul_CheckedChanged;
            // 
            // radioButton_playerAzul
            // 
            radioButton_playerAzul.AutoSize = true;
            radioButton_playerAzul.Location = new Point(114, 194);
            radioButton_playerAzul.Name = "radioButton_playerAzul";
            radioButton_playerAzul.Size = new Size(94, 24);
            radioButton_playerAzul.TabIndex = 3;
            radioButton_playerAzul.TabStop = true;
            radioButton_playerAzul.Text = "PLAYER";
            radioButton_playerAzul.UseVisualStyleBackColor = true;
            radioButton_playerAzul.CheckedChanged += radioButton_playerAzul_CheckedChanged;
            // 
            // radioButton_playerRojo
            // 
            radioButton_playerRojo.AutoSize = true;
            radioButton_playerRojo.Location = new Point(120, 194);
            radioButton_playerRojo.Name = "radioButton_playerRojo";
            radioButton_playerRojo.Size = new Size(94, 24);
            radioButton_playerRojo.TabIndex = 6;
            radioButton_playerRojo.TabStop = true;
            radioButton_playerRojo.Text = "PLAYER";
            radioButton_playerRojo.UseVisualStyleBackColor = true;
            radioButton_playerRojo.CheckedChanged += radioButton_playerRojo_CheckedChanged;
            // 
            // radioButton_noneRojo
            // 
            radioButton_noneRojo.AutoSize = true;
            radioButton_noneRojo.Location = new Point(251, 194);
            radioButton_noneRojo.Name = "radioButton_noneRojo";
            radioButton_noneRojo.Size = new Size(74, 24);
            radioButton_noneRojo.TabIndex = 5;
            radioButton_noneRojo.TabStop = true;
            radioButton_noneRojo.Text = "NONE";
            radioButton_noneRojo.UseVisualStyleBackColor = true;
            radioButton_noneRojo.CheckedChanged += radioButton_noneRojo_CheckedChanged;
            // 
            // radioButton_cpuRojo
            // 
            radioButton_cpuRojo.AutoSize = true;
            radioButton_cpuRojo.Location = new Point(14, 194);
            radioButton_cpuRojo.Name = "radioButton_cpuRojo";
            radioButton_cpuRojo.Size = new Size(62, 24);
            radioButton_cpuRojo.TabIndex = 4;
            radioButton_cpuRojo.TabStop = true;
            radioButton_cpuRojo.Text = "CPU";
            radioButton_cpuRojo.UseVisualStyleBackColor = true;
            radioButton_cpuRojo.CheckedChanged += radioButton_cpuRojo_CheckedChanged;
            // 
            // radioButton_playerAmarillo
            // 
            radioButton_playerAmarillo.AutoSize = true;
            radioButton_playerAmarillo.Location = new Point(114, 195);
            radioButton_playerAmarillo.Name = "radioButton_playerAmarillo";
            radioButton_playerAmarillo.Size = new Size(94, 24);
            radioButton_playerAmarillo.TabIndex = 9;
            radioButton_playerAmarillo.TabStop = true;
            radioButton_playerAmarillo.Text = "PLAYER";
            radioButton_playerAmarillo.UseVisualStyleBackColor = true;
            radioButton_playerAmarillo.CheckedChanged += radioButton_playerAmarillo_CheckedChanged;
            // 
            // radioButton_noneAmarillo
            // 
            radioButton_noneAmarillo.AutoSize = true;
            radioButton_noneAmarillo.Location = new Point(245, 195);
            radioButton_noneAmarillo.Name = "radioButton_noneAmarillo";
            radioButton_noneAmarillo.Size = new Size(74, 24);
            radioButton_noneAmarillo.TabIndex = 8;
            radioButton_noneAmarillo.TabStop = true;
            radioButton_noneAmarillo.Text = "NONE";
            radioButton_noneAmarillo.UseVisualStyleBackColor = true;
            radioButton_noneAmarillo.CheckedChanged += radioButton_noneAmarillo_CheckedChanged;
            // 
            // radioButton_cpuAmarillo
            // 
            radioButton_cpuAmarillo.AutoSize = true;
            radioButton_cpuAmarillo.Location = new Point(8, 195);
            radioButton_cpuAmarillo.Name = "radioButton_cpuAmarillo";
            radioButton_cpuAmarillo.Size = new Size(62, 24);
            radioButton_cpuAmarillo.TabIndex = 7;
            radioButton_cpuAmarillo.TabStop = true;
            radioButton_cpuAmarillo.Text = "CPU";
            radioButton_cpuAmarillo.UseVisualStyleBackColor = true;
            radioButton_cpuAmarillo.CheckedChanged += radioButton_cpuAmarillo_CheckedChanged;
            // 
            // radioButton_playerVerde
            // 
            radioButton_playerVerde.AutoSize = true;
            radioButton_playerVerde.Location = new Point(120, 195);
            radioButton_playerVerde.Name = "radioButton_playerVerde";
            radioButton_playerVerde.Size = new Size(94, 24);
            radioButton_playerVerde.TabIndex = 12;
            radioButton_playerVerde.TabStop = true;
            radioButton_playerVerde.Text = "PLAYER";
            radioButton_playerVerde.UseVisualStyleBackColor = true;
            radioButton_playerVerde.CheckedChanged += radioButton_playerVerde_CheckedChanged;
            // 
            // radioButton_noneVerde
            // 
            radioButton_noneVerde.AutoSize = true;
            radioButton_noneVerde.Location = new Point(251, 195);
            radioButton_noneVerde.Name = "radioButton_noneVerde";
            radioButton_noneVerde.Size = new Size(74, 24);
            radioButton_noneVerde.TabIndex = 11;
            radioButton_noneVerde.TabStop = true;
            radioButton_noneVerde.Text = "NONE";
            radioButton_noneVerde.UseVisualStyleBackColor = true;
            radioButton_noneVerde.CheckedChanged += radioButton_noneVerde_CheckedChanged;
            // 
            // radioButton_cpuVerde
            // 
            radioButton_cpuVerde.AutoSize = true;
            radioButton_cpuVerde.Location = new Point(14, 195);
            radioButton_cpuVerde.Name = "radioButton_cpuVerde";
            radioButton_cpuVerde.Size = new Size(62, 24);
            radioButton_cpuVerde.TabIndex = 10;
            radioButton_cpuVerde.TabStop = true;
            radioButton_cpuVerde.Text = "CPU";
            radioButton_cpuVerde.UseVisualStyleBackColor = true;
            radioButton_cpuVerde.CheckedChanged += radioButton_cpuVerde_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 535);
            Controls.Add(buttonEmpezar);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_Azul.ResumeLayout(false);
            groupBox_Azul.PerformLayout();
            groupBox_Rojo.ResumeLayout(false);
            groupBox_Rojo.PerformLayout();
            groupBox_Amarillo.ResumeLayout(false);
            groupBox_Amarillo.PerformLayout();
            groupBox_Verde.ResumeLayout(false);
            groupBox_Verde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Azul).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Rojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Amarillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Verde).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonEmpezar;
        private GroupBox groupBox_Verde;
        private GroupBox groupBox_Amarillo;
        private GroupBox groupBox_Rojo;
        private GroupBox groupBox_Azul;
        private PictureBox pictureBox_Azul;
        private PictureBox pictureBox_Verde;
        private PictureBox pictureBox_Amarillo;
        private PictureBox pictureBox_Rojo;
        private RadioButton radioButton_playerVerde;
        private RadioButton radioButton_noneVerde;
        private RadioButton radioButton_cpuVerde;
        private RadioButton radioButton_playerAmarillo;
        private RadioButton radioButton_noneAmarillo;
        private RadioButton radioButton_cpuAmarillo;
        private RadioButton radioButton_playerRojo;
        private RadioButton radioButton_noneRojo;
        private RadioButton radioButton_cpuRojo;
        private RadioButton radioButton_playerAzul;
        private RadioButton radioButton_noneAzul;
        private RadioButton radioButton_cpuAzul;
    }
}