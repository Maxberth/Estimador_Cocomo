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

            double EF_familiaridad = TryParseOrDefault(tb_EF_familiaridad.Text)*1.5;
            double EF_experienciaAPP = TryParseOrDefault(tb_EF_experienciaApp.Text)*0.5;
            double EF_estabilidadRequisitos = TryParseOrDefault(tb_EF_estabilidadRequisitos.Text)*1;
            double EF_experienciaLenguaje = TryParseOrDefault(tb_EF_experienciaLenguaje.Text)*0.5;
            double EF_herramientasSoporte = TryParseOrDefault(tb_EF_herramientasSoporte.Text)*1;
            double EF_motivacionEquipo = TryParseOrDefault(tb_EF_motivacionEquipacion.Text)*2;
            double EF_restriccionesTiempo= TryParseOrDefault(tb_EF_restriccionesTiempo.Text)*-1;
            double EF_restriccionesRecursos = TryParseOrDefault(tb_EF_restriccionesRecursos.Text)*-1;


            double EF = 1.4+(-0.03*(EF_familiaridad + EF_experienciaAPP + EF_estabilidadRequisitos + EF_experienciaLenguaje + EF_herramientasSoporte + EF_motivacionEquipo + EF_restriccionesTiempo + EF_restriccionesRecursos));
            tb_Resultados_TCF.Text = Math.Round(EF, 2).ToString("F2");



            double TCF_SistemaDistribuido = TryParseOrDefault(tb_TCF_sistemaDistribuido.Text) * 2;
            double TCF_TiempoRespuesta = TryParseOrDefault(tb_TCF_tiempoRespuesta.Text) * 2;
            double TCF_EficienciaUsuario= TryParseOrDefault(tb_TCF_eficienciaUsuario.Text) *1 ;
            double TCF_ComplejidadProceso= TryParseOrDefault(tb_TCF_complejidadProceso.Text) *1 ;
            double TCF_Reusabilidad= TryParseOrDefault(tb_TCF_reusabilidad.Text) * 1;
            double TCF_FacilidadInstalacion= TryParseOrDefault(tb_TCF_facilidadInstalacion.Text) *0.5 ;
            double TCF_FacilidadUso= TryParseOrDefault(tb_TCF_facilidadUso.Text) * 0.5;
            double TCF_Portabilidad= TryParseOrDefault(tb_TCF_portabilidad.Text) * 2;
            double TCF_FacilidadCambio= TryParseOrDefault(tb_TCF_facilidadCambio.Text) *2 ;
            double TCF_UsoSimultaneo= TryParseOrDefault(tb_TCF_usoSimultaneo.Text) *1 ;
            double TCF_CaracteristicasSeguridad= TryParseOrDefault(tb_TCF_caracteristicasSeguridad.Text) *1 ;
            double TCF_AccesoTercerasPartes= TryParseOrDefault(tb_TCF_accesoDirecto.Text) * 1;
            double TCF_CapacidadesEntrenamiento= TryParseOrDefault(tb_TCF_capacidadEntrenamiento.Text) * 1;

            double TCF = 0.6 + (0.01 * (TCF_SistemaDistribuido + TCF_TiempoRespuesta + TCF_EficienciaUsuario + TCF_ComplejidadProceso + TCF_Reusabilidad + TCF_FacilidadInstalacion + TCF_FacilidadUso + TCF_Portabilidad + TCF_FacilidadCambio + TCF_UsoSimultaneo + TCF_CaracteristicasSeguridad + TCF_AccesoTercerasPartes + TCF_CapacidadesEntrenamiento));
            tb_Resultados_EF.Text = Math.Round(TCF, 2).ToString("F2");



            double UCP = UUCP * TCF * EF;
            tb_Resultados_UCP.Text = Math.Round(UCP, 2).ToString("F2");

            double EsfuerzoDesarrollo = 36 * UCP;
            tb_Resultados_PersonasMeses.Text = Math.Round(EsfuerzoDesarrollo, 2).ToString("F2");




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