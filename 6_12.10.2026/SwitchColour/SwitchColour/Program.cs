namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kasutada switchi 
            //Sisestab värvi nime
            //Red, Blue, Green, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli + teksti
            //kui sisestatakse muu värv, siis näitab "värv puudub"
            
            Console.WriteLine("Sisesta värv ja vajuta enter");

            string värv = Console.ReadLine();

            switch (värv)
            {
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Valisid sinise värvi");
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valisid punase värvi");
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valisid roheline värvi");
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Valisid valget värvi");
                    break;
                case "Orange":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Valisid orandži värvi");
                    break;
                default:
                    Console.WriteLine("Värv puudub");
                    break;
                }

            }
    }
}
