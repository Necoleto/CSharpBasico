using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region -------------------SUMAR DOS NUMEROS ENTEROS-----------------

            int num1, num2;
            System.Console.WriteLine("Inserte el primer numero");
            num1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Inserte el segundo numero");
            num2 = Convert.ToInt32(System.Console.ReadLine());

            IOperaciones operacion = new Suma(num1,num2);
            int sumar = operacion.sumar();
            System.Console.WriteLine("La suma de los numeros introducidos es: {0}" , sumar);
            System.Console.ReadLine();

            operacion = new Resta(num1,num2);
            int restar = operacion.restar();
            System.Console.WriteLine("La resta de los numeros introducidos es: {0}", restar);
            System.Console.ReadLine();


            #endregion

        }
    }
}
