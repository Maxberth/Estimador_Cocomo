namespace Estimador
{
    partial class StartMenu
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
            menuStrip1 = new MenuStrip();
            ArchivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            VerToolStripMenuItem = new ToolStripMenuItem();
            ecuacionesToolStripMenuItem = new ToolStripMenuItem();
            HerramientasToolStripMenuItem = new ToolStripMenuItem();
            generarInformeToolStripMenuItem = new ToolStripMenuItem();
            graficosYVisualizacionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaEnLineaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ArchivoToolStripMenuItem, VerToolStripMenuItem, HerramientasToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1074, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            ArchivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, imprimirToolStripMenuItem, salirToolStripMenuItem });
            ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            ArchivoToolStripMenuItem.Size = new Size(73, 24);
            ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(187, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += OpenProjectOptions;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(187, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(187, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(187, 26);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(187, 26);
            imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(187, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // VerToolStripMenuItem
            // 
            VerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ecuacionesToolStripMenuItem });
            VerToolStripMenuItem.Name = "VerToolStripMenuItem";
            VerToolStripMenuItem.Size = new Size(44, 24);
            VerToolStripMenuItem.Text = "Ver";
            // 
            // ecuacionesToolStripMenuItem
            // 
            ecuacionesToolStripMenuItem.Name = "ecuacionesToolStripMenuItem";
            ecuacionesToolStripMenuItem.Size = new Size(165, 26);
            ecuacionesToolStripMenuItem.Text = "Ecuaciones";
            ecuacionesToolStripMenuItem.Click += ecuacionesToolStripMenuItem_Click;
            // 
            // HerramientasToolStripMenuItem
            // 
            HerramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarInformeToolStripMenuItem, graficosYVisualizacionToolStripMenuItem });
            HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem";
            HerramientasToolStripMenuItem.Size = new Size(112, 24);
            HerramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // generarInformeToolStripMenuItem
            // 
            generarInformeToolStripMenuItem.Name = "generarInformeToolStripMenuItem";
            generarInformeToolStripMenuItem.Size = new Size(245, 26);
            generarInformeToolStripMenuItem.Text = "Generar Informe";
            // 
            // graficosYVisualizacionToolStripMenuItem
            // 
            graficosYVisualizacionToolStripMenuItem.Name = "graficosYVisualizacionToolStripMenuItem";
            graficosYVisualizacionToolStripMenuItem.Size = new Size(245, 26);
            graficosYVisualizacionToolStripMenuItem.Text = "Graficos y visualizacion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaEnLineaToolStripMenuItem, manualDeUsuarioToolStripMenuItem, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaEnLineaToolStripMenuItem
            // 
            ayudaEnLineaToolStripMenuItem.Name = "ayudaEnLineaToolStripMenuItem";
            ayudaEnLineaToolStripMenuItem.Size = new Size(214, 26);
            ayudaEnLineaToolStripMenuItem.Text = "Ayuda en linea";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            manualDeUsuarioToolStripMenuItem.Size = new Size(214, 26);
            manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(214, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 633);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "StartMenu";
            Text = "Estimador";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ArchivoToolStripMenuItem;
        private ToolStripMenuItem VerToolStripMenuItem;
        private ToolStripMenuItem HerramientasToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ecuacionesToolStripMenuItem;
        private ToolStripMenuItem generarInformeToolStripMenuItem;
        private ToolStripMenuItem graficosYVisualizacionToolStripMenuItem;
        private ToolStripMenuItem ayudaEnLineaToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
