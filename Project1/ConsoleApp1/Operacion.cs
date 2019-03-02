using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Operacion:IOperaciones
    {
        private int num1;
        private int num2;
            
        public Operacion()
        {
            num1 = 0;
            num2 = 0;
        }

        public Operacion(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public virtual int sumar() { return 0; }
        public virtual int restar() { return 0; }
        public virtual int multiplicar() { return 0; }
        public virtual double dividir() { return 0; }

    }
}
