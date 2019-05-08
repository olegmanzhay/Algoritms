using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class FindPrograms
    {
        int number1;
        int number2;
        int result;

        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }
        public int Result(FindPrograms A)
        {
           
            while (A.Number2 != A.Number1)
            {
                if (A.Number2 - 1 >= A.Number1 && A.Number2 % (A.Number1 - 1) == 0)
                {
                    result++;
                    A.Number2--;
                    Result(A);
                }
                else if (A.Number2 - 1 >= A.Number1)
                {
                    result++;
                    A.Number2--;
                    Result(A);
                }  
            }
            return result;
        }

    }
}
