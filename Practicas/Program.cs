using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas;

namespace Practics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre");
            string name = Console.ReadLine();

            Console.WriteLine($"ola, {name}\n");
            Console.WriteLine("A continuacion verás el problema que elegiste\n");
            Console.WriteLine("=============================================");

            Semana3 Sem3 = new Semana3();

            Sem3.Apretones();

            Console.WriteLine(" \n"
                + "=============================================\n" 
                + " \n");

            Semana4 Sem4 = new Semana4();

            Sem4.Biblioteca();
        }
    }
}