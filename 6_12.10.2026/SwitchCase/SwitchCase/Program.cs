namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta vokaal ja vajuta enter");
            
            string vokaal = Console.ReadLine();

            switch (vokaal)
            {
                case "a":
                    Console.WriteLine("sisestasid vokaali a");
                    break;
                case "e":
                    Console.WriteLine("sisestasid vokaali e");
                    break;
                case "i":
                    Console.WriteLine("sisestasid vokaali i");
                    break;
                default:
                    Console.WriteLine("Sisestatud täht ei ole vokaal");
                    break;
            }
        }
    }
}
