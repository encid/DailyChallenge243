using System;
using System.Collections.Generic;

namespace DailyChallenge243
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Check(18));
            Console.WriteLine(Check(21));
            Console.WriteLine(Check(9));
            Console.WriteLine(Check(111));
            Console.WriteLine(Check(112));
            Console.WriteLine(Check(220));
            Console.WriteLine(Check(69));
            Console.WriteLine(Check(134));
            Console.WriteLine(Check(85));
            Console.WriteLine(Check(6));
            Console.WriteLine(Check(28));

            Console.ReadLine();
        }

        static string Check(int number)
        {
            var numList = new List<int>();
            int sum = 0;
            int numx2 = number * 2;

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    numList.Add(i);

            foreach (var num in numList)
                sum += num;

            if (sum < numx2)
                return number + " deficient";

            if (sum > numx2)
            {
                int ab = sum - numx2;
                return number + " abundant by " + ab;
            }

            return number + " neither ";
        }
    }
}
