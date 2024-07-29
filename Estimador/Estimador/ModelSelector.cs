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
        public ModelSelect()
        {
            InitializeComponent();
        }

        private void COCOMO81_btn_Click(object sender, EventArgs e)
        {
            Input nuevaVentana = new Input();
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
            this.Close();
        }

        private void COCOMOII_btn_Click(object sender, EventArgs e)
        {
            Input nuevaVentana = new Input();
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
