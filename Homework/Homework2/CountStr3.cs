using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class CountStr3
    {
        string str1; // первая строка
        string str2; // вторая строка
        int count;   // количество элементов в подпоследовательности 

        
        public string Str1
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;
            }
        }
        public string Str2
        {
            get
            {
                return str2;
            }
            set
            {
                str2 = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int Str3Count(CountStr3 A, ref string str)
        {
            int n = Str1.Length + 2; // количество строк
            int m = Str2.Length + 2; // количество столбцов
            char[,] mass = new char [n,m];
            int a = 2; // начинаем с 2 строки, так как 0 нам не интересны (позиция старта)
            int b = 2; // начинаем с 2 строки, так как 0 нам не интересны (позиция старта)
            
            //Заполняем 1 столбец
            for (int j = 0; j < Str2.Length; j++)
            {
                
                mass[0, a] = Str2[j];
                a++;
            }
            
            // заполняем 1 строку
            for (int i = 0; i < Str1.Length; i++)
            {

                mass[b, 0] = Str1[i];
                b++;
            }
            // возвращаем исходные значения а и b для прогонки по массиву
            a = 2;
            b = 2;
            for (int i = b; i < n; i++)
            {
                for (int j = a; j < m; j++)
                {
                    if(mass[0,j] == mass[i, 0] && mass[0, j]!=0 && mass[i, 0]!=0)
                    {
                        str += mass[0, j].ToString();
                        count++; // увеличиваем количество элементов подпоследовательности 
                        /* если находим одинаковые элементы, 
                           дальше нет смысла смотреть
                           переходим на другую строку и столбец*/ 
                        b++; 
                        a++;
                        break;
                    }
                }
            }
            return count;

        }

    }
}
