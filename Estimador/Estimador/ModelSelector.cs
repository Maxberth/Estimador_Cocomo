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

        public ModelSelect()
        {
            InitializeComponent();
        }

        private void COCOMO81_btn_Click(object sender, EventArgs e)
        {/*
            OptionCocomo = false;
            Input nuevaVentana = new Input();
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
            this.Close();*/
            OptionCocomo = false;
            Input nuevaVentana = new Input(OptionCocomo);
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
            this.Close();
        }

        private void COCOMOII_btn_Click(object sender, EventArgs e)
        { /*
            OptionCocomo = true;
            Input nuevaVentana = new Input();
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
            this.Close();*/
            OptionCocomo = true;
            Input nuevaVentana = new Input(OptionCocomo);
            nuevaVentana.MdiParent = this.MdiParent;
            nuevaVentana.WindowState = FormWindowState.Maximized;
            nuevaVentana.Show();
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
            try
            {
                UseCase nuevaVentana = new UseCase();
                nuevaVentana.MdiParent = this.MdiParent;
                nuevaVentana.WindowState = FormWindowState.Maximized;
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la ventana: " + ex.Message);
            }

        }
    }
}
