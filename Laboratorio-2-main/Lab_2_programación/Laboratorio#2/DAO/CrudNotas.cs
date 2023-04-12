using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_2.Models;

namespace Laboratorio_2.DAO
{
    public class CrudNota
    {
        public void AgregarNota(Nota ParametroNota)
        {
            using (NotaEstudianteContext db = new NotaEstudianteContext())
            {
                Nota Nota = new Nota();
                Nota.Materia = ParametroNota.Materia;
                Nota.NombreEstudiante = ParametroNota.NombreEstudiante;
                Nota.Laboratorio_1 = ParametroNota.Laboratorio_1;
                Nota.Parcial_1 = ParametroNota.Parcial_1;
                Nota.Laboratoio_2= ParametroNota.Laboratorio_2;
                Nota.Parcial_2 = ParametroNota.Parcial_2;
                Nota.Laboratorio_3= ParametroNota.Laboratorio_3;
                Nota.Parcial_3 = ParametroNota.Parcial_3;
                Nota.Resultado= ParametroNota.Resultado;
                db.Add(Nota);
                db.SaveChanges();

            }
        }

        public Nota NotaIndividual(int id)
        {
            using (NotaEstudianteContext db = new NotaEstudianteContext())
            {
                var buscar = db.Notas.FirstOrDefault(x => x.IdNotas == Id);
                return buscar;
            }
        }

        public List<Nota> ListarNotas()
        {
            using (NotaEstudianteContext db = new NotaEstudianteContext())
            { return db.Notas.ToList(); }
        }

        public void CalcularResultado(Nota notas)
        {

            var Periodo1 = (notas.Laboratorio_1 * Convert.ToDecimal(0.4)) + (notas.Parcial_1 * Convert.ToDecimal(0.6));
            var Periodo2 = (notas.Laboratorio_2 * Convert.ToDecimal(0.4)) + (notas.Parcial_2 * Convert.ToDecimal(0.6));
            var Periodo3 = (notas.Laboratorio_3 * Convert.ToDecimal(0.4)) + (notas.Parcial_3 * Convert.ToDecimal(0.6));

            notas.Resultado = (Periodo_1 + Periodo_2 + Periodo_3) / 3;

        }

    }
}
