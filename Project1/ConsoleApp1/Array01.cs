using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array01
    {
        int[] lista;
        int tam;
        public Array01()
        {
        }
        public void pedirTamano()
        {
            Console.WriteLine("Dime el numero de numeros que vas a introducir:");
            this.tam = Convert.ToInt32(Console.ReadLine());
            this.lista = new int[tam];

        }
        public void pedirNumeros()
        {
            Console.WriteLine("Introduce los numeros:");
            for (int i = 0; i < this.lista.Length; i++)
            {
                lista[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void dameNumeroDiaAno()
        {
            Console.WriteLine("Selecciona un mes:");
            int numMes = Convert.ToInt32(Console.ReadLine());
            if (numMes > 12 || numMes < 0)
            {
                throw new Exception("ERROR: eleccion incorrecta");
            }
            Console.WriteLine("Selecciona un dia del mes:");
            int numDia = Convert.ToInt32(Console.ReadLine());
            if(numDia > this.lista[numMes-1] || numDia < 0)
            {
                throw new Exception("ERROR: eleccion incorrecta");
            }
            for (int i = 0; i < numMes-1; i++)
            {
                numDia += this.lista[i];
            }
            Console.WriteLine("Es el dia {0} del año.", numDia);
            Console.WriteLine("Faltan {0} dias para final de año.",365-numDia);
        }
        public void ordenaNumeros()
        {
            Console.WriteLine("El nuevo orden es:");
            this.lista = this.lista.Reverse().ToArray();
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("{0}", this.lista[i]);
            }
        }



    }
}
