using System.ComponentModel.DataAnnotations;

namespace Täringumäng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täring");

            Random random = new Random();

            Console.WriteLine("Vali voorude kogus:");
            int voorud = Convert.ToInt32(Console.ReadLine());

            int playerScore = 0;
            int pcScore = 0;

            for (int round = 1; round <= voorud ; round++)
            {
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada!");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);

                Console.WriteLine($"Sinu number on {playerRoll}");
                Console.WriteLine($"Arvuti number on {computerRoll}");

               if (playerRoll < computerRoll)
                {
                    Console.WriteLine("Arvuti võitis!");
                    pcScore++;
                }
                else if (playerRoll > computerRoll)
                { 
                    Console.WriteLine("Sa võitsid!");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("Saite sama tulemuse!");
                    pcScore++;
                    playerScore++;
                }
                Console.WriteLine($"Praegune seis: Sina võitsid {playerScore} vooru, arvuti võitis {pcScore} vooru");

            }
            if (playerScore < pcScore)
            {
                Console.WriteLine("Arvuti võitis kogu mängu!");
            }
            else if (playerScore > pcScore)
            {
                Console.WriteLine("Sa võitsid kogu mängu!");
            }
            else
            {
                Console.WriteLine("Saite sama tulemuse!");
            }
        }
    }
}
