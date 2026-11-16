namespace ForLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kordiuste arv");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n\n");

            int kordused = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= kordused; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}
