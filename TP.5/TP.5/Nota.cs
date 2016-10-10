using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP._5
{
    class Nota
    {
        public int numero { get; }
        public String tipo { get; }

        public enum tipos
        {
            TP,
            ESCRITO
        }

        public Nota(int p_numero, String p_tipo)
        {
            numero = p_numero;
            tipo = p_tipo;
        }

    }
}
