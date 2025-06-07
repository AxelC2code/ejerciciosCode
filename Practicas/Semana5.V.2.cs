using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Semana5V2
    {
        public void ControlAsistencia()
        {
            /*Registrar el nombre de alumno y si asistió o no, contar el total de asistentes y
            porcentaje de asistencias.*/

            string nombre = "";
            int contador = 0, positivo = 0, negativo = 0;
            char op = 'S';

            do
            {
                Console.WriteLine("ingrese el nombre del alumno y escribir fin cuando termine");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre)); // validar que no sea vacio

            while (nombre.ToLower() != "fin")
            {
                contador++;
                Console.WriteLine("ingreso exitoso");

                do
                {
                    Console.WriteLine("el alumno asitio a clases? S/N");
                    op = Console.ReadKey().KeyChar;
                    op = char.ToLower(op);

                    Console.WriteLine();

                    if (op == 's' || op == 'n') break;

                    Console.WriteLine("incorrecto, ingresa S/N");

                } while (true);

                if (op == 's')
                {
                    positivo++;
                    Console.WriteLine($"el alumno asistio");
                }
                else if (op == 'n')
                {
                    negativo++;
                    Console.WriteLine($"el alumno  no asitio");
                }

                Console.WriteLine("ingrese el siguiente alumno");
                nombre = Console.ReadLine().ToString();
            }
            double porcentaje = positivo / (double)contador * 100;
            Console.WriteLine($"el total de alumnos registrados es: {contador}\n" +
                              $"el total de asistentes es {positivo}\n" +
                              $"el total de faltas es {negativo} \n" +
                              $"el porcentaje de asitencias fue de {porcentaje}%");
        }

        public void ControlRendimientoVelocidad()
        {
            /*Registrar el nombre, tiempo y distancia recorrida por un deportista, identificar cual
            fue el deportista mas rápido, y cual es el deportista con mejor rendimiento.*/

            string nombre = "";
            string final;
            int tiempo = 0, distancia = 0;
            int menorTiempo = 0;
            string mejorDeportista = "";
            double mejorRendimiento = 0, rendimiento;
            bool valdatos = false;

            do
            {
                Console.WriteLine("ingrese el nombre del deportista y escribir fin cuando termine");
                nombre = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nombre)); { Console.WriteLine("ingrese un nombre valido"); }
            do
            {
                Console.WriteLine("ingrese el tiempo registrado por el deportista");
                valdatos = int.TryParse(Console.ReadLine(), out tiempo);
            } while (!valdatos || tiempo < 1); { Console.WriteLine("ingresar un tiempo valido"); }
            do
            {
                Console.WriteLine("ingrese la distancia registrada por el deportista");
                valdatos = int.TryParse(Console.ReadLine(), out distancia);
            } while (!valdatos || distancia < 1); { Console.WriteLine("ingresar una distancia valida"); }

            while (nombre != "fin")
            {
                if (tiempo < menorTiempo)
                {
                    menorTiempo = tiempo;
                    mejorDeportista = nombre;
                }
                rendimiento = distancia / tiempo;
                if (rendimiento < mejorRendimiento)
                {
                    mejorRendimiento = rendimiento;
                }
            }
            Console.WriteLine($"nombre {mejorDeportista} y tiempo {menorTiempo}");
            Console.WriteLine($"rendimiento {mejorRendimiento}");
        }

        public void SalariosEmpleados()
        {
            /*Registrar el nombre, cargo y salario de un empleado, y mostrar el nombre, cargo,
            salario del empleado peor pagado, así como identificar cual es el sueldo
            promedio.*/

        }
    }
}
