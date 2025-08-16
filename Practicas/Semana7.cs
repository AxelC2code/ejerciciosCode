using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Semana7
    {
        public static void Sueldo()
        {
            /*
            Diseña un algoritmo en PSeInt que calcule el sueldo semanal de N trabajadores, teniendo
            en cuenta las siguientes condiciones de descuento:
                • Se debe descontar un 5% del sueldo si el sueldo semanal es de hasta S/. 1500.
                • Se debe descontar un 7% del sueldo si el sueldo semanal es mayor que S/. 1500 pero menor o igual a S/. 3000.
                • Se debe descontar un 9% del sueldo si el sueldo semanal es mayor que S/. 3000 pero menor o igual a S/. 4500.
                • Se debe descontar un 10% del sueldo si el sueldo semanal es mayor que S/. 4500.
            El algoritmo debe de tener la siguiente información para cada trabajador (considerar el uso de
            aleatorios):
                • Horas trabajadas por semana.
                • Sueldo por hora.
            Considere adicionalmente el pago de la compañía al seguro social de 8% si el sueldo del
            trabajador está por encima de s/. 2300
            El algoritmo debe de calcular el descuento total y el gasto total de la compañía por toda la
            planilla.*/
            int SueldoBruto = 0;
            int HorasTrabajadas = 0, PagoHora = 0;
            int NumeroDeTrabajadores = 0;
            double descuentos = 0, gastoTotal = 0;
            principal();

            void principal()
            {
                double seguroSocialTotal = 0;
                double dsctTotal = 0;
                PedirCantidadTrabajadores();
                for (int i = 1; i <= NumeroDeTrabajadores; i++)
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"Datos del trabajador N°: {i}");
                    CalcularSueldoBruto();
                    descuentos = CalcularDescuento(SueldoBruto);
                    gastoTotal = CalcularGastoSeguro(SueldoBruto);
                    dsctTotal = +descuentos;
                    seguroSocialTotal = + gastoTotal;
                }
                Console.WriteLine("**********************************************************");
                Console.WriteLine($"su descuento total es de {dsctTotal} soles");
                Console.WriteLine($"su gasto total por seguro social es de {seguroSocialTotal} soles");
                
            }

            void PedirCantidadTrabajadores()
            {
                Console.WriteLine("Ingresa el numero de trabajadores");
                while (!int.TryParse(Console.ReadLine(), out NumeroDeTrabajadores) || NumeroDeTrabajadores <= 0)
                    Console.WriteLine("Ingresar un numero de trabajadores valido");
            }

            int CalcularSueldoBruto()
            {
                Random random = new Random();

                HorasTrabajadas = random.Next(30, 40);
                Console.WriteLine($"El numero de horas trabajadas son {HorasTrabajadas}");
                PagoHora = random.Next(35, 125);
                Console.WriteLine($"El pago por hora es de {PagoHora}");

                SueldoBruto = HorasTrabajadas * PagoHora;
                Console.WriteLine($"{SueldoBruto}");
                return SueldoBruto;
            }

            double CalcularDescuento(int SueldoBruto)
            {
                double dsct = 0;
                
                if (SueldoBruto <= 1500)
                {
                    Console.WriteLine("Se le descontará 5%");
                    dsct = SueldoBruto * 0.05;
                    Console.WriteLine($"descuento de {dsct}");
                    return dsct;
                }
                else if (SueldoBruto <= 3000)
                {
                    Console.WriteLine("Se le descontará 7%");
                    dsct = SueldoBruto * 0.07;
                    Console.WriteLine($"descuento de {dsct}");
                    
                    return dsct;
                }
                else if (SueldoBruto <= 4500)
                {
                    Console.WriteLine("Se le descontará 9%");
                    dsct = SueldoBruto * 0.09;
                    Console.WriteLine($"descuento de {dsct}");
                    
                    return dsct;
                }
                else
                {
                    Console.WriteLine("El sueldo es mayor a 4500, se descuenta el 10%");
                    dsct = SueldoBruto * 0.10;
                    Console.WriteLine($"descuento de {dsct}");
                    
                    return dsct;
                }
            }
            double CalcularGastoSeguro(int sueldoBruto)
            {
                double seguroSocial = 0;
                if (SueldoBruto > 2300)
                {
                    Console.WriteLine("su sueldo superá los 2300");
                    seguroSocial = SueldoBruto * 0.08;
                }
                return seguroSocial;
            }
        }

        public static void segundo()
        {
            /*Una universidad necesita un programa para gestionar las notas de los estudiantes en un
            curso. El programa debe permitir a un profesor ingresar las notas de los estudiantes,
            calcular el promedio de notas y asignar calificaciones finales.
            El programa debe repetirse hasta que el profesor decida finalizar la entrada de notas para
            el curso. Para cada estudiante, el programa debe hacer lo siguiente:
            Solicitar al profesor que ingrese el nombre del estudiante y sus tres notas parciales (nota1,
            nota2, nota3).
            Calcular el promedio de las notas parciales.
            Utilizar una estructura de selección múltiple para asignar una calificación final al
            estudiante según el siguiente criterio:
                • Si el promedio es mayor o igual a 90, asignar "A".
                • Si el promedio es mayor o igual a 80 y menor que 90, asignar "B".
                • Si el promedio es mayor o igual a 70 y menor que 80, asignar "C".
                • Si el promedio es menor que 70, asignar "D".
            Mostrar el nombre del estudiante, sus notas parciales, su promedio y su calificación final.
            Luego de mostrar la información del estudiante, el programa debe preguntar al profesor si
            desea ingresar las notas de otro estudiante.
                • Si el profesor decide continuar, el programa debe repetirse y permitirle ingresar las
            notas de otro estudiante (paso 1).
                • Si el profesor decide finalizar la entrada de notas, el programa debe mostrar un
            resumen de las calificaciones de todos los estudiantes, incluyendo la cantidad de
            estudiantes en cada categoría de calificación (A, B, C, D).
                • El programa debe utilizar un bucle para repetir la entrada de notas hasta que el
            profesor decida finalizar. Además, debe utilizar una estructura de selección
            múltiple para asignar las calificaciones finales según el criterio establecido.
            El objetivo del programa es facilitar la gestión de notas y calificaciones para un curso
            universitario y proporcionar estadísticas sobre las calificaciones de los estudiantes al
            finalizar la entrada de notas.*/


        }
        public void tercero()
        {
            /*Supongamos que trabajas para una empresa de repartos; La empresa se dedica a la
            entrega de alimentos a domicilio. Tu tarea es desarrollar un programa en PSeInt que ayude
            a gestionar las ventas y entregas de la empresa.
            El programa debe permitir al usuario realizar las siguientes acciones:
                • Registrar una nueva venta: El usuario debe poder ingresar los siguientes datos para
            registrar una venta:
                o Nombre del cliente.
                o Dirección de entrega.
                o Total de la venta.
                • Consultar ventas: El usuario debe poder consultar el número total de ventas realizadas.
                • Calcular ingresos totales: El usuario debe poder calcular los ingresos totales de la
            empresa sumando el total de todas las ventas registradas.
                • Salir del programa.
            El programa debe utilizar un bucle mientras para permitir al usuario realizar múltiples
            acciones hasta que decida salir del programa.
            Además, debes asegurarte de que los datos ingresados sean válidos (por ejemplo, no
            permitir valores negativos para el total de la venta).*/
        }
        public void cuarto()
        {
            /*Imagine que está desarrollando un algoritmo para un restaurante de entrega de
            hamburguesas. El objetivo es crear un programa que permita a los clientes realizar pedidos
            de hamburguesas de un menú predefinido. El menú incluirá varias opciones de
            hamburguesas con diferentes nombres, tamaños y precios. Los clientes podrán seleccionar
            una hamburguesa a la vez y agregarla a su pedido. El programa deberá calcular el total del
            pedido (en soles) y mostrar un resumen al final. El cliente también deberá tener la opción
            de finalizar su pedido cuando lo desee.
            Su tarea es diseñar y desarrollar un algoritmo en PSeInt que cumpla con estos requisitos.
            Asegúrese de utilizar un bucle mientras (o un enfoque similar) para permitir que los
            clientes realicen múltiples pedidos y una selección múltiple para manejar las opciones del
            menú.*/
        }
        public void quinto()
        {
            /*Desarrolla un algoritmo que permita a la recepcionista ingresar y registrar el tiempo de atención
            para cada paciente hasta que decida finalizar la sesión. El algoritmo debe utilizar un bucle repetir
            para pedir continuamente el tiempo de atención del paciente en minutos.
            Después de cada ingreso, el sistema debe usar una condicional para verificar si el tiempo
            registrado excede el tiempo promedio de atención esperado de 30 minutos. Si el tiempo de
            atención es superior a los 30 minutos, el sistema debe alertar a la recepcionista que el tiempo
            fue excepcionalmente largo. El bucle termina cuando la recepcionista ingresa un tiempo de
            atención de "0", o cuando se registran al menos 4 pacientes continuos que superen el promedio
            de 20 minutos.*/


        }

        public static void Sueldo1()
        {
            // Las variables totales deben acumularse a lo largo de todos los trabajadores.
            // Se inicializan aquí para que mantengan su valor a través de las iteraciones.
            double totalDescuentosAcumulado = 0;
            double totalGastoCompaniaSeguroSocialAcumulado = 0;

            int numeroDeTrabajadores = 0; // Variable para almacenar la cantidad de trabajadores

            // Crear una única instancia de Random fuera del bucle para mejor aleatoriedad.
            Random random = new Random();

            // Llamada a la función principal que orquesta el flujo
            Principal();

            void Principal()
            {
                PedirCantidadTrabajadores();

                for (int i = 1; i <= numeroDeTrabajadores; i++)
                {
                    Console.WriteLine("\n*****************************");
                    Console.WriteLine($"Datos del trabajador N°: {i}");

                    // Calcular Sueldo Bruto y almacenarlo en una variable local para este trabajador.
                    int sueldoBrutoActual = CalcularSueldoBruto(random); // Pasar la instancia de Random

                    // Calcular el descuento individual y sumarlo al total acumulado.
                    double descuentoIndividual = CalcularDescuento(sueldoBrutoActual);
                    totalDescuentosAcumulado += descuentoIndividual;
                    Console.WriteLine($"Descuento para este trabajador: S/. {descuentoIndividual:F2}"); // Formato a 2 decimales

                    // Calcular el gasto de seguro social individual y sumarlo al total acumulado.
                    double gastoSeguroIndividual = CalcularGastoSeguro(sueldoBrutoActual);
                    totalGastoCompaniaSeguroSocialAcumulado += gastoSeguroIndividual;
                    if (gastoSeguroIndividual > 0)
                    {
                        Console.WriteLine($"Gasto de compañía por seguro social para este trabajador: S/. {gastoSeguroIndividual:F2}");
                    }
                    else
                    {
                        Console.WriteLine("No aplica pago de seguro social de la compañía para este trabajador.");
                    }
                }

                Console.WriteLine("\n**********************************************************");
                Console.WriteLine($"El descuento total acumulado de todos los trabajadores es de S/. {totalDescuentosAcumulado:F2}");
                Console.WriteLine($"El gasto total de la compañía por seguro social de toda la planilla es de S/. {totalGastoCompaniaSeguroSocialAcumulado:F2}");
                Console.WriteLine("**********************************************************");
            }

            void PedirCantidadTrabajadores()
            {
                Console.WriteLine("Ingresa el numero de trabajadores:");
                while (!int.TryParse(Console.ReadLine(), out numeroDeTrabajadores) || numeroDeTrabajadores <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un número de trabajadores válido (entero positivo).");
                }
            }

            // Ahora esta función recibe la instancia de Random y retorna el SueldoBruto.
            int CalcularSueldoBruto(Random rand)
            {
                int horasTrabajadas = rand.Next(30, 40); // 30 a 39 horas
                Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");

                int pagoHora = rand.Next(35, 125); // 35 a 124 soles por hora
                Console.WriteLine($"Pago por hora: S/. {pagoHora:F2}");

                int sueldoBruto = horasTrabajadas * pagoHora;
                Console.WriteLine($"Sueldo Bruto: S/. {sueldoBruto:F2}");
                return sueldoBruto;
            }

            // Esta función calcula el descuento individual para un sueldo bruto dado.
            double CalcularDescuento(int sueldoBrutoParam) // Renombrado para evitar confusión con variable global
            {
                double dsct = 0; // Descuento para el trabajador actual

                if (sueldoBrutoParam <= 1500)
                {
                    Console.WriteLine("Aplica descuento del 5%");
                    dsct = sueldoBrutoParam * 0.05;
                }
                else if (sueldoBrutoParam <= 3000) // Ya sabemos que es > 1500 por la condición anterior
                {
                    Console.WriteLine("Aplica descuento del 7%");
                    dsct = sueldoBrutoParam * 0.07;
                }
                else if (sueldoBrutoParam <= 4500) // Ya sabemos que es > 3000
                {
                    Console.WriteLine("Aplica descuento del 9%");
                    dsct = sueldoBrutoParam * 0.09;
                }
                else // sueldoBrutoParam > 4500
                {
                    Console.WriteLine("Aplica descuento del 10%");
                    dsct = sueldoBrutoParam * 0.10;
                }
                return dsct; // Retorna el descuento individual
            }

            // Esta función calcula el gasto de seguro social individual para un sueldo bruto dado.
            double CalcularGastoSeguro(int sueldoBrutoParam) // Renombrado
            {
                double seguroSocialGasto = 0; // Gasto individual de la compañía
                if (sueldoBrutoParam > 2300)
                {
                    seguroSocialGasto = sueldoBrutoParam * 0.08;
                }
                return seguroSocialGasto; // Retorna el gasto individual
            }
        }

    }
}
