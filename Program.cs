//Задача 2, вариант 32, Бесшапошников Владимир
//Даны координаты центров n окружностей и их радиусы. Определить число
//пересекающихся окружностей.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace _3sem_2lab_c_sharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                int n, count = 0;
                string[] readText = File.ReadAllLines(@"S:\Documents\Visual Studio 2022\3sem_2lab_c_sharp\input.txt");
                string[] x = readText[0].Split();
                string[] y = readText[1].Split();
                string[] r = readText[2].Split();
                double[] x1 = new double[x.Length];
                double[] y1 = new double[y.Length];
                double[] r1 = new double[r.Length];
                for (int i= 0; i < x.Length; i++)
                {
                    x1[i] = Convert.ToDouble(x[i]);
                    y1[i] = Convert.ToDouble(y[i]);
                    r1[i] = Convert.ToDouble(r[i]);
                }

                double s;
                Console.WriteLine("Координаты окружностей: ");
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine("x = " + x[i] + "; y = " + y[i] + "; r = " + r[i]);
                }

                for (int i = 0; i < x.Length - 1; i++)
                {
                    for (int j = i + 1; j < y.Length; j++)
                    {

                        s = Math.Sqrt((x1[i] - x1[j])*(x1[i] - x1[j]) + (y1[i] - y1[j])*(y1[i] - y1[j]));
                        if (s <= Math.Abs(r1[i] + r1[j]))
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Найдено пересечений: " + count);
                Console.WriteLine("Окружностей пересечено: " + 2 * count);
            }

            Console.ReadLine();
        }
    }
}