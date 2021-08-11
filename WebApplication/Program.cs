using System;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Print the sum of odd numbers from 1 to 99
            int sum = 0;
            for (int num = 1; num <= 99; num++)
            {
                if (num == 1 || num % 2 == 1)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
            
            // Print the sum of numbers sum = 1 + 2 + 4 + 8 + ... + 256
            sum = 0;
            for (int num = 1; num <= 256; num *= 2)
            {
                sum += num;
            }
            Console.WriteLine(sum);
            
            /* Today runner's distance equal 10 km. Every day runner increases distance by 10% from last one.
            Which distance will runner run by 7 days?
            */ 
            double run = 10;
            double distance = 10;
            for (int n = 2; n <= 7; n++)
            {
                run *= 1.1;
                distance += run;
            }
            Console.WriteLine(distance);
            
            // Translate inchs into santimeters 
            double index = 2.54;
            double resultSum;
            for (int i = 1; i <= 20; i++)
            {
                resultSum = i * index;
                Console.WriteLine($"{i} дюйм(ов) = {resultSum} сантиметров");
            }
            
            // Multiply A by B without using multiplication
            int A = 15;
            int B = 10;
            int result = 0;
            for (int i = 1; i <= B; i++)
            {
                result += A;
            }
            Console.WriteLine(result);
            
            // Print all even integers from 2 to 20 in string. Print all even integers from 2 to 20 in column.
            int[] mas = new int[10]; 
            int i1 = 0;
                for (int j = 2; j <= 20; j += 2)
                {
                    if (i1 < 10)
                    {
                        mas[i1] = j; 
                        Console.Write($"{mas[i1]} ");
                        i1++;
                    }
                }
                Console.WriteLine("");
                foreach (var t in mas)
                {
                    Console.WriteLine(t);
                }
            Console.WriteLine("");

            PivotIndex.Test1();
            WikiTasks.Task1();
            WikiTasks.Task2();
            WikiTasks.Task3();
            WikiTasks.Task4();

        }
    }
}