using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_circular
{
    public class NodoCircular
    {
        public int Valor;
        public NodoCircular Siguiente;

        public NodoCircular(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
