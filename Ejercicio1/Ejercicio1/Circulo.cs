using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Circulo : Geometria
    {
        public double radio_r;




        public Circulo(double radio)
        {
            this.radio_r = radio;

        }



        public double calcularArea()
        {
            return Math.PI * radio_r * radio_r;
        }

        public double calcularPerimetro()
        {
            return 2 * radio_r * Math.PI;
        }
    }
}
