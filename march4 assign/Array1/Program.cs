// Ques1Arrays -- Take an integer array which contains duplicate values and
// remove the duplicate elements from the array and show me the result in new array or in the same arrray 

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no of elements for the array size");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter the array values");

            for(int i = 0;i < arr.Length; i++) // taking the elements for the array as input from the user
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            int j = 0;
            for(int i = 0;i < n-1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    arr[j++] = arr[i]; // storing the non duplicate elements in the same array;
                }
            }

            arr[j++] = arr[n - 1]; // storing of last element

            Console.WriteLine("new array without duplicates");
            for (int i = 0; i < j; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
