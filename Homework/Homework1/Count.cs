using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Count
    {
        int[,] mass;// массив значений поля, который изменяется
        int[,] mass1;// массив значений поля, который не изменяется
        int countWays;
        public int [,] Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public int[,] Mass1
        {
            get
            {
                return mass1;
            }
            set
            {
                mass1 = value;
            }
        }
        /// <summary>
        /// Находит количетство маршрутов
        /// </summary>
        /// <param name="A"></param>
        /// <returns>int</returns>
        public int CountWays(Count A)
        {
            int i, j, k;
            if (Mass[0, 1] == 1 && Mass[0, 2] == 3 || Mass[1, 0] == 1 && Mass[2, 0] == 3)
            {
                countWays= 1;
            }
            else
            {
                for (i = 1; i < 3; i++)
                {
                    for (j = 1; j < 3; j++)
                    {

                        if (Mass[i, j] == 1)
                        {
                            Mass[i, j] = Mass[i - 1, j] + Mass[i, j - 1];
                            countWays = mass[i, j];
                        }
                        if (Mass[i, j] == 0)
                        {
                            Mass[i, j] = 0;
                            countWays = Mass[i, j];
                        }
                        if (Mass1[i, j] == 3)
                        {
                            Mass[i, j] = Mass[i - 1, j] + Mass[i, j - 1];
                            countWays = Mass[i, j];
                            break;
                        }


                    }
                    for (k = 1; k < 2; k++)
                    {
                        if (Mass1[i, k] == 3)
                            break;
                        else if (Mass1[i, k] != 3 && Mass1[0, 2] == 3 || Mass1[i, k] != 3 && Mass1[2, 0] == 3)
                        {
                            countWays = 0;
                            break;
                        }
                    }
                    if (Mass1[i, k] == 3)
                        break;
                    else if ((Mass1[i, k] != 3 && Mass1[0, 2] == 3 || Mass1[i, k] != 3 && Mass1[2, 0] == 3))
                    {
                        countWays = 0;
                        break;
                    }
                }
            }
            return countWays;
        }
    }
}
