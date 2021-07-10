using System;



namespace ClassMethod

{

    class Program

    {

        void sum(int num1)

        {

            Console.WriteLine(num1 + 10);

        }

        void subtract(int num1)

        {

            Console.WriteLine(num1 - 10);

        }

        void divide(int num1)

        {

            Console.WriteLine(num1 / 10);

        }

        static void Main(string[] args)

        {

            Program ps = new Program();

            int num2;

            Console.WriteLine("Enter Number : ");

            num2 = Convert.ToInt32(Console.ReadLine());

            ps.sum(num2);

            ps.subtract(num2);

            ps.divide(num2);

        }

    }

}