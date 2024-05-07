using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    abstract class Operaciones
    {
        public abstract double Suma(double n1, double n2);
        public abstract double Resta(double n1, double n2);
        public abstract double Multiplicacion(double n1, double n2);
        public abstract double Division(double n1, double n2);

        public void Imprimir(string tipoOperacion, double resultado)
        {
            Console.WriteLine($"El resultado {tipoOperacion} es: {resultado}");
        }
    }
}