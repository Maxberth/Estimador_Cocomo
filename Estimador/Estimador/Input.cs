using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
/*
 * Hecho por Vigo Saldana Alberth Jesus
 * 
 */

namespace Estimador
{
    public partial class Input : Form
    {
        public int PuntosFuncionTotal = 0;
        public double costo_total = 0;
        //public double kldc = 0;
        public double kldc = 0;
        public string tipoProyecto = "";
        public double conductor_total = 0;
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
        public double cpmFinal = 0;
        public double esfuerzoFinal = 0;
        public double tiempoFinal = 0;
        /// </Estimacion Final>
        public Input()
        {
            InitializeComponent();
            // Lista de opciones
            string[] opciones = { "muy_bajo", "bajo", "nominal", "alto", "muy_alto", "extra_alto" };

            // Agregar opciones y establecer "nominal" como predeterminado para cada ComboBox
            ConfigurarComboBox(cb_Rss, opciones);
            ConfigurarComboBox(cb_Tbd, opciones);
            ConfigurarComboBox(cb_Cpr, opciones);
            ConfigurarComboBox(cb_Rte, opciones);
            ConfigurarComboBox(cb_Rmp, opciones);
            ConfigurarComboBox(cb_Vmc, opciones);
            ConfigurarComboBox(cb_Trc, opciones);
            ConfigurarComboBox(cb_Can, opciones);
            ConfigurarComboBox(cb_Ean, opciones);
            ConfigurarComboBox(cb_Cpro, opciones);
            ConfigurarComboBox(cb_Eso, opciones);
            ConfigurarComboBox(cb_Elp, opciones);
            ConfigurarComboBox(cb_Utp, opciones);
            ConfigurarComboBox(cbUhs, opciones);
            ConfigurarComboBox(cb_Rpl, opciones);
        }

        private void ConfigurarComboBox(System.Windows.Forms.ComboBox comboBox, string[] opciones)
        {
            //comboBox.Items.AddRange(opciones);
            comboBox.SelectedIndex = comboBox.Items.IndexOf("nominal");
        }
        //---
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
        //----
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //ModoDesarrollo();
        }
        /*
        private void CalcularPuntosFuncion(object sender, EventArgs e)
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

            // Multiplicar por el valor seleccionado del ComboBox
            int selectedIndex = lenguaje_cbb.SelectedIndex;
            int valorMultiplicador = 0;

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

            //
            if (otro_chb.Checked)
            {
                // Asegúrate de que el texto del TextBox se pueda convertir a un número
                if (double.TryParse(multiplicador_txt.Text, out double factor))
                {
                    // El valor ha sido guardado correctamente en la variable factor
                    //MessageBox.Show("Factor guardado: " + factor);
                }
                else
                {
                    // Maneja el caso en que la conversión falla
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
            //
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
            if (int.TryParse(text, out int result))
            {
                return result;
            }
            return 0;
        }*/
        private void CalcularPuntosFuncion(object sender, EventArgs e)
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

        // Función auxiliar para intentar convertir el texto a entero o devolver un valor por defecto
        private int TryParseOrDefault(string text)
        {
            int result;
            return int.TryParse(text, out result) ? result : 0;
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiplicador_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void puntosfunciontotal_txt_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void lenguaje_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */
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
        /*
        private void SLOC_txt_TextChanged(object sender, EventArgs e)
        {

        }*/


        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GuardarCostes(object sender, EventArgs e)
        {
            // Obtener valores seleccionados de los ComboBox y calcular costes
            double rssCoste = CalcularCoste(cb_Rss.SelectedItem?.ToString(), 0);
            double tbdCoste = CalcularCoste(cb_Tbd.SelectedItem?.ToString(), 1);
            double cprCoste = CalcularCoste(cb_Cpr.SelectedItem?.ToString(), 2);
            double rteCoste = CalcularCoste(cb_Rte.SelectedItem?.ToString(), 3);
            double rmpCoste = CalcularCoste(cb_Rmp.SelectedItem?.ToString(), 4);
            double vmcCoste = CalcularCoste(cb_Vmc.SelectedItem?.ToString(), 5);
            double trcCoste = CalcularCoste(cb_Trc.SelectedItem?.ToString(), 6);
            double canCoste = CalcularCoste(cb_Can.SelectedItem?.ToString(), 7);
            double eanCoste = CalcularCoste(cb_Ean.SelectedItem?.ToString(), 8);
            double cproCoste = CalcularCoste(cb_Cpro.SelectedItem?.ToString(), 9);
            double esoCoste = CalcularCoste(cb_Eso.SelectedItem?.ToString(), 10);
            double elpCoste = CalcularCoste(cb_Elp.SelectedItem?.ToString(), 11);
            double utpCoste = CalcularCoste(cb_Utp.SelectedItem?.ToString(), 12);
            double uhsCoste = CalcularCoste(cbUhs.SelectedItem?.ToString(), 13);
            double rplCoste = CalcularCoste(cb_Rpl.SelectedItem?.ToString(), 14);

            double totalCoste = rssCoste * tbdCoste * cprCoste * rteCoste * rmpCoste * vmcCoste * trcCoste * canCoste * eanCoste * cproCoste * esoCoste * elpCoste * utpCoste * uhsCoste * rplCoste;
            conductor_total = totalCoste;
            //MessageBox.Show($"Total Coste: {totalCoste}");
            DefinirTipoProyecto();//cargue primero para que se asigne prederteminadamente moderado
            //MessageBox.Show(tipoProyecto);
            // Aquí puedes usar los costes calculados como lo necesites
        }



        //--


        //---

        private double CalcularCoste(string seleccion, int tipo)
        {
            // Definir los valores correspondientes a cada opción para cada ComboBox

            // Matriz de valores
            double[,] valores = new double[6, 15];

            // Arrays con los valores de cada diccionario
            double[] valoresRSS = { 0.75, 0.88, 1, 1.15, 1.40, 1 };
            double[] valoresTBD = { 1, 0.94, 1, 1.08, 1.16, 1 };
            double[] valoresCPR = { 0.70, 0.85, 1, 1.15, 1.30, 1.65 };
            double[] valoresRTE = { 1, 1, 1, 1.11, 1.30, 1.66 };
            double[] valoresRMP = { 1, 1, 1, 1.06, 1.30, 1.58 };
            double[] valoresVMC = { 1, 0.87, 1, 1.15, 1.30, 1 };
            double[] valoresTRC = { 1, 0.87, 1, 1.07, 1.15, 1 };
            double[] valoresCAN = { 1.46, 1.19, 1, 0.86, 0.71, 1 };
            double[] valoresEAN = { 1.29, 1.13, 1, 0.91, 0.82, 1 };
            double[] valoresCPRO = { 1.42, 1.17, 1, 0.86, 0.7, 1 };
            double[] valoresESO = { 1.21, 1.12, 1, 0.96, 1, 1 };
            double[] valoresELP = { 1.14, 1.10, 1, 0.95, 1, 1 };
            double[] valoresUTP = { 1.24, 1.10, 1, 0.91, 0.82, 1 };
            double[] valoresUHS = { 1.24, 1.10, 1, 0.91, 0.82, 1 };
            double[] valoresRPL = { 1.23, 1.08, 1, 1.04, 1.10, 1 };

            // Llenar la matriz con los valores
            for (int i = 0; i < 6; i++)
            {
                valores[i, 0] = valoresRSS[i];
                valores[i, 1] = valoresTBD[i];
                valores[i, 2] = valoresCPR[i];
                valores[i, 3] = valoresRTE[i];
                valores[i, 4] = valoresRMP[i];
                valores[i, 5] = valoresVMC[i];
                valores[i, 6] = valoresTRC[i];
                valores[i, 7] = valoresCAN[i];
                valores[i, 8] = valoresEAN[i];
                valores[i, 9] = valoresCPRO[i];
                valores[i, 10] = valoresESO[i];
                valores[i, 11] = valoresELP[i];
                valores[i, 12] = valoresUTP[i];
                valores[i, 13] = valoresUHS[i];
                valores[i, 14] = valoresRPL[i];
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


            if (string.IsNullOrEmpty(seleccion) || !calidadIndice.ContainsKey(seleccion))
            {
                return 1.0; // Valor nominal predeterminado
            }
            else
            {
                int fila = calidadIndice[seleccion];
                return valores[fila, tipo];
            }
        }



        ///
        private void DefinirTipoProyecto()
        {
            if (organico_rdb.Checked)
            {
                tipoProyecto = "organico";
            }
            else if (moderado_rdb.Checked)
            {
                tipoProyecto = "moderado";
            }
            else if (embebido_rdb.Checked)
            {
                tipoProyecto = "embebido";
            }
            else
            {
                tipoProyecto = "moderado"; // Valor por defecto
            }
            //MessageBox.Show(tipoProyecto);
        }


        ///
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inicio_costo = TryParseOrDefault(textBox1.Text) * peso_Esfuerzo_Inicio;
            double elaboracion_costo = TryParseOrDefault(textBox2.Text) * peso_Esfuerzo_Elaboracion;
            double contruccion_costo = TryParseOrDefault(textBox18.Text) * peso_Esfuerzo_Construccion;
            double transicion_costo = TryParseOrDefault(textBox19.Text) * peso_Esfuerzo_Transicion;

            costo_total = inicio_costo + elaboracion_costo + contruccion_costo + transicion_costo;
            //MessageBox.Show($"Total Coste: {costo_total}");

            if (tipoProyecto == "organico")
            {
                esfuerzoFinal = 3.2f * Math.Pow(kldc, 1.05) * conductor_total;
                totalEsfuerzo_txt.Text = Math.Round(esfuerzoFinal, 2).ToString("F2");
                tiempoFinal = 2.5f * Math.Pow(esfuerzoFinal, 0.38);
                totalTdesarrollo_txt.Text = Math.Round(tiempoFinal, 2).ToString("F2");
                cpmFinal = esfuerzoFinal * costo_total;
                totalCpm_txt.Text = Math.Round(cpmFinal, 2).ToString("F2");
            }

            if (tipoProyecto == "moderado")
            {
                esfuerzoFinal = 3.2f * Math.Pow(kldc, 1.12) * conductor_total;
                totalEsfuerzo_txt.Text = Math.Round(esfuerzoFinal, 2).ToString("F2");
                tiempoFinal = 2.5f * Math.Pow(esfuerzoFinal, 0.35);
                totalTdesarrollo_txt.Text = Math.Round(tiempoFinal, 2).ToString("F2");
                cpmFinal = esfuerzoFinal * costo_total;
                totalCpm_txt.Text = Math.Round(cpmFinal, 2).ToString("F2");
            }

            if (tipoProyecto == "embebido")
            {
                esfuerzoFinal = 2.8f * Math.Pow(kldc, 1.20) * conductor_total;
                totalEsfuerzo_txt.Text = Math.Round(esfuerzoFinal, 2).ToString("F2");
                tiempoFinal = 2.5f * Math.Pow(esfuerzoFinal, 0.32);
                totalTdesarrollo_txt.Text = Math.Round(tiempoFinal, 2).ToString("F2");
                cpmFinal = esfuerzoFinal * costo_total;
                totalCpm_txt.Text = Math.Round(cpmFinal, 2).ToString("F2");
            }

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
            inicio_Cpm_txt.Text = Math.Round(inicio_costo, 2).ToString("F2");
            elaboracion_Cpm_txt.Text = Math.Round(elaboracion_costo, 2).ToString("F2");
            construccion_Cpm_txt.Text = Math.Round(contruccion_costo, 2).ToString("F2");
            transicion_Cpm_txt.Text = Math.Round(transicion_costo, 2).ToString("F2");


        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void KLDC_txt_TextChanged(object sender, EventArgs e)
        {
            //int kldc = TryParseOrDefault(KLDC_text.text);
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void kldc_rdb_CheckedChanged(object sender, EventArgs e)
        {
            // ModoDesarrollo();
        }

        private void slox_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click_1(object sender, EventArgs e)
        {

        }

        private void organico_rdb_CheckedChanged(object sender, EventArgs e)
        {
            //DefinirTipoProyecto();
        }

        private void moderado_rdb_CheckedChanged(object sender, EventArgs e)
        {
            //DefinirTipoProyecto();
        }

        private void embebido_rdb_CheckedChanged(object sender, EventArgs e)
        {
            //DefinirTipoProyecto();
        }

        private void organico_rdb_Click(object sender, EventArgs e)
        {
            DefinirTipoProyecto();
        }

        private void moderado_rdb_Click(object sender, EventArgs e)
        {
            DefinirTipoProyecto();
        }

        private void embebido_rdb_Click(object sender, EventArgs e)
        {
            DefinirTipoProyecto();
        }

        private void gbAjusteproyecto_Enter(object sender, EventArgs e)
        {

        }

        private void gbEsti_fases_tiempo_desarrollo_Enter(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void kldc_rdb_Click(object sender, EventArgs e)
        {
            ModoDesarrollo();
        }

        private void puntosdefuncion_rdb_Click(object sender, EventArgs e)
        {
            ModoDesarrollo();
        }

        private void multiplicador_txt_Enter(object sender, EventArgs e)
        {
            if (multiplicador_txt.Text == "Multiplicador")
            {
                multiplicador_txt.Text = "";
            }
        }

        private void multiplicador_txt_Leave(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
