namespace Estimador
{
    public partial class StartMenu : Form
    {
        private int _modeloSeleccionado;

        public StartMenu(int modeloSeleccionado)
        {
            InitializeComponent();
            _modeloSeleccionado = modeloSeleccionado;
        }

        private void OpenProjectOptions(object sender, EventArgs e)
        {
            ProjectOptions nuevaVentana = new ProjectOptions
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            nuevaVentana.Show();
        }

        private void ecuacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional de carga aquí si es necesario
        }

        private void ayudaEnLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCompletaHtml = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Resources", "index.html");

                if (File.Exists(rutaCompletaHtml))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaCompletaHtml,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("El archivo HTML no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }
        }

        private void cocomoIntermedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form
            {
                Text = "Ventana de Ecuaciones",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string rutaCompleta = Path.Combine(rutaProyecto, "Resources", "ecuaciones.png"); // Ruta para COCOMO81
           
            try
            {
                if (File.Exists(rutaCompleta))
                {
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            nuevaVentana.Controls.Add(pictureBox);
            nuevaVentana.ShowDialog();
        }

        private void cocomoIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form
            {
                Text = "Ventana de Ecuaciones",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string rutaCompleta = Path.Combine(rutaProyecto, "Resources", "ecuacionesCOCOMOII.png"); // Ruta para COCOMOII

            try
            {
                if (File.Exists(rutaCompleta))
                {
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            nuevaVentana.Controls.Add(pictureBox);
            nuevaVentana.ShowDialog();
        }

        private void casosDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form
            {
                Text = "Ventana de Ecuaciones",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string rutaCompleta = Path.Combine(rutaProyecto, "Resources", "ecuacionesUSECASE.png"); // Ruta para UseCase

            try
            {
                if (File.Exists(rutaCompleta))
                {
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                }
                else
                {
                    MessageBox.Show("El archivo de imagen no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            nuevaVentana.Controls.Add(pictureBox);
            nuevaVentana.ShowDialog();
        }
    }
}
