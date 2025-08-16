using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class clsExamenT4
    {
        static string[] equipo = new string[5];
        static int[] puntos = new int[5];
        public void Principal()
        {
            //intercambiar puesto del primero al ultimo
            //determinar quien es el equipo lider
            //mostrar equipos con puntajes pares y mostrar cuales son

            ObtenerDatos();
            Console.WriteLine("-- DATOS DE EQUIPOS --");
            MostrarDatos();

            IntercambiarDatos();
            Console.WriteLine("Datos intercambiados a continuacion:");
            MostrarDatos();

            //muestra el equipo lider
            EquipoLider();

            //contar y mostrar equipos con puntos pares
            EquPuntosPares();

        }

        private void ObtenerDatos()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"ingresar el puntaje del equipo N{i+1}°");
                while (!int.TryParse(Console.ReadLine(), out puntos[i]) || puntos[i] < 0)
                {
                    Console.WriteLine("Puntaje inválido. Por favor, ingrese un número entero positivo.");
                }
                Console.WriteLine($"ingresar el nombre del equipo N{i+1}°");
                while (string.IsNullOrWhiteSpace(equipo[i]))
                {
                    equipo[i] = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(equipo[i]))
                    {
                        Console.WriteLine("Nombre de equipo inválido. Por favor, ingrese un nombre válido.");
                    }
                }
            }   
        }

        private void MostrarDatos()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Equipo             | Puntos    |");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"| {equipo[i],-18} | {puntos[i],-9} |");
            }
            Console.WriteLine("----------------------------------");
        }

        private void IntercambiarDatos()
        {
            int tmpPuntos = 0;

            tmpPuntos = puntos[0];
            puntos[0] = puntos[4];
            puntos[4] = tmpPuntos;

            string tmpEquipo = "";

            tmpEquipo = equipo[0];
            equipo[0] = equipo[4];
            equipo[4] = tmpEquipo;
        }

        private void EquipoLider()
        {
            int tmpMayor = 0;
            for (int i = 1; i < puntos.Length; i++)
            {
                if (puntos[i] > puntos[tmpMayor])
                {
                    tmpMayor = i;
                }
            }

            Console.WriteLine($"El equipo lider es: {equipo[tmpMayor]} con {puntos[tmpMayor]} puntos");
        }

        private void EquPuntosPares()
        {
            int ContPar = 0;
            for(int i = 0; i < puntos.Length; i++)
            {
                if (puntos[i] % 2 == 0)
                {
                    ContPar ++;
                    Console.WriteLine($"El equipo: {equipo[i]} con {puntos[i]} es par");
                }
            }
            if (ContPar == 0)
            {
                Console.WriteLine("No se encontraron equipos con puntajes pares.");
            }
            else
            {
                Console.WriteLine($"Total de equipos con puntajes pares: {ContPar}");
            }
        }
    }
}
