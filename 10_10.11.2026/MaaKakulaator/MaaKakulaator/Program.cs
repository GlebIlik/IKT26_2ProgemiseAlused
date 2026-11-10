namespace MaaKakulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //Meil on münt, mille diameeter on 25,75mm
            //Arvuta välja Maa ümbermõõt ja mitu münti
            //Mahub järjestiku ümber Maa
            //Arvutuses tohib kasutada aintlt mündi diameetrit ja Maa raadiust (6371km)

            //Teisendan meetriteks
            double raadius_m = 6371000;
            double ümbermõõt_m = 2 * Math.PI * raadius_m;
            double ümbermõõt_km = ümbermõõt_m / 1000;

            double mündisuurus_m = 0.02575;
            double vastus = ümbermõõt_m / mündisuurus_m;

            Console.WriteLine("Maa ümbermõõt on umbes " + Math.Round(ümbermõõt_km, 2) + " kilomeetrit");
            Console.WriteLine("Maa ümber mahub järjestiku umbes " + Math.Round(vastus, 0) + " münti");

        }
    }
}
