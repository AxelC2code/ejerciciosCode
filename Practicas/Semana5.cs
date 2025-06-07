using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Semana5
    {
        public void Descuentos()
        {
            /*Una tienda minorista desea implementar un sistema de descuentos para incentivar compras en
            mayor cantidad. Para ello, se han establecido diferentes rangos de descuento según la cantidad
            de productos adquiridos y el día de la semana en que se realiza la compra. Cada cliente, al llegar
            a la caja, tendrá un descuento aplicado en función de estas dos variables:
            Categorías de Descuento por Cantidad:
            Si compra de 1 a 5 productos, no hay descuento.
            De 6 a 10 productos, se aplica un 5% de descuento.
            De 11 a 20 productos, se aplica un 10% de descuento.
            Más de 20 productos, se aplica un 15% de descuento.
            Descuentos Adicionales por Día:
            Los días lunes y jueves, se añade un 5% adicional al descuento por cantidad.
            Los fines de semana (sábado y domingo), se añade un 10% adicional al descuento por cantidad.
            Considerando el precio unitario fijo de S/. 10.00 por producto, diseñe un algoritmo que
            determine el monto total de la compra, el descuento total aplicado y el monto a pagar por el
            cliente. El algoritmo debe solicitar el número de productos adquiridos y el día de la semana de
            la compra para realizar los cálculos.*/

            // Precio unitario fijo
            const decimal precioUnitario = 10.00m;

            // Solicitar la cantidad de productos
            Console.Write("Ingrese la cantidad de productos adquiridos: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidadProductos) || cantidadProductos < 1)
            {
                Console.WriteLine("Cantidad inválida. Por favor, ingrese un número mayor o igual a 1.");
                return;
            }

            // Solicitar el día de la semana
            Console.Write("Ingrese el día de la semana (Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo): ");
            string diaSemana = Console.ReadLine().ToLower();

            // Calcular el descuento por cantidad
            decimal descuentoPorCantidad = 0;
            if (cantidadProductos >= 6 && cantidadProductos <= 10)
            {
                descuentoPorCantidad = 0.05m; // 5%
            }
            else if (cantidadProductos >= 11 && cantidadProductos <= 20)
            {
                descuentoPorCantidad = 0.10m; // 10%
            }
            else if (cantidadProductos > 20)
            {
                descuentoPorCantidad = 0.15m; // 15%
            }

            // Calcular el descuento adicional por día
            decimal descuentoAdicionalDia = 0;
            switch (diaSemana)
            {
                case "lunes":
                case "jueves":
                    descuentoAdicionalDia = 0.05m; // 5% adicional
                    break;
                case "sabado":
                case "domingo":
                    descuentoAdicionalDia = 0.10m; // 10% adicional
                    break;
                default:
                    break; // No hay descuento adicional para otros días
            }

            // Calcular el descuento total
            decimal descuentoTotal = descuentoPorCantidad + descuentoAdicionalDia;

            // Calcular el monto total de la compra sin descuento
            decimal montoTotalSinDescuento = cantidadProductos * precioUnitario;

            // Calcular el monto del descuento aplicado
            decimal montoDescuentoAplicado = montoTotalSinDescuento * descuentoTotal;

            // Calcular el monto total a pagar
            decimal montoTotalAPagar = montoTotalSinDescuento - montoDescuentoAplicado;

            // Mostrar los resultados
            Console.WriteLine("\n--- Resumen de la Compra ---");
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Día de la semana: {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(diaSemana)}"); // Formatear el día
            Console.WriteLine($"Precio unitario: S/. {precioUnitario:F2}");
            Console.WriteLine($"Monto total sin descuento: S/. {montoTotalSinDescuento:F2}");
            Console.WriteLine($"Descuento por cantidad: {descuentoPorCantidad:P2}");
            Console.WriteLine($"Descuento adicional por día: {descuentoAdicionalDia:P2}");
            Console.WriteLine($"Descuento total aplicado: {descuentoTotal:P2} (S/. {montoDescuentoAplicado:F2})");
            Console.WriteLine($"Monto total a pagar: S/. {montoTotalAPagar:F2}");

        }

        public void DosNumeros()
        {
            /*Introducir dos números por teclado. Imprimir los números naturales que hay entre ambos
            números empezando por el más pequeño, contar cuantos hay y cuantos de ellos son pares.
            Calcular la suma de los impares.*/

            bool result=false;
            int n1 = 0, n2 = 0, nShort = 0, nLong = 0, i = 0;
            Console.WriteLine("ingresa un numero");
            result = int.TryParse(Console.ReadLine(), out n1);

            if (!result)
            {
                Console.WriteLine("ingresa un numero valido");
                return;
            }

            Console.WriteLine("ingresa otro numero");
            result = int.TryParse(Console.ReadLine(), out n2);

            if(!result)
            {
                Console.WriteLine("ingrese un numbre valido");
                return;
            }

            if (n2 > n1)
            {
                nShort = n1;
                nLong = n2;
            }
            else
                nShort = n2;
                nLong = n1;

            for (i = nShort; i <= nLong; i++)
            {

            }
        
        }

        public void LeerDosNumeros()
        {
            /*Elabora un algoritmo que permita leer dos números positivos. Debe validar que el segundo
            número debe ser mayor que el primero. Luego se deben imprimir todos los números primos
            que se encuentren entre ambos números.*/


        }

        public void NumeroTresDig()
        {
            /*Diseñe un algoritmo que solicite un número de al menos tres dígitos y muestre el numero
            invertido y la cantidad de dígitos*/


        }

        public void CienNumeros()
        {
            /*Diseñe un programa que genere 100 números aleatorios enteros del intervalo 100 a 999
            O hasta obtener un número par mayor o igual a 700. Imprima lo números generados y
            determine:
            La suma de los números generados
            La cantidad de números pares generados
            La cantidad de números impares generados
            La suma de los números pares generados
            La suma de los números impares generados*/

            Random rnd = new Random();
            int numero = 0, acumulado = 0;
            int acumPares = 0, pares = 0, impares = 0, acumimpares = 0;

            for (int i = 0; i < 100; i++)
            {
                numero = rnd.Next(100, 999);
                acumulado += numero;
                if (numero % 2 == 0)
                {
                    if (numero <= 700)
                        break;
                    pares++;
                    acumPares += numero;
                }
                else
                {
                    impares++;
                    acumimpares += numero;
                }

            }

            
        }

        public void Sueldos()
        {
            /*Diseñe un programa que genere sueldos aleatorios enteros con valores del
            intervalo 2000 a 4000 hasta obtener un sueldo mayor de 2500 pero menor de 3500.
            Imprima los sueldos generados y determine:
            La suma de los sueldos generados
            La cantidad de sueldos < 2500
            La cantidad de sueldos = 2500 pero < 3000
            La cantidad de sueldos = 3000 pero < 3500
            La cantidad de sueldos = 3500*/


        }

        public void prueba()
        {
            int suma = 0;
            for (int i = 4; i <=10; i = i+2)
            {
                suma =  suma + i;


            }
            Console.WriteLine("la suma: es " + suma);
        }
    }
}
