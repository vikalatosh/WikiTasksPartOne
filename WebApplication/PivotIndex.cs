using System;

namespace WebApplication
{
    public class PivotIndex
    {
        
        public static void Test1()
        {
            int sum = 0;
            int leftsum = 0;
            int[] numbers = new int[] {1, 2, 3};
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    leftsum = 0;
                    if (leftsum == (sum - numbers[i] - leftsum))
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    leftsum += numbers[i - 1];
                    if (leftsum == (sum - numbers[i] - leftsum))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}