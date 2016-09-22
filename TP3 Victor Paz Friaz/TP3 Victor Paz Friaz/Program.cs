using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Victor_Paz_Friaz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Materia n = new Materia();
            //  List‹string› materias = new List ‹string›();

            List<Materia> materias = new List<Materia>
            {
            new Materia(){nombre="Computacion Avanzada", profesor = "Almiñana, Gabriel", dia = 566 , horario = 486 },
            new Materia(){nombre="Computacion Avanzada", profesor = "Almiñana, Gabriel", dia = 566 , horario = 486 },
            new Materia(){nombre="Computacion Avanzada", profesor = "Almiñana, Gabriel", dia = 566 , horario = 486 },
            new Materia(){nombre="Computacion Avanzada", profesor = "Almiñana, Gabriel", dia = 566 , horario = 486 },
           };


            Dictionary<int, Materia> año_materias = new Dictionary<int, Materia>()
    {
        { 2016, new Materia {nombre ="Computacion Avanzada , Taller de Computación VI" }},
        { 2015, new Materia {nombre ="Taller de Computación V , Simulacion " } }
      
    };
          // Recorro la lista materias .
            foreach (Materia m in materias)
            {
                Console.WriteLine(m.nombre + " "  + m.profesor + " " + m.dia  +   " "  + m.horario + " ");
              

            }

            // Recorro el diccionario año_materias
            foreach (KeyValuePair<int, Materia> resultado in año_materias)
            {
                Console.WriteLine("Año: " + resultado.Key + "--- Materias:  " + resultado.Value.nombre );
            }
            Console.ReadKey();
        }
    }
}



/*
              List<Materia> nombre_m = new List<Materia>
              {
              new Materia(){nombre = "pepe " },
              new Materia(){nombre = "pepe " ,},
              new Materia(){nombre = "pepe " , } 
             };


              Dictionary<int,List<Materia>> p = new Dictionary<int, List<Materia>>();
              Materia nn = new Materia();
              p.Add(123312, nn.nombre);
              */
