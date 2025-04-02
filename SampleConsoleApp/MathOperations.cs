using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class MathOperations
    {
        public int ComputeFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * ComputeFactorial(n - 1);
        }
    }
}
