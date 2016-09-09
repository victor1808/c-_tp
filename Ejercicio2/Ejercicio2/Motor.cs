using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Motor : Interface
    {
        public void frenar()
        {
            Console.WriteLine("Frenar...");
        }

        public void iniciar()
        {
            Console.WriteLine("Iniciar...");
        }

        public float cilindrada { get; set; }

   
    }
}
