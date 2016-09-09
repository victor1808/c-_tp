using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Caja
    {
        public enum Tipocaja { Automatica, Manual }

        public int cantidad_cambios { get; set; }

        public Tipocaja tipo
        {
            get; set;
        }

    }
}
