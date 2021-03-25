using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto de calculo");

            int operador1 = 10;
            int operador2 = 5;

            int suma = Calculadora.suma(operador1, operador2);
            int multiplicacion = Calculadora.multiplicacion(operador1, operador2);


        }
    }
}
