using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Vehiculo
    {

        public HashSet<Rueda> listaruedas
        {
            get
            {
                return this.listaruedas;
            }
            set
            {
                if (value.Count < 5)
                {
                    this.listaruedas = value;
                }
            }
        }
        public Motor motor { get; set; }
        public Caja caja { get; set; }

        public Vehiculo(HashSet<Rueda> rueda_c, Motor motor_c, Caja caja_C)
        {
            if (rueda_c.Count < 5)
            {

                this.listaruedas = rueda_c;
            }
            this.motor = motor_c;
            this.caja = caja_C;
        }
    }
}
