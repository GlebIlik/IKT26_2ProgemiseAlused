namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int nr = int.Parse(Console.ReadLine());
            int i = 1;
            //see on iteratsioon e tsükkel, mis toimub 
            //nii kaua, kui vastab tingimustele
            do
            {
                Console.WriteLine(i);
                //++ suurendab ühe võrra väärtust
                i++;
                Thread.Sleep(500);

            } while (i <= nr);
        }
    }
}
