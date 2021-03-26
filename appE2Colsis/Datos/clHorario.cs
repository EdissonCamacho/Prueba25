using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE2Colsis.Datos
{
    class clHorario
    {
        public int idAsignatura { get; set; }
        public int idCurso { get; set; }

        public string nombreAsignatura { get; set; }
        public string  nombreCurso { get; set; }
        public int idAsignaturaCurso { get; set; }

        public string dia { get; set; }

        public string horaIncio { get; set; }
        public string horaFinal { get; set; }

        clConexion objConexion = new clConexion();
       /* public List<clHorario> mtdConsultaAsignaturaCurso()
        {
            string consulta = "select curso.idCurso,curso.nombreCurso,asignatura.idAsignatura,asignatura.nombreAsignatura from asignaturacurso inner join curso on asignaturacurso.idCurso = curso.idCurso inner join asignatura on asignaturacurso.idAsignatura = asignatura.idAsignatura inner join personal on asignaturacurso.idDocente = personal.idPersonal";
            DataTable resultado = new DataTable();
          resultado=  objConexion.mtdDesconectado(consulta);
            List<clHorario> listaHorario = new List<clHorario>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clHorario objAdd = new clHorario();
                objAdd.idCurso = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreCurso = resultado.Rows[i][1].ToString();
                objAdd.idAsignatura = int.Parse(resultado.Rows[i][2].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][3].ToString();
                listaHorario.Add(objAdd);
            }

            return listaHorario;
        }*/


        public List<clHorario> mtdConsultarCursos()
        {
            string consulta = "select idCurso,nombreCurso from curso";
            DataTable resultado = new DataTable();
            resultado = objConexion.mtdDesconectado(consulta);
            List<clHorario> lista = new List<clHorario>();

            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clHorario objAdd = new clHorario();
                objAdd.idCurso = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreCurso = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);

            }
            return lista;

        }

        public List<clHorario> mtdConsultarAsignaturasSegunCurso()
        {
            string consulta = "select  asignatura.idAsignatura,asignatura.nombreAsignatura from asignaturacurso inner join asignatura on asignaturacurso.idAsignatura=asignatura.idAsignatura where asignaturacurso.idCurso=" + idCurso + "";
            DataTable resultado = new DataTable();
            resultado =objConexion.mtdDesconectado(consulta);
            List<clHorario> lista = new List<clHorario>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clHorario objAdd = new clHorario();
                objAdd.idAsignatura = int.Parse(resultado.Rows[i][0].ToString());
                objAdd.nombreAsignatura = resultado.Rows[i][1].ToString();
                lista.Add(objAdd);
            }
            return lista;
        }

        public void mtdConsultarIdAsignaturaCurso()
        {
            string consulta = "select idAsignaturaCurso from asignaturacurso where idCurso=" + idCurso + " and idAsignatura=" + idAsignatura + "";
            DataTable resultado = new DataTable();
           resultado= objConexion.mtdDesconectado(consulta);
            idAsignaturaCurso = int.Parse(resultado.Rows[0][0].ToString());


        }

        public int  mtdInsertarHorario()
        {
            mtdConsultarIdAsignaturaCurso();
            string consulta = "insert into horario(dia, horaInicio, horaFinal, idAsignaturacurso) values('"+dia+"', '"+horaIncio+"', '"+horaFinal+"',"+idAsignaturaCurso+" )";
          int rows=  objConexion.mtdConectado(consulta);
            return rows;


        }

        public List<clHorario> mtdFiltarHorariosCurso()
        {
            string consulta = "select horario.dia,asignatura.nombreAsignatura,horario.horaInicio,horario.horaFinal from  \n " +
                "horario inner join asignaturacurso on horario.idAsignaturaCurso = asignaturacurso.idAsignaturacurso inner join asignatura on asignatura.idAsignatura = asignaturacurso.idAsignatura \n" +
                " inner join curso on asignaturacurso.idCurso = curso.idCurso where curso.idCurso =" + idCurso + "";
            DataTable resultado = new DataTable();
          resultado=  objConexion.mtdDesconectado(consulta);
            List<clHorario> lista = new List<clHorario>();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                clHorario objAdd = new clHorario();
                objAdd.dia = resultado.Rows[i][0].ToString();
                objAdd.nombreAsignatura = resultado.Rows[i][1].ToString();
                objAdd.horaIncio = resultado.Rows[i][2].ToString();
                objAdd.horaFinal = resultado.Rows[i][3].ToString();

                lista.Add(objAdd);




            }
            return lista;



        }
    }
}
