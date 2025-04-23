using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Semana4
    {
        int año = 0;
        public void Estaciones()
        {
            /*Considerando las estaciones del año en Perú:
            • Enero, Febrero, Marzo: Verano
            • Abril, Mayo, Junio: Otoño
            • Julio, Agosto, Setiembre: Invierno
            • Octubre, Noviembre, Diciembre: Primavera
              Si ingresamos el mes del año el algoritmo debe de mostrarnos la estación del año.*/

            int mes = 0;
            bool result = false;
            string estacion = "";

            Console.WriteLine("Ingresa el año");
            result = int.TryParse(Console.ReadLine(), out año);

            if (!result || año < 0 || año == 0)
            {
                Console.WriteLine("ingresar un año valido");
                return;
            }

            Console.WriteLine("Ingresa el mes a evaluar\n" + 
                              "==========================\n" +
                              "Enero: 1           Febrero: 2\n" +
                              "Marzo: 3           Abril: 4\n" +
                              "Mayo: 5            Junio: 6\n" +
                              "Julio: 7           Agosto: 8\n" +
                              "Septiembre: 9      Octubre: 10\n" +
                              "Noviembre: 11      Diciembre: 12");
            result = int.TryParse(Console.ReadLine(), out mes);

            if (!result || mes < 0 || mes == 0)
            {
                Console.WriteLine("ingresa un numero de mes valido");
                return;
            }

            switch (mes)
            {
                case 1:
                case 2:
                case 3:
                    estacion = "Verano";
                    Console.WriteLine($"En el año {año} el mes evaluado pertenece a la estacion de {estacion}");
                    break;
                case 4:
                case 5:
                case 6:
                    estacion = "Otoño";
                    Console.WriteLine($"En el año {año} el mes evaluado pertenece a la estacion de {estacion}");
                    break;
                case 7: 
                case 8: 
                case 9:
                    estacion = "Invierno";
                    Console.WriteLine($"En el año {año} el mes evaluado pertenece a la estacion de {estacion}");
                    break;
                case 10:
                case 11:
                case 12:
                    estacion = "Primavera";
                    Console.WriteLine($"En el año {año} el mes evaluado pertenece a la estacion de {estacion}");
                    break;

            }
        }

        public void Dias()
        {
            /*Considerando que:
            • El orden de los meses es 1: Enero, 2: Febrero, etc.
            • Enero, Marzo, Mayo, Julio, Agosto, Octubre y Diciembre tienen 31 días.
            • Abril, Junio Setiembre y Noviembre tienen 30 días
            • Febrero tiene 28 días, salvo el caso de ser bisiesto (esto ocurre cuando es múltiplo de 4 y no
              de 100 o cuando es múltiplo de 400)
              Se debe de mostrar el número de días del mes*/

            bool result = false;

            Console.WriteLine("Ingresa el mes a evaluar: ");
            string mes = Console.ReadLine();

            if (string.IsNullOrEmpty(mes))
            {
                Console.WriteLine("ingrese un mes valido");
                return;
            }

            Console.WriteLine("Ingresa el año a evaluar: ");
            result = int.TryParse(Console.ReadLine(), out año);

            if (!result || año < 0 || año == 0)
            {
                Console.WriteLine("ingrese un año valido");
                return;
            }

            int dia = 0;
            switch (mes.ToLower())
            {
                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    dia = 31;
                    Console.WriteLine($"Tiene {dia} dias");
                    break;

                case "abril":
                case "junio":
                case "septiembre":
                case "noviembre":
                    dia = 30;
                    Console.WriteLine($"tiene {dia} dias");
                    break;

                case "febrero":
                    
                    if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                    {
                        dia = 29;
                        Console.WriteLine($"tiene {dia} dias");
                    }
                    else
                    {
                        dia = 28;
                        Console.WriteLine($"tiene {dia} dias");
                    }
                    break;
            }          
        }

        public void Dulceria()
        {
            /*Una dulcería vende chocolates a los precios dados en la siguiente tabla:
              Primor S/. 8.5
              Dulzura S/. 10.0
              Tentación S/. 7.0
              Explosión S/. 12.5
              Como oferta, la tienda aplica un porcentaje de descuento sobre el importe de la compra
              basándose en la cantidad de chocolates adquiridos, de acuerdo con la siguiente tabla
              < 5 chocolates descuento de: 4.0%
              = 5 y < 10 chocolates descuento de: 6.5%
              = 10 y < 15 chocolates descuento de: 9.0%
              >= 15 chocolates descuento de: 11.5%
              Adicionalmente, si el importe a pagar es no menor de S/. 250, la tienda obsequia 1
              caramelos por cada 5 chocolate; en caso contrario, obsequia 1 caramelos por cada 4
              chocolate.
              Dado el tipo de chocolate y la cantidad de unidades adquiridas, diseñe un programa que
              determine el importe de la compra, el importe del descuento, el importe a pagar y la
              cantidad de caramelos de obsequio.*/

            int cantidad = 0, tipo = 0;
            bool result = false;
            double dcto = 0, total = 0, precio = 0, caramelos = 0;

            Console.WriteLine("Ingrese el tipo de chocolate\n" +
                "========================\n" +
                "1: Primor\n" +
                "2: Dulzura\n" +
                "3: Tentacion\n" +
                "4: Explocion");

            result = int.TryParse(Console.ReadLine(), out tipo);

            if (!result || tipo < 0 || tipo == 0) 
            {
                Console.WriteLine("ingrese un tipo de chocolate valido");
            }
            
            Console.WriteLine("Ingresar cantidad de chocolates");
            result = int.TryParse(Console.ReadLine(), out cantidad);

            if (!result || cantidad < 0 || cantidad == 0)
            {
                Console.WriteLine("Debe de colocar un valor numerico valido");
                return;
            }

            switch (tipo)
            {
                case 1:
                    precio = 8.5;
                    break;
                case 2:
                    precio = 10;
                    break;
                case 3:
                    precio = 7;
                    break;
                case 4:
                    precio = 12.5;
                    break;

                default:
                    Console.WriteLine("ingrese un tipo correcto");
                    return;
            }

            switch (cantidad)
            {
                case int cant when (cant >= 0 && cant < 5):
                    dcto = 0.04;
                    break;
                case int cant when (cant >= 5 && cant < 10):
                    dcto = 0.065;
                    break;
                case int cant when (cant >= 10 && cant < 15):
                    dcto = 0.09;
                    break;
                case int cant when (cant >= 15):
                    dcto = 0.115;
                    break;

                default:
                    Console.WriteLine("La cantidad debe de ser positiva");
                    return;

            }

            total = cantidad * precio * (1 - dcto);

            if (total > 250)
                caramelos = Math.Ceiling((double)cantidad / 5);
            else
                caramelos = Math.Ceiling((double)cantidad / 4);

            Console.WriteLine($"se entregaran {cantidad}" +
                $" chocolates, el descuento fue de {dcto} soles por caramelo y  se dieron {caramelos} caramelos más por un total de {total} soles");
        }

        public void Biblioteca()
        {
            /*Una biblioteca impone multas por la devolución tardía de los libros. Los usuarios de la biblioteca se
              clasifican en tres categorías: Estudiante, Profesor y Visitante, y cada categoría tiene una tarifa de multa
              por día distinta. Adicionalmente, dependiendo del tipo de usuario y la cantidad de días de retraso, se
              aplica un descuento a la multa total.
              Estudiantes: Multa por día: S/ 0.50
              Descuento del 20% si el retraso es superior a 10 días; de lo contrario, el descuento es del 10%.
              Profesores: Multa por día: S/ 0.30
              Descuento del 50% si el retraso es superior a 5 días; de lo contrario, el descuento es del 25%.
              Visitantes: Multa por día: S/ 1.00
              No se aplica descuento.*/

            int categoria = 0, diasR = 0;
            bool result = false;
            double multa = 0, MultaT = 0, dcto = 0, dctoT = 0;

            Console.WriteLine("===================DEVOLUCIÓN DE LIBROS===================\n" +
                              "Seleccione el  numero de la categoria a la que pertenece: \n" +
                              "==========================================================\n" +
                              "1: Profesor\n" +
                              "2: Estudiante\n" +
                              "3: Visitante");
            result = int.TryParse(Console.ReadLine(), out categoria);

            if (!result || categoria < 1 || categoria > 3)
            {
                Console.WriteLine("ingresar una categoria valida");
                return;
            }    
                
            Console.WriteLine("ingrese la cantidad de dias de retraso:");
            result = int.TryParse(Console.ReadLine(), out diasR);
            if (!result || diasR < 0)
            {
                Console.WriteLine("ingrese un valor numerico valido");
                return;
            }

            switch (categoria) 
            {
                case 1:
                    multa = 0.5;
                    
                    if (diasR > 10)
                    {
                        dcto = 0.2;
                        dctoT = (multa * diasR) * dcto;
                        MultaT = (multa * diasR) - dctoT;
                        Console.WriteLine($"Su multa a pagar es de {MultaT} soles, su descuento aplicado fue de {dctoT} soles");
                    }
                    else 
                    {
                        dcto = 0.1;
                        dctoT = (multa * diasR) * dcto;
                        MultaT = (multa * diasR) - dctoT;
                        Console.WriteLine($"Su multa a pagar es de {MultaT} soles, su descuento aplicado fue de {dctoT} soles");
                    }
                    break;

                case 2:
                    multa = 0.3;

                    if (diasR > 5)
                    {
                        dcto = 0.5;
                        dctoT = (multa * diasR) * dcto;
                        MultaT = (multa * diasR) - dctoT;
                        Console.WriteLine($"Su multa a pagar es de {MultaT} soles, su descuento aplicado fue de {dctoT} soles");
                    }
                    else
                    {
                        dcto = 0.25;
                        dctoT = (multa * diasR) * dcto;
                        MultaT = (multa * diasR) - dctoT;
                        Console.WriteLine($"Su multa a pagar es de {MultaT} soles, su descuento aplicado fue de {dctoT} soles");
                    }
                    break;

                case 3:
                    multa = 1;

                    MultaT = (multa * diasR);
                    Console.WriteLine($"Su multa a pagar es de {MultaT} soles");
                    break;
            }
        }

        public void Tienda()
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

            int cantidad = 0;
            bool valResult = false;
            double precio = 0, total = 0, dcto = 0, dscto;

            Console.WriteLine("Ingrese la cantidad");
            valResult = int.TryParse(Console.ReadLine(), out cantidad);

            if (!valResult)
            {
                Console.WriteLine("Debe de colocar un valor numerico");
                return;
            }

            Console.WriteLine("Ingrese el precio");
            valResult = double.TryParse(Console.ReadLine(), out precio);

            if (!valResult)
            {
                Console.WriteLine("Debe de colocar un valor numerico");
                return;
            }

            if (cantidad > 5)
            {
                dcto = 0.15;
                total = cantidad * precio * (1 - dcto);
                dscto = cantidad * precio * dcto;

                Console.WriteLine($"El precio total es de: {total} y el descuento es de: {dscto}");

            }
            else
            {
                total = cantidad * precio;

                Console.WriteLine($"El precio total es de: {total}");
            }
        }
    }
}
