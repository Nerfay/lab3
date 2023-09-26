using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        /// <summary>
        /// Вариант: №1
        ///Задания: 904, 911, 930, 967, 911, 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 904:--------------------------------------------------------");
            Task_904();

            Console.WriteLine("Задание 911:-------------------------------------------------------");
            Task_911();

            Console.WriteLine("\nЗадание 930:-------------------------------------------------------");
            Task_930();

            Console.WriteLine("Задание 967:-------------------------------------------------------");
            Task_967();
            Console.ReadLine();
        }
        /// <summary>
        /// Task_904:
        /// Найти наибольший и наименьший элементы Двумерного массива вещественных чисел В[m, n].
        /// </summary>
        private static void Task_904()
        {
            int m = 5;
            int n = 7;
            double[,] array2DDeclaration = new double[m, n];
            Random random = new Random();
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2DDeclaration[i, j] = random.NextDouble() * 100;
                    array2DDeclaration[i, j] = Math.Round(array2DDeclaration[i, j], 4);
                    Console.Write(array2DDeclaration[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double minValue = array2DDeclaration[0, 0];
            double maxValue = array2DDeclaration[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array2DDeclaration[i, j] < minValue)
                    {
                        minValue = array2DDeclaration[i, j];
                    }
                    if (array2DDeclaration[i, j] > maxValue)
                    {
                        maxValue = array2DDeclaration[i, j];
                    }
                }
            }
            Console.WriteLine("Наименьший элемент: " + minValue);
            Console.WriteLine("Наибольший элемент: " + maxValue);
        }
        /// <summary>
        /// Task_911:
        /// Задан Двумерный массив вещественных чисел. Найти:
        ///а) максимальную сумму абсолютных значений элементов по строкам и номер строки с такой суммой;
        ///б) максимальную сумму абсолютных значений элементов по столбцам и номер столбца с такой суммой.
        /// </summary>
        private static void Task_911()
        {
            int rows = 6;
            int columns = 8;
            double[,] array2DDeclaration = new double[rows, columns];
            Random random = new Random();
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DDeclaration[i, j] = random.NextDouble() * 100 - 50;
                    array2DDeclaration[i, j] = Math.Round(array2DDeclaration[i, j], 2);
                    Console.Write(array2DDeclaration[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double maxSumAbsValueOfRows = 0;
            double maxSumAbsValueOfColumns = 0;
            int maxSumAbsValueNumberOfRows = 0;
            int maxSumAbsValueNumberOfColumns = 0;
            for (int i = 0; i < rows; i++)
            {
                double sumAbsValueOfRows = 0;
                for (int j = 0; j < columns; j++)
                {
                    sumAbsValueOfRows += Math.Abs(array2DDeclaration[i, j]);
                }
                if (maxSumAbsValueOfRows < sumAbsValueOfRows)
                {
                    maxSumAbsValueOfRows = sumAbsValueOfRows;
                    maxSumAbsValueNumberOfRows = i + 1;
                }
                Console.WriteLine("\n" + " Сумма абсолютных значений элементов строки № " + (i + 1) + " = " + sumAbsValueOfRows);
            }
            Console.WriteLine("\n" + "Строка и ее максимальная сумма абсолютных значений элементов из всех строк" + " № " + (maxSumAbsValueNumberOfRows) + " = " + maxSumAbsValueOfRows);
            for (int i = 0; i < columns; i++)
            {
                double sumAbsValueOfColumns = 0;
                for (int j = 0; j < rows; j++)
                {
                    sumAbsValueOfColumns += Math.Abs(array2DDeclaration[j, i]);
                }
                if (maxSumAbsValueOfColumns < sumAbsValueOfColumns)
                {
                    maxSumAbsValueOfColumns = sumAbsValueOfColumns;
                    maxSumAbsValueNumberOfColumns = i + 1;
                }
                Console.WriteLine("\n" + " Сумма абсолютных значени1 элементов столбца № " + (i + 1) + " = " + sumAbsValueOfColumns);
            }
            Console.WriteLine("\n" + "Столбец и ее максимальная сумма абсолютных значений элементов из всех строк" + " № " + (maxSumAbsValueNumberOfColumns) + " = " + maxSumAbsValueOfColumns);
        }
        /// <summary>
        /// Task_930:
        ///  В Двумерном массиве вещественных чисел заменить все элементы, меньшие суммы элементов первой строки, этой суммой.
        /// </summary>
        private static void Task_930()
        {
            int rows = 5;
            int columns = 3;
            double[,] array2DDeclaration = new double[rows, columns];
            Random random = new Random();
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DDeclaration[i, j] = random.NextDouble() * 10;
                    array2DDeclaration[i, j] = Math.Round(array2DDeclaration[i, j], 4);
                    Console.Write(array2DDeclaration[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double sumOfFirstLine = 0;
            for (int j = 0; j < columns; j++)
            {
                sumOfFirstLine += array2DDeclaration[0, j];
            }
            Console.WriteLine("Сумма элементов первой строки : " + sumOfFirstLine);
            Console.WriteLine("Массив с замененными элементами,которые меньше суммы первой строки:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array2DDeclaration[i, j] < sumOfFirstLine)
                    {
                        array2DDeclaration[i, j] = sumOfFirstLine;
                    }
                    Console.Write(array2DDeclaration[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Task_967:
        /// Фирма имеет 10 магазинов. Информация о доходе каждого магазина за каждый месяц года хранится в 
        /// Двумерном массиве (первого магазина — в первой строке, второго — во второй и т. д.). 
        /// Составить программу для расчета среднемесячного дохода любого магазина.
        /// </summary>
        private static void Task_967()
        {
            int shop = 10;
            int month = 12;
            int[,] firm = new int[shop, month];
            Random random = new Random();
            Console.WriteLine("Магазины с их доходом за каждый месяц:");
            for (int i = 0; i < shop; i++)
            {
                Console.WriteLine(" Магазин № " + (i + 1)); 
                for (int j = 0; j < month; j++)
                {
                    firm[i, j] = random.Next(0, 10000) * 10;
                    Console.Write(firm[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double averageSalaryOfStore = 0;
            for (int i = 0; i < shop; i++)
            {
                double sumOfTheYear = 0;
                for (int j = 0; j < month; j++)
                {
                    sumOfTheYear += (firm[i, j]);
                }
                averageSalaryOfStore = sumOfTheYear / month;
                Console.WriteLine("\n" + " Магазин № " + (i + 1) + " и его среднемесячный доход : " + " = " + averageSalaryOfStore);
            }
        }
    }
}
