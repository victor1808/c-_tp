using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Cuadrado: Geometria
    {

        private float lado;


        //Constructor
        public Cuadrado(float p_lado)
        {
            this.lado = p_lado;
        }

        public double calcularArea()
        {
            return lado * lado;
        }

        public double calcularPerimetro()
        {
            return lado * 4;
        }
    }
}
