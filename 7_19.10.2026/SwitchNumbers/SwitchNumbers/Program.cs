namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tuleb teha switch,kus esimene case on 10, teine 20 ja kolmas on 30
            //küsitakse numbrit ja sisestad konsooli
            Console.WriteLine("Sisesta number ja vajuta enter:");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 10:
                    Console.WriteLine("Sisestasid number on 10");
                    break;
                case 20:
                    Console.WriteLine("Sisestasid number on 20");
                    break;
                case 30:
                    Console.WriteLine("Sisestasid number on 30");
                    break;
                default:
                    Console.WriteLine("Muu number:" + input);
                    break;

            }
        }
    }
}
