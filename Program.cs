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
                int count = 0;
                double s;

                //Пропишите, пожалуйста, свой путь к файлу input.txt
                string[] readText = File.ReadAllLines(@"S:\Documents\Visual Studio 2022\3sem_2lab_c_sharp\input.txt");

                string[] x_read = readText[0].Split();
                string[] y_read = readText[1].Split();
                string[] r_read = readText[2].Split();
                double[] x = new double[x_read.Length];
                double[] y = new double[y_read.Length];
                double[] r = new double[r_read.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Convert.ToDouble(x_read[i]);
                    y[i] = Convert.ToDouble(y_read[i]);
                    r[i] = Convert.ToDouble(r_read[i]);
                }
                                
                Console.WriteLine("Координаты окружностей: ");
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine("x = " + x[i] + "; y = " + y[i] + "; r = " + r[i]);
                }

                for (int i = 0; i < x.Length - 1; i++)
                {
                    for (int j = i + 1; j < y.Length; j++)
                    {
                        s = Math.Sqrt((x[i] - x[j])*(x[i] - x[j]) + (y[i] - y[j])*(y[i] - y[j]));
                        if (s <= Math.Abs(r[i] + r[j]))
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Найдено пересечений: " + count);
                Console.WriteLine("Пар окружностей пересечено: " + 2 * count);
            }

            Console.ReadLine();
        }
    }
}