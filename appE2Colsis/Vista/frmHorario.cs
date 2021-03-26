using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appE2Colsis.Datos;
namespace appE2Colsis.Vista
{
    public partial class frmHorario : Form
    {
        public frmHorario()
        {
            InitializeComponent();
        }
        clHorario objHorario = new clHorario();
        List<clHorario> listaFiltro = new List<clHorario>(); // lista de filtro
        string[] dias = new string[7];
        private void frmHorario_Load(object sender, EventArgs e)
        {
           
            dias[0] = "Domingo";
            dias[1] = "Lunes";
            dias[2] = "Martes";
            dias[3] = "Miercoles";
            dias[4] = "Jueves";
            dias[5] = "Viernes";
            dias[6] = "Sabado";

            cmbDia.DataSource = dias;

            List<clHorario> lista = new List<clHorario>();
            lista = objHorario.mtdConsultarCursos();
            cmbCurso.DataSource = lista;
            cmbCurso.DisplayMember = "nombreCurso";
            cmbCurso.ValueMember = "idCurso";
            cmbCursoFiltrar.DataSource = lista;
            cmbCursoFiltrar.DisplayMember = "nombreCurso";
            cmbCursoFiltrar.ValueMember = "idCurso";


            //Agregar Horas al Grid
            for (int i = 0; i <= 11; i++)
            {
                dgvResultado.Rows.Add();
                string hora = (i + 6).ToString() + " - "+ (i + 7).ToString();
                dgvResultado.Rows[i].Cells[0].Value = hora;

                

            }


            



        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
                List<clHorario> listaAsignaturas = new List<clHorario>();
                listaAsignaturas = objHorario.mtdConsultarAsignaturasSegunCurso();
                cmbAsignatura.DataSource = listaAsignaturas;
                cmbAsignatura.DisplayMember = "nombreAsignatura";
                cmbAsignatura.ValueMember = "idAsignatura";

            }
            catch (Exception)
            {

              
            }
            
        }

        private void cmbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objHorario.idCurso = int.Parse(cmbCurso.SelectedValue.ToString());
            objHorario.idAsignatura = int.Parse(cmbAsignatura.SelectedValue.ToString());
            objHorario.dia = cmbDia.Text;
            objHorario.horaIncio = txthInicio.Text;
            objHorario.horaFinal = txthFinal.Text;
           int rows = objHorario.mtdInsertarHorario();
            if (rows>0)
            {
                MessageBox.Show("Se realizo registro Exitoso", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbCursoFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objHorario.idCurso = int.Parse(cmbCursoFiltrar.SelectedValue.ToString());
                listaFiltro.Clear();
                listaFiltro = objHorario.mtdFiltarHorariosCurso();
                string dia = ""; string hI = ""; string hF = "";
                string[] horario = new string[] {"07","08","09","10","11","12","13","14","15","16","17","18" }; //llenar vector
                



                int posicionfila = -1;
                int posicionColumna=-1;

                for (int i = 0; i < listaFiltro.Count; i++)
                {
                    dia = listaFiltro[i].dia;
                    hI = listaFiltro[i].horaIncio;
                    hI = hI.Substring(0, 2);
                    for (int j = 0; j <= 11; j++)
                    {
                        if (hI==horario[j])
                        {
                            posicionfila = j ;
                            

                        }

                    }
                    for (int z = 0; z <7 ; z++)
                    {
                        if (listaFiltro[i].dia==dias[z])
                        {
                            posicionColumna = z;
                        }

                    }
                    dgvResultado.Rows[posicionfila+1].Cells[posicionColumna].Value = listaFiltro[i].nombreAsignatura;
            



                }



            }
            catch (Exception error )
            {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}
