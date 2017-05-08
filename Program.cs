using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
      

            string nombre, apellido;

            Console.WriteLine("Ingrese Nombre");
            
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido");
            apellido = Console.ReadLine();
            
           
            
            Console.WriteLine("Su Nombre Compelto es: " + nombre + apellido);

            Console.ReadLine();

        }
    }
}
