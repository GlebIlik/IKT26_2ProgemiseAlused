namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal To Binary!");

            Console.WriteLine("Sisesta number: ");

            //tuleb kasutada while
            int n = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = "";

            while (n > 0)
            {
                int rem = n % 2;
                binaryNumber = rem + binaryNumber;
                n = n / 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
