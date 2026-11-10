namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tuleb kasutada while ja omakorda while sisse panna while
            //while nesting
            //while kordab ennast 5 korda
            int i = 1;

            
                while (i <= 5)
                {
                    Console.WriteLine("Tsükkel läheb " + i + ". korda");

                    int m = 1;

                    while (m <= 5)
                    {
                        Console.WriteLine("Sisemine tsükkel läheb " + m + ". korda" );


                        m++;
                    }


                    i++;
                }
            }
        }

    }
