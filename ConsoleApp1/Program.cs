using System;
namespace project1
{
    class Test
    {
        public static void Main()
        {
            string input_1 = Console.ReadLine();
            string input_2 = Console.ReadLine();
            int num1 = Convert.ToInt32(input_1);
            int num2 = Convert.ToInt32(input_2);
            int sum = num1 + num2;
            Console.WriteLine(input_1 + " + " + input_2 + " = " + sum);
        }
    }
}
