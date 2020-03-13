using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XXX
{
    class Program
    {

        static void Main()
        {
            string[] words = File.ReadAllLines(@"C:\Users\Олег\source\repos\Cool\Gallows\world.txt");
            Random rnd = new Random();
            int number = rnd.Next(0, 7);
            string word = words[number];
            int f = 0;
            int k = 0, letters = 0;
            char Letter = ',';
            ConsoleKeyInfo key;

            char[] wordArray = word.ToCharArray();
            Ocnova();
            Console.SetCursorPosition(50, 10);
            Console.WriteLine(words[number + 8]);
            Console.SetCursorPosition(0, 0);

            while (f != 10)
            {
                bool ecti = false;
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Letter = 'a';
                        break;
                    case ConsoleKey.B:
                        Letter = 'b';
                        break;
                    case ConsoleKey.C:
                        Letter = 'c';
                        break;
                    case ConsoleKey.D:
                        Letter = 'd';
                        break;
                    case ConsoleKey.E:
                        Letter = 'e';
                        break;
                    case ConsoleKey.F:
                        Letter = 'f';
                        break;
                    case ConsoleKey.G:
                        Letter = 'g';
                        break;
                    case ConsoleKey.H:
                        Letter = 'h';
                        break;
                    case ConsoleKey.I:
                        Letter = 'i';
                        break;
                    case ConsoleKey.J:
                        Letter = 'j';
                        break;
                    case ConsoleKey.K:
                        Letter = 'k';
                        break;
                    case ConsoleKey.L:
                        Letter = 'l';
                        break;
                    case ConsoleKey.M:
                        Letter = 'm';
                        break;
                    case ConsoleKey.N:
                        Letter = 'n';
                        break;
                    case ConsoleKey.O:
                        Letter = 'o';
                        break;
                    case ConsoleKey.P:
                        Letter = 'p';
                        break;
                    case ConsoleKey.Q:
                        Letter = 'q';
                        break;
                    case ConsoleKey.R:
                        Letter = 'r';
                        break;
                    case ConsoleKey.S:
                        Letter = 's';
                        break;
                    case ConsoleKey.T:
                        Letter = 't';
                        break;
                    case ConsoleKey.U:
                        Letter = 'u';
                        break;
                    case ConsoleKey.V:
                        Letter = 'v';
                        break;
                    case ConsoleKey.W:
                        Letter = 'w';
                        break;
                    case ConsoleKey.X:
                        Letter = 'x';
                        break;
                    case ConsoleKey.Y:
                        Letter = 'y';
                        break;
                    case ConsoleKey.Z:
                        Letter = 'z';
                        break;
                    default:
                        break;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    if (wordArray[i] == Letter)
                    {
                        Console.SetCursorPosition(40 + i, 12);
                        Console.Write(Letter);
                        letters++;
                        ecti = true;
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        Console.SetCursorPosition(0, 0);
                    }
                }
                if (letters == word.Length) { Console.Clear(); Console.SetCursorPosition(14, 7); Console.WriteLine($"YOU GUESSED! YOUR WORD IS {word}"); }
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                Console.SetCursorPosition(0, 0);
                if (!ecti)
                {
                    k++;
                    switch (k)
                    {
                        case 1: Golova(); break;
                        case 2: LRyka(); break;
                        case 3: RRyka(); break;
                        case 4: Telo(); break;
                        case 5: LNoga(); break;
                        case 6: RNoga(); break;
                        case 7:
                            Console.Clear(); Console.SetCursorPosition(14, 7); Console.WriteLine("YOU ARE DIE!");
                            Console.SetCursorPosition(14, 8); Console.WriteLine($"YOUR WORD IS {word}! )))"); break;
                    }

                }
                Console.SetCursorPosition(0, 0);
            }

        }
        static void Ocnova()
        {
            for (int i = 16; i > 2; i--)
            {
                Console.SetCursorPosition(13, i);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(14, 2);
            Console.WriteLine(new string('-', 20));
            for (int i = 6; i > 2; i--)
            {
                Console.SetCursorPosition(33, i);
                Console.WriteLine("|");
            }
        }
        static void Golova()
        {
            Console.SetCursorPosition(32, 7);
            Console.Write("(");
            Console.SetCursorPosition(34, 7);
            Console.Write(")");
            Console.SetCursorPosition(33, 7);
            Console.Write("_");
        }
        static void Telo()
        {
            for (int i = 8; i < 10; i++)
            {
                Console.SetCursorPosition(33, i);
                Console.Write("|");
            }
        }
        static void LRyka()
        {
            Console.SetCursorPosition(32, 8);
            Console.Write("/");
        }
        static void RRyka()
        {
            Console.SetCursorPosition(34, 8);
            Console.Write("\\");
        }
        static void LNoga()
        {
            Console.SetCursorPosition(32, 10);
            Console.Write("/");
        }
        static void RNoga()
        {
            Console.SetCursorPosition(34, 10);
            Console.Write("\\");
        }
    }
}

