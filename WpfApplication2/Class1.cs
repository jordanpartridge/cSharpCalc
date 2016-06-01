using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations

{
    class Expression
    {
        public Expression(double Val1, String Operation){
            val1 = Val1;
            operation = Operation;
        }
        private double val1;

        public double Val1
        {
            get { return val1; }
            set { val1 = value; }
        }
        private double val2;

        public double Val2
        {
            get { return val2; }
            set { val2 = value; }
        }
        private string operation;

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        public double calc()
        {
            double result = 0;
            switch (operation)
            {
                case "add":
                    result =  val1 + val2;
                    break;
                case "subtract":
                    result = val1 - val2;
                    break;
                case "divide":
                    result = val1 / val2;
                    break;
                case "multiply":
                    result = val1 * val2;
                    break;
               
            }
            return result;
        }

    }

    
}
