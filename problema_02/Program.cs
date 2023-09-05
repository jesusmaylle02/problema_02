using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario la categoría de hotel y la cantidad de días de estadía
            Console.Write("Ingrese la categoría de hotel 3 o 5 estrellas : ");
            int categoria = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de días de estadía: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            // Calcular el costo base según la categoría
            double costoBase = 0;
            if (categoria == 3)
            {
                if (dia<= 5)
                {
                    costoBase = 100.00;
                }
                else if (dia <= 10)
                {
                    costoBase = 85.00;
                }
                else
                {
                    costoBase = 70.00;
                }
            }
            else if (categoria == 5)
            {
                if (dia <= 5)
                {
                    costoBase = 300.00;
                }
                else if (dia <= 10)
                {
                    costoBase = 270.00;
                }
                else
                {
                    costoBase = 250.00;
                }
            }

            // Calcular el costo total incluyendo el desayuno
            double costoTotal = costoBase + (7.00 * dia);
            Console.WriteLine("El monto  total a pagar es: S/ " + costoTotal);
            Console.ReadKey();
            
           


        }
    }
}
