namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        //tuleb teha switch valik, kas *,/,+,-
        //tuleb teha 4 case kus toimub sooovitud tehe
        //peab näitama tehete tulemuset
        //kasutage floati pärsimisel
        //tuleb teha lihtne kalkulaator
        {
            Console.WriteLine("Sisesta esimene number!");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: *,/,+,-");
            string input = Console.ReadLine();

            Console.WriteLine("Sisesta teine number!");
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vastus on:");
            switch (input)
            {
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;

                case "+":
                    Console.WriteLine(number1 + number2);
                    break;

                case "-":
                    Console.WriteLine(number1 - number2);
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("0-ga jagada ei saa");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(number1 / number2);
                        break;
                    }
                default:
                    Console.WriteLine("Vale märk!");
                    break;

            }
        }
    }
}
