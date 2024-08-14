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

namespace Estimador
{
    public partial class UseCase : Form
    {
        public UseCase()
        {
            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UseCase_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private int TryParseOrDefault(string text)
        {
            int result;
            return int.TryParse(text, out result) ? result : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ActorSimple = TryParseOrDefault(tb_Asimple.Text)*1;
            int ActorPromedio = TryParseOrDefault(tb_Apromedio.Text)*2;
            int ActorComplejo = TryParseOrDefault(tb_Acomplejo.Text)*3;

            int FactoresPesosActor = ActorSimple+ActorPromedio+ActorComplejo;

            int CUsimples= TryParseOrDefault(tb_CUsimple.Text)*5;
            int CUPromedio = TryParseOrDefault(tb_CUpromedio.Text)*10;
            int CUComplejo = TryParseOrDefault(tb_CUcomplejo.Text)*15;
            int FactoresCasosUso = CUsimples+ CUPromedio+ CUComplejo;

            int UUCP = FactoresPesosActor + FactoresCasosUso;
            tb_Resultados_UUCP.Text = UUCP.ToString();

            double EF_F1 = TryParseOrDefault(tb_EF_familiaridad.Text); //F1
            double EF_F2 = TryParseOrDefault(tb_EF_experienciaApp.Text); //F2
            double EF_F3 = TryParseOrDefault(tb_EF_estabilidadRequisitos.Text); //F3
            double EF_F4 = TryParseOrDefault(tb_EF_experienciaLenguaje.Text);//F4
            double EF_F5 = TryParseOrDefault(tb_EF_herramientasSoporte.Text);//F5
            double EF_F6 = TryParseOrDefault(tb_EF_motivacionEquipacion.Text);//F6
            double EF_F7 = TryParseOrDefault(tb_EF_restriccionesTiempo.Text);//F7
            double EF_F8 = TryParseOrDefault(tb_EF_restriccionesRecursos.Text);//F8

            //
            int X = 0; // Contador para valores < 3 en F1-F6
            int Y = 0; // Contador para valores > 3 en F7-F8

            // Calcular X
            double[] F1_F6 = { EF_F1, EF_F2, EF_F3, EF_F4, EF_F5, EF_F6 };
            X = F1_F6.Count(value => value < 3);

            // Calcular Y
            double[] F7_F8 = { EF_F7, EF_F8 };
            Y = F7_F8.Count(value => value > 3);

            //


            double EF_familiaridad = EF_F1 * 1.5; //F1
            double EF_experienciaAPP = EF_F2 * 0.5; //F2
            double EF_estabilidadRequisitos = EF_F3 * 2; //F3
            double EF_experienciaLenguaje = EF_F4 * 0.5;//F4
            double EF_herramientasSoporte = EF_F5 * 1;//F5
            double EF_motivacionEquipo = EF_F6 * 1;//F6
            double EF_restriccionesTiempo= EF_F7 * -1;//F7
            double EF_restriccionesRecursos = EF_F8 * -1;//F8


            double EF = 1.4+(-0.03*(EF_familiaridad + EF_experienciaAPP + EF_estabilidadRequisitos + EF_experienciaLenguaje + EF_herramientasSoporte + EF_motivacionEquipo + EF_restriccionesTiempo + EF_restriccionesRecursos));
            tb_Resultados_EF.Text = Math.Round(EF, 2).ToString("F2");



            double TCF_SistemaDistribuido = TryParseOrDefault(tb_TCF_sistemaDistribuido.Text) * 2;
            double TCF_TiempoRespuesta = TryParseOrDefault(tb_TCF_tiempoRespuesta.Text) * 1;
            double TCF_EficienciaUsuario= TryParseOrDefault(tb_TCF_eficienciaUsuario.Text) *1 ;
            double TCF_ComplejidadProceso= TryParseOrDefault(tb_TCF_complejidadProceso.Text) *1 ;
            double TCF_Reusabilidad= TryParseOrDefault(tb_TCF_reusabilidad.Text) * 1;
            double TCF_FacilidadInstalacion= TryParseOrDefault(tb_TCF_facilidadInstalacion.Text) *0.5 ;
            double TCF_FacilidadUso= TryParseOrDefault(tb_TCF_facilidadUso.Text) * 0.5;
            double TCF_Portabilidad= TryParseOrDefault(tb_TCF_portabilidad.Text) * 2;
            double TCF_FacilidadCambio= TryParseOrDefault(tb_TCF_facilidadCambio.Text) *1 ;
            double TCF_UsoSimultaneo= TryParseOrDefault(tb_TCF_usoSimultaneo.Text) *1 ;
            double TCF_CaracteristicasSeguridad= TryParseOrDefault(tb_TCF_caracteristicasSeguridad.Text) *1 ;
            double TCF_AccesoTercerasPartes= TryParseOrDefault(tb_TCF_accesoDirecto.Text) * 1;
            double TCF_CapacidadesEntrenamiento= TryParseOrDefault(tb_TCF_capacidadEntrenamiento.Text) * 1;

            double TCF = 0.6 + (0.01 * (TCF_SistemaDistribuido + TCF_TiempoRespuesta + TCF_EficienciaUsuario + TCF_ComplejidadProceso + TCF_Reusabilidad + TCF_FacilidadInstalacion + TCF_FacilidadUso + TCF_Portabilidad + TCF_FacilidadCambio + TCF_UsoSimultaneo + TCF_CaracteristicasSeguridad + TCF_AccesoTercerasPartes + TCF_CapacidadesEntrenamiento));
            tb_Resultados_TCF.Text = Math.Round(TCF, 2).ToString("F2");



            double UCP = UUCP * TCF * EF;
            tb_Resultados_UCP.Text = Math.Round(UCP, 2).ToString("F2");

            double EsfuerzoDesarrollo = 0;
            //tb_Resultados_PersonasMeses.Text = Math.Round(EsfuerzoDesarrollo, 2).ToString("F2");


            if ((X+Y) <= 2)
            {
                EsfuerzoDesarrollo = 20 * UCP;
                tb_Resultados_PersonasMeses.Text = Math.Round(EsfuerzoDesarrollo, 2).ToString("F2");
            }
            else if ((X + Y) == 3 || (X + Y) == 4)
            {
                EsfuerzoDesarrollo = 28 * UCP;
                tb_Resultados_PersonasMeses.Text = Math.Round(EsfuerzoDesarrollo, 2).ToString("F2");
            }
            else if ((X + Y) >= 5)
            {
                tb_Resultados_PersonasMeses.Text = "Riesgo de fracaso";
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        //

        //



        //



        //

    }
}