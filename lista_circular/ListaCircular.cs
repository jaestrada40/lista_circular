using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_circular
{
    public class ListaCircular
    {
        private NodoCircular cabeza;

        public ListaCircular()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            NodoCircular nuevo = new NodoCircular(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Siguiente = cabeza;
            }
            else
            {
                NodoCircular actual = cabeza;
                while (actual.Siguiente != cabeza)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Siguiente = cabeza;
            }
        }

        public void Eliminar(int valor)
        {
            if (cabeza == null) return;

            NodoCircular actual = cabeza;
            NodoCircular anterior = null;
            do
            {
                if (actual.Valor == valor)
                {
                    if (anterior != null)
                    {
                        anterior.Siguiente = actual.Siguiente;
                        if (actual == cabeza) cabeza = actual.Siguiente;
                    }
                    else
                    {
                        NodoCircular ultimo = cabeza;
                        while (ultimo.Siguiente != cabeza)
                        {
                            ultimo = ultimo.Siguiente;
                        }
                        cabeza = cabeza.Siguiente;
                        ultimo.Siguiente = cabeza;
                    }
                    break;
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != cabeza);
        }

        public bool Buscar(int valor)
        {
            if (cabeza == null) return false;

            NodoCircular actual = cabeza;
            do
            {
                if (actual.Valor == valor) return true;
                actual = actual.Siguiente;
            } while (actual != cabeza);
            return false;
        }

        public void Modificar(int valorAntiguo, int valorNuevo)
        {
            if (cabeza == null) return;

            NodoCircular actual = cabeza;
            do
            {
                if (actual.Valor == valorAntiguo)
                {
                    actual.Valor = valorNuevo;
                    break;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);
        }

        public void Imprimir()
        {
            if (cabeza == null) return;

            NodoCircular actual = cabeza;
            do
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            } while (actual != cabeza);
            Console.WriteLine();
        }
    }
}
