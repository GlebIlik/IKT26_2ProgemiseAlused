namespace IfElseFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else. Sisesta 1, 2 või mingi muu:");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Sa sisestasid 1");
            }
            else if (input == "2")
            {
                Console.WriteLine("Sa sisestasid 2");
            }
            else
            {
                Console.WriteLine("Sa sisestasid midagi muud");
            }
        }
    }
}
