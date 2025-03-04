namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Islam's Carpet Cleaning Service");
            Console.WriteLine("$25 per small");
            Console.WriteLine("$35 per large");
            Console.WriteLine("please enter Number of small carpets:");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" please enter Number of large carpets:");
            int lareCarpets = Convert.ToInt32(Console.ReadLine());
            smallCarpets = smallCarpets * 25;
            lareCarpets = lareCarpets * 35;
            double cost = smallCarpets + lareCarpets;
            double tax = (6 * cost) / 100;
            Console.WriteLine($"total stamate {smallCarpets + lareCarpets + tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
