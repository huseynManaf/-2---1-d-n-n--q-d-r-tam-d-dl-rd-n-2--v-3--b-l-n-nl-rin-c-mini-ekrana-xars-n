namespace tapsiriq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Eded daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
                if (i % 2 == 0 & i % 3 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine($"cem: {sum}");
            }
        }
    }
}