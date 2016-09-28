using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<Materia>> materias = new Dictionary<int, List<Materia>>();
            List<Materia> materias2015 = new List<Materia>();     
            List<Materia> materias2016 = new List<Materia>();
            //2015
            materias2015.Add(new Materia() { nombre = "Simulación", profesor = "Francisco Montero", dia = "Miercoles", horario = "20:30 a 22:45" });
            materias2015.Add(new Materia() { nombre = "Taller de computación IV ", profesor = "Flavio Garrido", dia = "Miercoles", horario = "18:45 a 20:30" });
            materias2015.Add(new Materia() { nombre = "Redes y sistemas operativos distribuidos", profesor = "Misael Cudeck", dia = "Lunes", horario = "19:00 a 22:45" });

            //2016
            materias2016.Add(new Materia() { nombre = "Taller de Computacion VI", profesor = "Gabriel Almiñana", dia = "Lunes", horario = "18:45 a 20:30" });
            materias2016.Add(new Materia() { nombre = "Seminario de Sistemas", profesor = "Pablo Romanos", dia = "Miercoles", horario = "18:45 a 22:45" });
            materias2016.Add(new Materia() { nombre = "Seminario de Tecnologia", profesor = "Misael Cudeck", dia = "Lunes", horario = "20:30 a 22:45" });
            materias.Add(2015, materias2015);
            materias.Add(2016, materias2016);

            foreach (var item in materias)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2.nombre + " " + item2.nombre + "" + item2.profesor);
                }
            }

            Console.ReadKey();


        }
    }
}
