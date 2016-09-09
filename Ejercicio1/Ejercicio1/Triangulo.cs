using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Triangulo : Geometria
    {
        private float lado1;
        private float lado2;
        private float lado3;
        private float base1;
        private float altura1;


        public Triangulo(float d_base, float d_altura, float d_lado1, float d_lado2, float d_lado3)
        {
            this.base1 = d_base;
            this.altura1 = d_altura;
            this.lado1 = d_lado1;
            this.lado2 = d_lado2;
            this.lado3 = d_lado3;


        }


        public double calcularArea()
        {
            return (base1 * altura1) / 2;
        }

        public double calcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

    }
}
