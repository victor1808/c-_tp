using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Operaciones op = new Operaciones();
             Console.WriteLine("ingrese 2 numeros");
             float numero1 = float.Parse(Console.ReadLine());
             float numero2 = float.Parse(Console.ReadLine());
             float resultado = op.Dividir(numero1, numero2);
             Console.WriteLine($"El resultado es : {resultado}");
             Console.ReadKey();
             */

            /*
              Console.WriteLine("ingrese 2 numeros");
              float ladoc = float.Parse(Console.ReadLine());
              Cuadrado c = new Cuadrado(ladoc);
              float resultado = c.calcularPerimetro();
              Console.WriteLine($"El resultado es : {resultado}");
              Console.ReadKey();

      */

            /*     Console.WriteLine("ingrese numeros");
                 float basee = float.Parse(Console.ReadLine());
                 float altura = float.Parse(Console.ReadLine());
                 float lado1 = float.Parse(Console.ReadLine());
                 float lado2 = float.Parse(Console.ReadLine());
                 float lado3 = float.Parse(Console.ReadLine());

                 Triangulo t = new Triangulo(basee,altura,lado1,lado2,lado3);
                 double resultado = t.calcularArea();
                 Console.WriteLine($"El resultado es : {resultado}");
                 Console.ReadKey();

                 */
            Console.WriteLine("ingrese radio ");
            double radio = double.Parse(Console.ReadLine());
            Circulo c = new Circulo(radio);
            double resultado = c.calcularArea();
            Console.WriteLine($"El resultado es : {resultado}");
            Console.ReadKey();

        }
    }
}
