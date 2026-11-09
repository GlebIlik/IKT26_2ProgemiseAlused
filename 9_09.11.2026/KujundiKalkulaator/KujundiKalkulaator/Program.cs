using System.Net.NetworkInformation;

namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui ruudu sees asub ring. Sisesta ringi raadius:");
            //Ruudu sees asub ring. Ringi raadius on 3ü
            //Leia ja väljasta ekraanile ruudu pindala ja ümberõõt
            
            double raadius = double.Parse(Console.ReadLine());
            double diameeter = raadius * 2;
            double pindala1 = Math.Pow(diameeter, 2);
            double ümbermõõt1 = diameeter * 4;


            Console.WriteLine("Ruudu ümbermõõt on " + Math.Round(ümbermõõt1, 2) + " ühikut");
            Console.WriteLine("Ruudu pindala on " + Math.Round(pindala1, 2) + " ühikut");

            //Arvuta ringi pindala ja ümbermõõt
            double pindala2 = Math.PI * Math.Pow(raadius, 2);
            double ümbermõõt2 = 2 * Math.PI * raadius;

            //Kuidas ümardada 2 komakohani
            Console.WriteLine("Ringi ümbermõõt on " + Math.Round(ümbermõõt2, 2) + " ühikut");
            Console.WriteLine("Ringi pindala on " + Math.Round(pindala2, 2) + " ühikut");

        }
    }
}
