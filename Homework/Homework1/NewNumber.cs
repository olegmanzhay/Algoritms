using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class NewNumber
    {
        int number; // исходное число
        int systemNumber; // система счисления
        string result; // новое число в определенной системе счисления

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public int SystemNumber
        {
            get
            {
                return systemNumber;
            }
            set
            {
                systemNumber = value;
            }
        }

        /// <summary>
        /// Перевод в 2-ю систему счсления
        /// </summary>
        /// <param name="A">Исходное число и система счисления</param>
        /// <returns></returns>
        public string ConvertSystem2(NewNumber A)
        {
            if (A.Number > 0)
            {
                if (A.Number % A.SystemNumber == 1)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                A.Number /= A.SystemNumber;
                ConvertSystem2(A); // рекурсия
            }
            string output = new string(result.ToCharArray().Reverse().ToArray()); // реверс строки
            return output;
        }
        /// <summary>
        /// Перевод в 8-ю систему счсления
        /// </summary>
        /// <param name="A">Исходное число и система счисления</param>
        /// <returns></returns>
        public string ConvertSystem8(NewNumber A)
        {
            if (A.Number > 0)
            {
                if (A.Number % A.SystemNumber != 0)
                {
                    result += $"{A.Number % A.SystemNumber}";
                }
                else
                {
                    result += $"0";
                }
                A.Number /= A.SystemNumber;
                ConvertSystem8(A);
            }

            string output = new string(result.ToCharArray().Reverse().ToArray()); // реверс строки
            return output;
        }
        /// <summary>
        /// Перевод в 16-ю систему счсления
        /// </summary>
        /// <param name="A">Исходное число и система счисления</param>
        /// <returns></returns>
        public string ConvertSystem16(NewNumber A)
        {
            if (A.Number > 0)
            {
                if (A.Number % A.SystemNumber != 0 && A.Number % A.SystemNumber < 10)
                {

                    result += $"{A.Number % A.SystemNumber}";
                }
                else if(A.Number % A.SystemNumber == 0)
                {
                    result += $"0";
                }
                else
                {
                    if (A.Number % A.SystemNumber == 10)
                    {
                        result += $"A";
                    }
                    else if (A.Number % A.SystemNumber == 11)
                    {
                        result += $"B";
                    }
                    else if (A.Number % A.SystemNumber == 12)
                    {
                        result += $"C";
                    }
                    else if (A.Number % A.SystemNumber == 13)
                    {
                        result += $"D";
                    }
                    else if (A.Number % A.SystemNumber == 14)
                    {
                        result += $"E";
                    }
                    else if (A.Number % A.SystemNumber == 15)
                    {
                        result += $"F";
                    }
                }
                A.Number /= A.SystemNumber;
                ConvertSystem16(A);
            }
            string output = new string(result.ToCharArray().Reverse().ToArray()); // реверс строки
            return output;
        }
    }
}
