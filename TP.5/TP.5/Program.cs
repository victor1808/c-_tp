using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP._5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Materia> materias = new List<Materia>();

            Materia materia1 = new Materia("Programacion I", 2014, 1);
            materia1.addNota(new Nota(6, Nota.tipos.ESCRITO.ToString()));
            materia1.addNota(new Nota(6, Nota.tipos.ESCRITO.ToString()));
            Materia materia11 = new Materia("Organización empresarial", 2014, 1);
            materia11.addNota(new Nota(6, Nota.tipos.ESCRITO.ToString()));
            materia11.addNota(new Nota(6, Nota.tipos.TP.ToString()));

            Materia materia2 = new Materia("Programación II", 2014, 2);
            materia2.addNota(new Nota(2, Nota.tipos.ESCRITO.ToString()));
            materia2.addNota(new Nota(6, Nota.tipos.ESCRITO.ToString()));

            Materia materia3 = new Materia("Base de Datos", 2015, 3);
            materia3.addNota(new Nota(7, Nota.tipos.TP.ToString()));
            materia3.addNota(new Nota(7, Nota.tipos.TP.ToString()));

            Materia materia4 = new Materia("Taller de Computacion IV", 2015, 4);
            materia4.addNota(new Nota(3, Nota.tipos.ESCRITO.ToString()));
            materia4.addNota(new Nota(9, Nota.tipos.TP.ToString()));

            Materia materia5 = new Materia("Calidad de software", 2016, 5);
            materia5.addNota(new Nota(9, Nota.tipos.ESCRITO.ToString()));
            materia5.addNota(new Nota(9, Nota.tipos.ESCRITO.ToString()));

            materias.Add(materia1);
            materias.Add(materia11);
            materias.Add(materia2);
            materias.Add(materia3);
            materias.Add(materia4);
            materias.Add(materia5);



            // CONSULTA : PARA OBTENER TODAS LAS MATERIAS DEL PRIMER CUATRIMESTRE
            /*

          var cuatrimestre =
                              from l in materias
                              where l.cuatrimestre == 1
                              select l;

          foreach (var pers in cuatrimestre)
          {
              Console.WriteLine("Materias: " + pers.nombre + "  " + "Cuatrimestre: " + pers.cuatrimestre);
          }
          Console.ReadKey();


          */
            //---------------------------------------------------------------------------------------------------------------







            // CONSULTA : PARA ORDENAR TODAS LOS NOMBRES DE LAS MATERIAS ALFABETICAMENTE
            /*
                              var ordenar_alfa =
                                from l in materias
                                orderby l.nombre ascending
                                select l;
                              foreach (var pers in ordenar_alfa)
                              {
                                  Console.WriteLine("Materias: " + pers.nombre);
                              }
                              Console.ReadKey();

                  */


            //---------------------------------------------------------------------------------------------







            // CONSULTA: PARA OBETENER LAS NOTAS TIPO TP

          /*  
            var lista3 = materias.SelectMany(n => n.notas).Where(n => n.tipo == Nota.tipos.TP.ToString()).ToList();



            foreach (var pers in lista3)
            {
                Console.WriteLine("Materias: " + pers.tipo + " " + pers.numero);
            }
            Console.ReadKey();

            Console.ReadKey();
            */






            //--------------------------------------------------------------------------------------


            // Consulta: Metodo de extension promedio


            
            
                       var lista4 = materias;
                       var resultado4 = lista4.GroupBy(m => m.cuatrimestre).Select(i => new
                       {
                           Cuatrimestre = i.Key,
                           Promedio = i.SelectMany(m => m.notas).Where(n => n.tipo != "TP").Average(n => n.numero)
                       });

                       foreach (var item in resultado4)
                       {
                           Console.WriteLine(" " +  item.Promedio + " ");


                       }

               






        }
    }
}
