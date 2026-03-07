// Ques2Loops -- write a prog to generate and print armstong no

namespace Loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            int sum = 0;

            Console.WriteLine($"Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while(num != 0)
            {
                int digit = num % 10;
                sum += (digit * digit * digit);
                num = num / 10;
            }

            if(sum == temp)
            {
                Console.WriteLine($"The no is armstrong : {sum}");
            }
            else
            {
                Console.WriteLine("Not an armstrong no");
            }
                Console.ReadLine();
        }
    }
}
