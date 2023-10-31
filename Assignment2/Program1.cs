namespace Assignment2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
           int[] num=new int[10];
            for(int i=0;i<10;i++)
            {
              num[i]= Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i=0;i<10; i++)
            {
                sum += num[i];
            }
            Console.WriteLine("Sum is"+sum);
            Console.WriteLine("Average is" + sum / 10);
        }
    }
}