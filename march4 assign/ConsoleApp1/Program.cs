// ques -- write a program to generate and print all the prime no upto a k

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine($"The the value of k :");
            k = Convert.ToInt32(Console.ReadLine());
            for(int i = 2;i <= k; i++)
            {

                Boolean primeOrNot = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primeOrNot = false;
                        break;
                    }

                    
                    
                }
                if (primeOrNot)
                {
                    Console.WriteLine(i);
                }


            }
            Console.ReadLine();
        }
    }
}
