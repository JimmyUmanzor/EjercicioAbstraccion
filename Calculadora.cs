using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    class Calculadora : Operaciones
    {
        public override double Suma(double n1, double n2)
        {
            return n1 + n2;
        }

        public override double Resta(double n1, double n2)
        {
            return n1 - n2;
        }
        public override double Multiplicacion(double n1, double n2)
        {
            return n1 * n2;
        }
        public override double Division(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
                return 0;
            }
            else
            {
                return n1 / n2;
            }
        }

        double nro1;
        double nro2;
        public void PideNumeros()
        {
            Console.Write("Ingrese un número A:");
            nro1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese un número B:");
            nro2 = Convert.ToDouble(Console.ReadLine());
        }

        public void RealizarOperaciones()
        {
            PideNumeros();

            double totalSuma = Suma(nro1, nro2);
            Imprimir("en una suma",totalSuma);

            double totalResta = Resta(nro1, nro2);
            Imprimir("en una resta", totalResta);

            double totalMultiplicacion = Multiplicacion(nro1, nro2);
            Imprimir("en una multiplicación", totalMultiplicacion);

            double totalDivision = Division(nro1, nro2);
            Imprimir("en una división", totalDivision);
        }

    }
}
