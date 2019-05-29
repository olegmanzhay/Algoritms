using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class TrueFalseResult
    {
        string str;
        string newStr;
        bool result;
        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }
        public bool Result(TrueFalseResult A)
        {
            Stack<int> stack = new Stack<int>();
            foreach (char character in str)
            {
                int index = "([{)]}".IndexOf(character);
                if (index >= 3)
                {
                    result = false;
                    if (stack.Count == 0 || stack.Pop() != index) return result;
                }
                else if (index >= 0) stack.Push(index + 3);
            }
            if (stack.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        
    }
}
