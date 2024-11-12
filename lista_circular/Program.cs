using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_circular
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Lista Circular:");

            // Crear instancia de la lista circular
            ListaCircular listaCircular = new ListaCircular();

            // Agregar elementos
            listaCircular.Agregar(10);
            listaCircular.Agregar(20);
            listaCircular.Agregar(30);
            Console.WriteLine("Después de agregar 10, 20, 30:");
            listaCircular.Imprimir();

            // Buscar un elemento existente
            Console.WriteLine("\nBuscar 20:");
            Console.WriteLine(listaCircular.Buscar(20) ? "20 encontrado" : "20 no encontrado");

            // Modificar un elemento existente
            Console.WriteLine("\nModificar 20 a 25:");
            listaCircular.Modificar(20, 25);
            listaCircular.Imprimir();

            // Eliminar un elemento
            Console.WriteLine("\nEliminar 25:");
            listaCircular.Eliminar(25);
            listaCircular.Imprimir();

            // Intentar buscar un elemento que no está en la lista
            Console.WriteLine("\nBuscar 40:");
            Console.WriteLine(listaCircular.Buscar(40) ? "40 encontrado" : "40 no encontrado");

            Console.ReadKey();
        }
    }
}
