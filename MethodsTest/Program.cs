using System;

namespace MethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Give me an int");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
        }


        public static void MultiplicationTable(int number)
        {
            for (int i = 0; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0} * {1} = {2}", i,number,answer);

            }
        }
        
    }
}
