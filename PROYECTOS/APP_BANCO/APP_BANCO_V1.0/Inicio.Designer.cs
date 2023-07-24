namespace App_Bancaria
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            extraccionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, operacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(688, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, consultarUsuarioToolStripMenuItem, modificarUsuarioToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(180, 22);
            crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            crearUsuarioToolStripMenuItem.Click += crearUsuarioToolStripMenuItem_Click;
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            consultarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            consultarUsuarioToolStripMenuItem.Text = "Consultar usuario";
            consultarUsuarioToolStripMenuItem.Click += consultarUsuarioToolStripMenuItem_Click;
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            modificarUsuarioToolStripMenuItem.Size = new Size(180, 22);
            modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            modificarUsuarioToolStripMenuItem.Click += modificarUsuarioToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depositoToolStripMenuItem, extraccionToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(88, 20);
            operacionesToolStripMenuItem.Text = "Operaciones ";
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(129, 22);
            depositoToolStripMenuItem.Text = "Deposito";
            // 
            // extraccionToolStripMenuItem
            // 
            extraccionToolStripMenuItem.Name = "extraccionToolStripMenuItem";
            extraccionToolStripMenuItem.Size = new Size(129, 22);
            extraccionToolStripMenuItem.Text = "Extraccion";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(688, 571);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem extraccionToolStripMenuItem;
    }
}