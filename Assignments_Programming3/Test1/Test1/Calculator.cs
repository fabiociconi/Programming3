using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public delegate int DelegateCalculator(int x, int y);
    
    class Calculator
    {
        DelegateCalculator delegateObj = null;
        //Declare Delegate
        
        private int Add(int x, int y)
        {
            return x + y;

        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        private int Multi(int x, int y)
        {
            return x * y;
        }
        private int Div(int x, int y)
        {
            return x / y;
        }

    }
}
