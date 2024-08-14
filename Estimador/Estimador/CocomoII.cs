using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimador
{
    public partial class CocomoII : Form
    {
        public int PuntosFuncionTotal = 0;
        public double kldc = 0;
        public double conductor_total = 1;
        public double conductor_escala_total = 0;
        public double cpm_total = 0;

        /// </Peso por estapas>
        public double peso_Esfuerzo_Inicio = 0.05f;
        public double peso_Esfuerzo_Elaboracion = 0.2f;
        public double peso_Esfuerzo_Construccion = 0.65f;
        public double peso_Esfuerzo_Transicion = 0.1f;

        public double peso_Tiempo_Inicio = 0.1f;
        public double peso_Tiempo_Elaboracion = 0.3f;
        public double peso_Tiempo_Construccion = 0.5f;
        public double peso_Tiempo_Transicion = 0.1f;
        /// </Pesos por estapas>


        ///</Estimacion Final>
        public double costo_total = 0;

        public double esfuerzoFinal = 0;
        public double tiempoFinal = 0;
        /// </Estimacion Final>

        public CocomoII()
        {
            InitializeComponent();

            string[] opciones = { "nominal" };

            ConfigurarComboBox(cb_Rss, opciones);
            ConfigurarComboBox(cb_Tbd, opciones);
            ConfigurarComboBox(cb_Cpr, opciones);
            ConfigurarComboBox(cb_Ruse, opciones);
            ConfigurarComboBox(cb_Doc, opciones);
            ConfigurarComboBox(cb_Rte, opciones);
            ConfigurarComboBox(cb_Rmp, opciones);
            ConfigurarComboBox(cb_Vmc, opciones);
            ConfigurarComboBox(cb_Can, opciones);
            ConfigurarComboBox(cb_Eapl, opciones);
            ConfigurarComboBox(cb_Cpro, opciones);
            ConfigurarComboBox(cb_Cper, opciones);
            ConfigurarComboBox(cb_Epla, opciones);
            ConfigurarComboBox(cb_Elp, opciones);
            ConfigurarComboBox(cb_Uhs, opciones);
            ConfigurarComboBox(cb_Rpl, opciones);
            ConfigurarComboBox(cb_Dms, opciones);
            ConfigurarComboBox(cb_Prec, opciones);
            ConfigurarComboBox(cb_Flex, opciones);
            ConfigurarComboBox(cb_Resl, opciones);
            ConfigurarComboBox(cb_Team, opciones);
            ConfigurarComboBox(cb_Pmat, opciones);

        }

        private void ConfigurarComboBox(System.Windows.Forms.ComboBox comboBox, string[] opciones)
        {
            //comboBox.Items.AddRange(opciones);
            comboBox.SelectedIndex = comboBox.Items.IndexOf("nominal");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //
        private void ModoDesarrollo()
        {
            if (kldc_rdb.Checked)
            {
                kldc = double.TryParse(KLDC_txt.Text, out double result) ? result : 0;
                //MessageBox.Show(Convert.ToString(kldc));
                gbAjustepf.Visible = false;
            }
            if (puntosdefuncion_rdb.Checked)
            {
                gbAjustepf.Visible = true;
                kldc = PuntosFuncionTotal;
                //MessageBox.Show(Convert.ToString(kldc));
                //falta igualar la variable
            }
        }
        //
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void bt_GuardarConductores_Click(object sender, EventArgs e)
        {
            // Obtener valores seleccionados de los ComboBox y calcular costes

            ///// Conductores de Costes
  
            //producto
            double rssCoste = CalcularCoste(cb_Rss.SelectedItem?.ToString() ?? "1", 0);
            double tbdCoste = CalcularCoste(cb_Tbd.SelectedItem?.ToString() ?? "1", 1);
            double cprCoste = CalcularCoste(cb_Cpr.SelectedItem?.ToString() ?? "1", 2);
            double ruseCoste = CalcularCoste(cb_Ruse.SelectedItem?.ToString() ?? "1", 3);
            double docCoste = CalcularCoste(cb_Doc.SelectedItem?.ToString() ?? "1", 4);
            // plataforma
            double rteCoste = CalcularCoste(cb_Rte.SelectedItem?.ToString() ?? "1", 5);
            double rmpCoste = CalcularCoste(cb_Rmp.SelectedItem?.ToString() ?? "1", 6);
            double vmcCoste = CalcularCoste(cb_Vmc.SelectedItem?.ToString() ?? "1", 7);
            // personal
            double canCoste = CalcularCoste(cb_Can.SelectedItem?.ToString() ?? "1", 8);
            double eaplCoste = CalcularCoste(cb_Eapl.SelectedItem?.ToString() ?? "1", 9);
            double cproCoste = CalcularCoste(cb_Cpro.SelectedItem?.ToString() ?? "1", 10);
            double cperCoste = CalcularCoste(cb_Cper.SelectedItem?.ToString() ?? "1", 11);
            double eplaCoste = CalcularCoste(cb_Epla.SelectedItem?.ToString() ?? "1", 12);
            double elpCoste = CalcularCoste(cb_Elp.SelectedItem?.ToString() ?? "1", 13);
            // proyecto
            double uhsCoste = CalcularCoste(cb_Uhs.SelectedItem?.ToString() ?? "1", 14);
            double rplCoste = CalcularCoste(cb_Rpl.SelectedItem?.ToString() ?? "1", 15);
            double dmsCoste = CalcularCoste(cb_Dms.SelectedItem?.ToString() ?? "1", 16);



            //

            ///// Conductores de Escala

            double precEscala = CalcularCoste(cb_Prec.SelectedItem?.ToString() ?? "3.72", 17);
            double flexEscala = CalcularCoste(cb_Flex.SelectedItem?.ToString() ?? "3.04", 18);
            double reslEscala = CalcularCoste(cb_Resl.SelectedItem?.ToString() ?? "4.24", 19);
            double teamEscala = CalcularCoste(cb_Team.SelectedItem?.ToString() ?? "3.29", 20);
            double pmatEscala = CalcularCoste(cb_Pmat.SelectedItem?.ToString() ?? "4.68", 21);

            ///// Conductores de Escala



            // total coste///
            double totalCoste = rssCoste * tbdCoste * cprCoste * ruseCoste * docCoste * rteCoste * rmpCoste * vmcCoste * canCoste * eaplCoste * cproCoste * cperCoste * eplaCoste * elpCoste * uhsCoste * rplCoste * dmsCoste;
            conductor_total = totalCoste;
            //MessageBox.Show($"Conductor de Coste Total: {conductor_total}");

            conductor_escala_total = precEscala + flexEscala + reslEscala + teamEscala + pmatEscala;
            // MessageBox.Show($"Conductor de Escala Total: {conductor_escala_total}");

        }

        //
        private double CalcularCoste(string seleccion, int tipo)
        {
            // Definir los valores correspondientes a cada opción para cada ComboBox

            // Matriz de valores
            double[,] valores = new double[6, 22];

            // Arrays con los valores de cada diccionario
            double[] valoresRSS = { 0.82, 0.92, 1, 1.10, 1.26, 1 };
            double[] valoresTBD = { 1, 0.90, 1, 1.14, 1.28, 1 };
            double[] valoresCPR = { 0.73, 0.87, 1, 1.17, 1.34, 1.74 };
            double[] valoresRUSE = { 1, 0.95, 1, 1.07, 1.15, 1.24 };
            double[] valoresDOC = { 0.81, 0.91, 1, 1.11, 1.23, 1 };

            //R P M
            double[] valoresRTE = { 1, 1, 1, 1.11, 1.29, 1.63 };
            double[] valoresRMP = { 1, 1, 1, 1.05, 1.17, 1.46 };
            double[] valoresVMC = { 1, 0.87, 1, 1.15, 1.30, 1 };

            double[] valoresCAN = { 1.42, 1.19, 1, 0.85, 0.71, 1 };
            double[] valoresEAPL = { 1.22, 1.10, 1, 0.88, 0.81, 1 };
            double[] valoresCPRO = { 1.34, 1.15, 1, 0.88, 0.76, 1 };
            double[] valoresCPER = { 1.29, 1.12, 1, 0.90, 0.81, 1 };
            double[] valoresEPLA = { 1.19, 1.09, 1, 0.91, 0.85, 1 };
            double[] valoresELP = { 1.20, 1.09, 1, 0.91, 0.84, 1 };

            double[] valoresUHS = { 1.17, 1.09, 1, 0.90, 0.78, 1 };
            double[] valoresRPL = { 1.43, 1.14, 1, 1, 1, 1 };
            double[] valoresDMS = { 1.22, 1.09, 1, 0.93, 0.86, 0.80 };

            // Conductores de Escala
            double[] valoresPREC = { 6.20, 4.96, 3.72, 2.48, 1.24, 0 };
            double[] valoresFLEX = { 5.07, 4.05, 3.04, 2.03, 1.01, 0 };
            double[] valoresRESL = { 7.07, 5.65, 4.24, 2.83, 1.41, 0 };
            double[] valoresTEAM = { 5.48, 4.38, 3.29, 2.19, 1.10, 0 };
            double[] valoresPMAT = { 7.80, 6.24, 4.68, 3.12, 1.56, 0 };


            // Llenar la matriz con los valores
            for (int i = 0; i < 6; i++)
            {
                valores[i, 0] = valoresRSS[i];
                valores[i, 1] = valoresTBD[i];
                valores[i, 2] = valoresCPR[i];
                valores[i, 3] = valoresRUSE[i];
                valores[i, 4] = valoresDOC[i];
                valores[i, 5] = valoresRMP[i];
                valores[i, 6] = valoresRTE[i];
                valores[i, 7] = valoresVMC[i];
                valores[i, 8] = valoresCAN[i];
                valores[i, 9] = valoresEAPL[i];
                valores[i, 10] = valoresCPRO[i];
                valores[i, 11] = valoresCPER[i];
                valores[i, 12] = valoresEPLA[i];
                valores[i, 13] = valoresELP[i];
                valores[i, 14] = valoresUHS[i];
                valores[i, 15] = valoresRPL[i];
                valores[i, 16] = valoresDMS[i];
                valores[i, 17] = valoresPREC[i];
                valores[i, 18] = valoresFLEX[i];
                valores[i, 19] = valoresRESL[i];
                valores[i, 20] = valoresTEAM[i];
                valores[i, 21] = valoresPMAT[i];
            }

            // Diccionario para mapear la selección a índices
            Dictionary<string, int> calidadIndice = new Dictionary<string, int>()
    {
        { "muy_bajo", 0 },
        { "bajo", 1 },
        { "nominal", 2 },
        { "alto", 3 },
        { "muy_alto", 4 },
        { "extra_alto", 5 }
    };

            /*
            if (string.IsNullOrEmpty(seleccion) || !calidadIndice.ContainsKey(seleccion))
            {
                return 1.0; // Valor nominal predeterminado
            }
            else
            {
                int fila = calidadIndice[seleccion];
                return valores[fila, tipo];
            }*/


            //

            if (string.IsNullOrEmpty(seleccion) || !calidadIndice.ContainsKey(seleccion))
            {
                return valores[2, tipo]; // Retorna el valor correspondiente a nominal
            }
            else
            {
                int fila = calidadIndice[seleccion];
                return valores[fila, tipo];
            }

            // Verificar si la selección es válida
            // Manejar el caso de valor por defecto


            //


        }

        //

        private void kldc_rdb_Click(object sender, EventArgs e)
        {
            ModoDesarrollo();
        }

        private void puntosdefuncion_rdb_Click(object sender, EventArgs e)
        {
            ModoDesarrollo();
        }

        private void lenguaje_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice seleccionado
            int selectedIndex = lenguaje_cbb.SelectedIndex;

            // Asignar valores basados en el índice seleccionado
            switch (selectedIndex)
            {
                case 0: // Java
                        // Asignar el valor 53 a una variable o utilizarlo directamente
                    int valorJava = 53;
                    // Puedes hacer lo que necesites con valorJava
                    break;
                case 1: // Fortran 77
                    int valorFortran77 = 105;
                    // Hacer algo con valorFortran77
                    break;
                case 2: // Pascal
                    int valorPascal = 91;
                    // Hacer algo con valorPascal
                    break;
                case 3: // Prolog
                    int valorProlog = 64;
                    // Hacer algo con valorProlog
                    break;
                case 4: // Ensamblador
                    int valorEnsamblador = 320;
                    // Hacer algo con valorEnsamblador
                    break;
                case 5: // C++
                    int valorCpp = 29;
                    // Hacer algo con valorCpp
                    break;
                case 6: // C
                    int valorC = 128;
                    // Hacer algo con valorC
                    break;
                default:
                    // Manejar cualquier otro caso si es necesario
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eb = TryParseOrDefault(textBox3.Text) * 3;
            int em = TryParseOrDefault(textBox4.Text) * 4;
            int ea = TryParseOrDefault(textBox5.Text) * 6;

            int sb = TryParseOrDefault(textBox6.Text) * 4;
            int sm = TryParseOrDefault(textBox7.Text) * 5;
            int sa = TryParseOrDefault(textBox8.Text) * 7;

            int cb = TryParseOrDefault(textBox9.Text) * 3;
            int cm = TryParseOrDefault(textBox10.Text) * 4;
            int ca = TryParseOrDefault(textBox11.Text) * 6;

            int ab = TryParseOrDefault(textBox12.Text) * 7;
            int am = TryParseOrDefault(textBox13.Text) * 10;
            int aa = TryParseOrDefault(textBox14.Text) * 15;

            int ib = TryParseOrDefault(textBox15.Text) * 5;
            int im = TryParseOrDefault(textBox16.Text) * 7;
            int ia = TryParseOrDefault(textBox17.Text) * 10;

            PuntosFuncionTotal = eb + em + ea + sb + sm + sa + cb + cm + ca + ab + am + aa + ib + im + ia;
            int sumasloc = PuntosFuncionTotal;
            // Mostrar el resultado en puntosfunciontotal_txt
            sloc_txt.Text = sumasloc.ToString();

            // Determinar el valor del multiplicador
            int valorMultiplicador = 0;
            if (otro_chb.Checked)
            {
                // Si el CheckBox está marcado, usar el valor del TextBox como multiplicador
                int factor = TryParseOrDefault(multiplicador_txt.Text);
                valorMultiplicador = factor;
            }
            else
            {
                // De lo contrario, usar el valor del ComboBox
                int selectedIndex = lenguaje_cbb.SelectedIndex;

                switch (selectedIndex)
                {
                    case 0: // Java
                        valorMultiplicador = 53;
                        break;
                    case 1: // Fortran 77
                        valorMultiplicador = 105;
                        break;
                    case 2: // Pascal
                        valorMultiplicador = 91;
                        break;
                    case 3: // Prolog
                        valorMultiplicador = 64;
                        break;
                    case 4: // Ensamblador
                        valorMultiplicador = 320;
                        break;
                    case 5: // C++
                        valorMultiplicador = 29;
                        break;
                    case 6: // C
                        valorMultiplicador = 128;
                        break;
                    default:
                        valorMultiplicador = 0; // Manejar cualquier otro caso si es necesario
                        break;
                }
            }

            // Multiplicar PuntosFuncionTotal por valorMultiplicador
            PuntosFuncionTotal *= valorMultiplicador;
            PuntosFuncionTotal = PuntosFuncionTotal / 1000;
            // Mostrar el resultado en puntosfunciontotal_txt
            puntosfunciontotal_txt.Text = PuntosFuncionTotal.ToString();
            kldc = PuntosFuncionTotal;
            //MessageBox.Show(kldc.ToString());
        }

        private int TryParseOrDefault(string text)
        {
            int result;
            return int.TryParse(text, out result) ? result : 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inicio_costo = TryParseOrDefault(textBox1.Text) * peso_Esfuerzo_Inicio;
            double elaboracion_costo = TryParseOrDefault(textBox2.Text) * peso_Esfuerzo_Elaboracion;
            double contruccion_costo = TryParseOrDefault(textBox18.Text) * peso_Esfuerzo_Construccion;
            double transicion_costo = TryParseOrDefault(textBox19.Text) * peso_Esfuerzo_Transicion;

            cpm_total = inicio_costo + elaboracion_costo + contruccion_costo + transicion_costo;

            double division_escala = conductor_escala_total / 100;

            esfuerzoFinal = 2.94f * conductor_total * Math.Pow(kldc, (0.91 + division_escala));
            totalEsfuerzo_txt.Text = Math.Round(esfuerzoFinal, 2).ToString("F2");
            tiempoFinal = 3.67f * Math.Pow(esfuerzoFinal, 0.28 + (0.8 * division_escala));
            totalTdesarrollo_txt.Text = Math.Round(tiempoFinal, 2).ToString("F2");
            costo_total = esfuerzoFinal * cpm_total;
            totalCpm_txt.Text = Math.Round(costo_total, 2).ToString("F2");

            // esfuerzo por fases
            inicio_esfuerzo_txt.Text = Math.Round(esfuerzoFinal * peso_Esfuerzo_Inicio, 2).ToString("F2");
            elaboracion_esfuerzo_txt.Text = Math.Round(esfuerzoFinal * peso_Esfuerzo_Elaboracion, 2).ToString("F2");
            construccion_esfuerzo_txt.Text = Math.Round(esfuerzoFinal * peso_Esfuerzo_Construccion, 2).ToString("F2");
            transicion_esfuerzo_txt.Text = Math.Round(esfuerzoFinal * peso_Esfuerzo_Transicion, 2).ToString("F2");

            // tiempo por fases
            inicio_Tdesarrollo_txt.Text = Math.Round(tiempoFinal * peso_Tiempo_Inicio, 2).ToString("F2");
            elaboracion_Tdesarrollo_txt.Text = Math.Round(tiempoFinal * peso_Tiempo_Elaboracion, 2).ToString("F2");
            construccion_Tdesarrollo_txt.Text = Math.Round(tiempoFinal * peso_Tiempo_Construccion, 2).ToString("F2");
            transicion_Tdesarrollo_txt.Text = Math.Round(tiempoFinal * peso_Tiempo_Transicion, 2).ToString("F2");

            // costo por fases

            double costoFinalInicio = costo_total * peso_Esfuerzo_Inicio;
            double costoFinalElaboracion = costo_total * peso_Esfuerzo_Elaboracion;
            double costoFinalConstruccion = costo_total * peso_Esfuerzo_Construccion;
            double costoFinalTransicion = costo_total * peso_Esfuerzo_Transicion;

            inicio_Cpm_txt.Text = Math.Round(costoFinalInicio, 2).ToString("F2");
            elaboracion_Cpm_txt.Text = Math.Round(costoFinalElaboracion, 2).ToString("F2");
            construccion_Cpm_txt.Text = Math.Round(costoFinalConstruccion, 2).ToString("F2");
            transicion_Cpm_txt.Text = Math.Round(costoFinalTransicion, 2).ToString("F2");
        }

        private void CocomoII_Load(object sender, EventArgs e)
        {

        }
    }
}
