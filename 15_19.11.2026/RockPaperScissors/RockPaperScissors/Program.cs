namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kivi paber käärid!");

            Random random = new Random();

            string playerchose = "";
            int playerpoints = 0;
            int pcpoints = 0;

            while (playerchose != "lõpeta")
            {
                Console.WriteLine("Vali: kivi, paber või käärid!");
                Console.WriteLine("Mängu lõpetamiseks kirjuta LÕPETA");
                //ToLower muudab sinu kirjutatud teksti väikesteks tähtedeks
                playerchose = Console.ReadLine().ToLower();

                if (playerchose == "lõpeta")
                {
                    break;
                }

                if (playerchose != "kivi" &&
                    playerchose != "paber" &&
                    playerchose != "käärid")
                {
                    Console.WriteLine("Sellist valikut pole! Proovi uuesti");
                    continue;
                }

                int computernumber = random.Next(1, 4);
                string computerchoice = "";

                if (computernumber == 1)
                {
                    computerchoice = "kivi";
                }
                else if (computernumber == 2)
                {
                    computerchoice = "paber";
                }
                else
                {
                    computerchoice = "käärid";
                }

                Console.WriteLine($"Arvuti valis {computerchoice}");

                if (computerchoice == playerchose)
                {
                    Console.WriteLine("Viik!");
                }
                else if ((playerchose == "kivi" && computerchoice == "käärid") ||
                        (playerchose == "paber" && computerchoice == "kivi") ||
                        (playerchose == "käärid" && computerchoice == "paber"))
                {
                    Console.WriteLine("Sina võitsid!");
                    playerpoints++;
                }
                else
                {
                    Console.WriteLine("Arvuti võitis!");
                    pcpoints++;
                }
                Console.WriteLine($"" +
                    $"Punktid: sinul {playerpoints} ja arvutil {pcpoints}");
                Console.WriteLine("Jätkamiseks vajuta Enter!");
                Console.ReadLine();
            }
            Console.WriteLine("Mäng on läbi!");
            Console.WriteLine($"Lõpptulemus: Sinul on {playerpoints} ja arvutil {pcpoints}");
        }
    }
}
