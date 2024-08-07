namespace Estimador
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void OpenProjectOptions(object sender, EventArgs e)
        {
            ProjectOptions nuevaVentana = new ProjectOptions();
            nuevaVentana.MdiParent = this;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
        }
        /*
        private void ecuacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la ventana que deseas mostrar
            Form nuevaVentana = new Form();
            nuevaVentana.Text = "Ventana de Ecuaciones";
            nuevaVentana.Size = new Size(400, 300); // Tamaño personalizable
            nuevaVentana.StartPosition = FormStartPosition.CenterScreen; // Centrar en pantalla

            // Crear un PictureBox para mostrar la imagen
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill; // Llenar todo el espacio disponible
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen al tamaño del PictureBox

            // Cargar la imagen desde un archivo
            try
            {
                pictureBox.Image = Image.FromFile(@"Estimador\Estimador\Resources\ecuaciones.png"); // Reemplaza con la ruta de tu imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            // Agregar el PictureBox a la ventana
            nuevaVentana.Controls.Add(pictureBox);

            // Mostrar la nueva ventana
            nuevaVentana.ShowDialog();
        }
        */

        private void ecuacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevaVentana = new Form();
            nuevaVentana.Text = "Ventana de Ecuaciones";
            nuevaVentana.Size = new Size(400, 300);
            nuevaVentana.StartPosition = FormStartPosition.CenterScreen;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            try
            {
                string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string rutaCompleta = Path.Combine(rutaProyecto, "Resources", "ecuaciones.png");

                if (File.Exists(rutaCompleta))
                {
                    pictureBox.Image = Image.FromFile(rutaCompleta);
                }
            }
            catch (Exception)
            {
                // Maneja el error silenciosamente o registra en un log si es necesario
            }

            nuevaVentana.Controls.Add(pictureBox);
            nuevaVentana.ShowDialog();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void ayudaEnLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pagina Web Hecha por Mirella Gamboa
            //https://github.com/gamboaMirella/helpToEstimator
            try
            {
                // Construye la ruta completa del archivo HTML
                string rutaCompletaHtml = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "Resources", "index.html");

                if (File.Exists(rutaCompletaHtml))
                {
                    // Usa Process.Start para abrir el archivo HTML en el navegador
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
                // Maneja el error de apertura del archivo HTML
                MessageBox.Show("Error al abrir el archivo HTML: " + ex.Message);
            }

        }

    }
}
