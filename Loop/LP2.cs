using System;


    class LP2
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 100, 20, -30, 40, 50 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("The maximum number is: " + max);
            // Console.ReadLine();
        }
    }
