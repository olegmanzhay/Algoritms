using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Result
    {
        int number;
        int degree;
        int result;

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
        public int Degree
        {
            get
            {
                return degree;
            }
            set
            {
                degree = value;
            }
        }

        /// <summary>
        /// Возведение в степень без рекурсии 
        /// </summary>
        /// <param name="A">Число и степень</param>
        /// <returns></returns>
        public int ResultWithoutRec(Result A)
        {
            int k = 1;  
            for (int i = 0; i < A.Degree; i++)
            {
                k *= A.Number; // возведение в степень
            }
            result = k;
            return result;
        }
        int k = 1;
        int i = 0; // счетчик количества умножений = значению степени
        /// <summary>
        /// Возводит число в степень с использованием рекурсии
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int ResultRec(Result A)
        {
          
            if (i!=A.Degree)
            {
                i++;
                k *= A.Number;
                ResultRec(A);
            }
            result = k;
            return result;
        }
    }
}
