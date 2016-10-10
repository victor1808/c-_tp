using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP._5
{
    class Materia
    {

        public String nombre { get; }
        public int año { get; }
        public int cuatrimestre { get; }
        public List<Nota> notas { get; }

        public Materia(String p_nombre, int p_año, int p_cuatrimestre)
        {
            nombre = p_nombre;
            año = p_año;
            cuatrimestre = p_cuatrimestre;
            notas = new List<Nota>();
        }

        public void addNota(Nota nota)
        {
            notas.Add(nota);
        }
    }
}
