using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Semana3
    {
        public void Utilidad()
        {
            /*El dueño de una tienda compra un artículo a un precio determinado. el necesita un algoritmo
              que le de el precio al que lo debe de vender según el margen de utilidad solicitado*/


        }

        public void Porcentaje()
        {
            /*En un aula existen H alumnos hombre y M Alumnos mujeres elaborar un algoritmo que calcule
              el porcentaje de cada uno de ellos*/

            int hombres = 0, mujeres = 0, total = 0;
            double Phombres, Pmujeres;

            Console.WriteLine("Ingresa la cantidad de hombres: ");
            hombres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de mujeres: ");
            mujeres = int.Parse(Console.ReadLine());

            total = hombres + mujeres;

            Phombres = Math.Round((double)(hombres * 100) / total, 2);  //tambien se puede hacer de la siguiente manera: Pmujer = (total / 100) * mujeres;
            Pmujeres = Math.Round((double) (mujeres * 100) / total, 2);

            Console.WriteLine($" El porcentaje de mujeres es: {Pmujeres} El porcentaje de hombres es: {Phombres}");

        }

        public void Apretones()
        {
            /*A una Reunión asistieron n personas, necesitamos un algoritmo que calcule cuantos apretones
              de manos se dieron.*/

            int tapretones = 0, personas = 0;

            Console.WriteLine("Ingresa la cantidad de personas:");
            personas = int.Parse(Console.ReadLine());

            tapretones = personas * (personas - 1) / 2;

            Console.WriteLine($"Se realizaron un total de {tapretones} apretones");
        }

        public void Promedio()
        {
            /*En el curso se necesita un algoritmo que ingresadas las 4 notas (T1,T2,T3 y EF) calcule el
              promedio obtenido.*/

            int t1 = 0, t2 = 0, t3 = 0, ef = 0;
            double media;
            Console.WriteLine("Ingresa la nota obtenida en la T1");
            t1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la nota obtenida en la T1");
            t2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la nota obtenida en la T1");
            t3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la nota obtenida en la T1");
            ef = int.Parse(Console.ReadLine());

            media = t1 + t2 + t3 + ef;

            Console.WriteLine($"El promedio obtenido es de: {media} puntos");
        }

        public void Distancia()
        {
            /*Se necesita realizar un algoritmo que calcule la distancia  
              entre dos puntos de coordenadas conocidas*/

            double magnitud, px1, px2, py1, py2;

            Console.WriteLine("Ingresa las coordenadas del primer punto");
            Console.WriteLine("X =");
            px1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y =");
            py1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa las coordenadas del segundo punto");
            Console.WriteLine("X =");
            px2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y =");
            py2 = Convert.ToDouble(Console.ReadLine());

            magnitud = Math.Sqrt(Math.Pow(px2 -px1, 2) + Math.Pow(py2 -py1, 2));
            Console.WriteLine($"La distancia entre ambos puntos es de {magnitud}");

        }

        public void Igv()
        {
            /*Se necesita realizar un algoritmo que encuentre el i.g.v y el costo total de una factura dando el
              valor de las ventas de un producto y la cantidad*/

            double producto = 0, precio, pagoTotal, igv = 0.00;
            int cantidad;

            Console.WriteLine("Ingrese la cantidad de productos que llevo");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());

            producto = cantidad * precio;
            igv = producto * 0.18;
            pagoTotal = producto + igv;

            Console.WriteLine($"El costo total a pagar es de {pagoTotal} soles y el IGV tiene un valor de {igv} soles");

        }

        public void Sueldo()
        {
            /*Se requiere un algoritmo para calcular el sueldo neto de cada empleado después de deducir el
              10% correspondiente a la contribución de la AFP. Además, el algoritmo debe determinar el
              monto que la empresa aporta por cada empleado para ESSALUD, que equivale al 9% del sueldo
              bruto*/

            double sBruto = 0, sNeto = 0, mEssalud, afp;

            Console.WriteLine("Ingrese el sueldo bruto");
            sBruto = int.Parse(Console.ReadLine());

            afp = sBruto * 0.1;
            sNeto = sBruto - afp;
            mEssalud = sBruto * 0.09;

            Console.WriteLine($"El sueldo neto es: {sNeto} El aporte para Essalud es: {mEssalud} El AFP es: {afp}");
        }

    }
}
