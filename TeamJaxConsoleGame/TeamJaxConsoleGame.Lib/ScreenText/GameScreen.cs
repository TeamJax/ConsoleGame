namespace TeamJaxConsoleGame.Lib.ScreenText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class GameScreen
    {
        private static int sleepdelay = 50;
        private static string logo = File.ReadAllText(@"..\..\Content\TextArt\logo.txt");

        public static void SetScreen()
        {
            Console.WindowHeight = 60;
            Console.BufferHeight = 60;
            Console.WindowWidth = 120;
            Console.BufferWidth = 120;
        }

        //public static void SetLevelScreen()
        //{
        //    Console.WindowHeight = 44;
        //    Console.BufferHeight = 44;
        //    Console.WindowWidth = 66;
        //    Console.BufferWidth = 66;
        //}

        private static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            foreach (var item in logo)
            {
                Console.Write(item);
            }
        }

        private static void PrintLogoAnimated()
        {
            List<char> row = new List<char>();
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in logo)
            {
                if (item == '\n')
                {
                    foreach (var symbol in row)
                    {
                        Console.Write(symbol);
                    }
                    Thread.Sleep(sleepdelay);
                    row.Clear();
                }
                else
                {
                    row.Add(item);
                }
            }
        }

        public static void BattleCity()
        {
            SetScreen();

            #region PrintLogo

            Console.Clear();
            PrintLogoAnimated();

            #endregion PrintLogo

            Thread.Sleep(sleepdelay);

            #region PRESS ANY KEY

            for (int i = 50; i > 24; i = i - 2)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(47, i + 2);
                Console.WriteLine("PRESS ANY KEY TO START");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(47, i);
                Console.WriteLine("PRESS ANY KEY TO START");

                Thread.Sleep(sleepdelay);
            }

            #endregion PRESS ANY KEY

            Console.ReadKey(true);
        }
    }
}
