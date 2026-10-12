namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuueni");
            int randomNumber = new Random().Next(1, 7);
            Console.WriteLine( "Said");
            Console.WriteLine(randomNumber);
           
                
                
           
        }
    }
}
