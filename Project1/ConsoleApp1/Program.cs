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

            #region -------------------MAIN OPERACIONES-----------------

            int num1, num2;
            try
            {
                Console.WriteLine("Inserte el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                IOperaciones operacion = new Suma(num1, num2);
                int sumar = operacion.sumar();
                Console.WriteLine("La suma de los numeros introducidos es: {0}", sumar);
                Console.ReadLine();

                operacion = new Resta(num1, num2);
                int restar = operacion.restar();
                Console.WriteLine("La resta de los numeros introducidos es: {0}", restar);
                Console.ReadLine();

                operacion = new Multiplicacion(num1, num2);
                int multiplicar = operacion.multiplicar();
                Console.WriteLine("La multiplicacion de los numeros introducidos es: {0}", multiplicar);
                Console.ReadLine();

                operacion = new Division(num1, num2);
                decimal dividir = operacion.dividir();
                Console.WriteLine("La division de los numeros introducidos es: {0}", dividir);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introducido no es valido");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir un numero entre cero");
            }

            #endregion

        }
    }
}
