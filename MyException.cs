using System;
namespace _2dstringarray
{
    public class MyException : Exception
    {
        public MyException():base("Number must be a positive integer.")
        {
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            { sum += number; }
            return sum;
        }
    }

    
}

