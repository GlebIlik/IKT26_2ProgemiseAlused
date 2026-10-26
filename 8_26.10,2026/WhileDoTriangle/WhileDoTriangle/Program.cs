namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            //otsida internetist while koodiga kolmnurga
            //kujundeid e tegemise viise
            //kui kood on leitud, siis kirjuta see siia alla

            while (i <= n)
            {
                int m = 1;
                while (m <= i)
                {
                    Console.Write(m + " ");
                    m++;
                }
                Console.WriteLine();
                i++;

            }
            
            Console.ReadKey();
        }
    }
}
