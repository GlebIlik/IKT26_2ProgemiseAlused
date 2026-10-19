namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");
            //esimeses koondtulemuse puhul on number vahemikus
            //0 kuni 100
            //teisel puhul 101 kuni 200
            //kolmandal 201 kuni 300
            //kasutage switchi
            //parsige tähemärk numbriks

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case >= 0 and 100:
                    Console.WriteLine("Number on vahemikus 0-100");
                    break;

                case >= 101 and 200:
                    Console.WriteLine("Number on vahemikus 101 - 200");
                    break;

                case >= 201 and 300:
                    Console.WriteLine("Number on vahemikus 201 - 300");
                    break;

                default:
                    Console.WriteLine("Number ei ole vahemikus 0-300");
                    break;


            }
        }
    }
}
