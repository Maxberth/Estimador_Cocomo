using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimador
{
    public partial class ModelSelect : Form
    {
        public bool OptionCocomo { get; private set; }
        public int ModeloSeleccionado { get; private set; }


        public ModelSelect()
        {
            InitializeComponent();
        }

        private void COCOMO81_btn_Click(object sender, EventArgs e)
        {
            OptionCocomo = false;
            ModeloSeleccionado = 0;

            StartMenu nuevaVentanaStartMenu = new StartMenu(ModeloSeleccionado);
            Input nuevaVentana = new Input(OptionCocomo);

            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();

            // Establecer el resultado del diálogo y cerrar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void COCOMOII_btn_Click(object sender, EventArgs e)
        {
            OptionCocomo = true;
            ModeloSeleccionado = 1;

            StartMenu nuevaVentanaStartMenu = new StartMenu(ModeloSeleccionado);
            CocomoII nuevaVentana = new CocomoII();

            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();

            // Establecer el resultado del diálogo y cerrar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UseCase_btn_Click(object sender, EventArgs e)
        {
            ModeloSeleccionado = 2;

            StartMenu nuevaVentanaStartMenu = new StartMenu(ModeloSeleccionado);
            UseCase nuevaVentana = new UseCase();

            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();

            // Establecer el resultado del diálogo y cerrar
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
