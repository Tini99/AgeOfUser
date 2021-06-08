using System;

namespace AgeOfUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            Console.WriteLine("please enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());

            if(number1 > 18)
            {
                Console.WriteLine("you are and adult now");
            }
            if(number1 < 18)
            {
                Console.WriteLine("you are minor");
            }
        }
    }
}
