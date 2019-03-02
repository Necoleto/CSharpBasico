using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Division:Operacion
    {
        private int num1;
        private int num2;
        public Division()
        {
            this.num1 = 0;
            this.num2 = 0;
        }
        public  Division(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public override double dividir()
        {
            if (this.num2 == 0)
            {
                throw new Exception("No se puede dividir un numero entre 0");
            }
            return (double)this.num1 / (double)this.num2;
        }
    }
}
