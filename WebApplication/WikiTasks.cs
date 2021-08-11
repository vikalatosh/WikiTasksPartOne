using System;
using System.Linq;

namespace WebApplication
{
    public class WikiTasks
    {
        public static void Task1()
        {
            /* Задача No1. Вводится строка. Удалить из нее все пробелы. После этого определить, является ли она
             палиндромом (перевертышем),т.е.одинаково пишется как с начала,так и с конца.
            */

            string str = "шалаш";
            string str1 = str.Replace(" ", "").ToUpper();
            Console.WriteLine(str1);
            string strNew = "";
            for (int i = str1.Length - 1; i >=0; i--)
            {
                char a = str1[i];
                strNew += a;
            }
            Console.WriteLine(strNew);
            if (str1.Equals(strNew))
            {
                Console.WriteLine($"Строка {str} является полиндромом");
            }
            else
            {
                Console.WriteLine($"Строка {str} не является полиндромом");
            }
        }
        
        /* Задача No2 Найти два наименьших (минимальных) элемента массива
         В одномерном массиве целых чисел определить два наименьших элемента. Они могут быть как равны между собой 
         (оба являться минимальными),так и различаться.
         */

        public static void Task2()
        {
            int[] mas = new int[] {1, 9, 0, 1, 0};
            int min = mas.Max();
            int min2 = mas.Max();
            int a = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                    a = i;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (min2 > mas[i] && i != a)
                {
                    min2 = mas[i];
                }
            }
            Console.WriteLine($"Два наименьших числа массива: {min}; {min2}");
        }
        
        /* Задача No3 Сортировка столбцов матрицы по возрастанию элементов первой строки
         */
        public static void Task3()
        {
            int[,] mas = new int[3, 4] {
                {3, -2, 6, 4},
                {8, 1, 12, 2},
                {5, 4, -8, 0}
            };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            int temp;
            for (int i = 0; i < columns; i++)
            {
                for (int j = i + 1; j < columns; j++)
                {
                    if (mas[0, i] > mas[0, j])
                    {
                        for (int k = 0; k < rows; k++)
                        {
                            temp = mas[k, i];
                            mas[k, i] = mas[k, j];
                            mas[k, j] = temp; 
                        }
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + " "); 
                }
                Console.WriteLine("");
            }
        }
        
        /*Задача No4 Рассчитать выплаты по кредиту
          Рассчитать месячные выплаты (m) и суммарную выплату (s) по кредиту.
          О кредите известно, что он составляет n рублей, берется на y лет, под p процентов.
         */

        public static void Task4()
        {
            int n = 44000;       // сумма по кредиту
            int y = 10;          // лет
            double p = 16.5;     // процентов
            double m;            // месячная выплата
            int s;               // суммарная выплата по кредиту
            s = (int) (n * p / 100 * y);
            m = (n + s) / y / 12;
            Console.WriteLine($"Суммарная выплата по кредиту на сумму {n} руб., взятого на {y} лет под {p}% годовых, " +
                              $"составит {s}. Месячные выплаты составят {m} руб.");
            
        }
    }
}