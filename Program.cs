using System;

namespace _07222020_powertableslab_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameEnd = false;
            Console.WriteLine("Do you want to see the square and cube results of an integer? (Y/N)");
            gameEnd = ContinuePlay("");
            while (gameEnd == false)
            {
                int input = Validate("Please input an integer to be squared and cubed!");
                CubeSquare(input);
                gameEnd=ContinuePlay("Do you want to see another integer squared and cubed (Y/N)?");
            }
          
        }
        public static int Validate(string message)
        {
            int number = 0;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out number))
            { 
                Console.BackgroundColor=ConsoleColor.Red; Console.Beep(800,500); Console.Beep(600, 750); Console.Beep(400, 1500);
                Console.WriteLine("Please enter a valid integer");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            return number;
        }
        public static bool ContinuePlay(string message)
        {
            bool end = false;
            string cont = "";
            Console.WriteLine(message);
            while (cont.ToLower() != "n")
            {
                cont = Console.ReadLine().ToLower();
                if (cont == "y")
                {
                    end = false;
                    break;
                }
                else if (cont == "n")
                {
                    end = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter (y) to square/cube a number and (n) to stop.");
                }
            }return end;
        }
        public static void CubeSquare(int input)
        {
            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t=======");
            for(int i = 1; i<=input;i++)
            {
                Console.WriteLine($"{i}\t\t{i * i}\t\t{i * i * i}");
            }
        }
        public static void MarioTheme()
        {
            Console.Beep(659, 250);
            Console.Beep(659, 250);
            Console.Beep(659, 300);
            Console.Beep(523, 250);
            Console.Beep(659, 250);
            Console.Beep(784, 300);
            Console.Beep(392, 300);
            Console.Beep(523, 275);
            Console.Beep(392, 275);
            Console.Beep(330, 275);
            Console.Beep(440, 250);
            Console.Beep(494, 250);
            Console.Beep(466, 275);
            Console.Beep(440, 275);
            Console.Beep(392, 275);
            Console.Beep(659, 250);
            Console.Beep(784, 250);
            Console.Beep(880, 275);
            Console.Beep(698, 275);
            Console.Beep(784, 225);
            Console.Beep(659, 250);
            Console.Beep(523, 250);
            Console.Beep(587, 225);
            Console.Beep(494, 225);
        }
    }
}
