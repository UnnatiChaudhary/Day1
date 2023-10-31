namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers= { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i+1; j < numbers.Length; j++)
                {

                    if (numbers[i] == numbers[j])
                    {
                        total++;
                        break;
                    }
                }
            }
            Console.WriteLine(total);
   
        }
    }
}
