namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loop!");

            int loop = 15;

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine($"Loop {i}");
                Thread.Sleep(500);
                Console.Beep();
            }


        }
    }
}
