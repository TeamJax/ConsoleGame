namespace TeamJaxConsoleGame.Lib.ScreenText
{
    //TODO: Clear unused
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Resources;

    public class GameScreen
    {
        private static int sleepdelay = 50;
            //TODO: move to GameScreenConstants
        private static string logo = File.ReadAllText(@"..\..\Content\TextArt\logo.txt");

        public static void SetScreen()
        {
            //TODO: move to GameScreenConstants
            Console.WindowHeight = 60;
            Console.BufferHeight = 60;
            Console.WindowWidth = 120;
            Console.BufferWidth = 120;
        }

        public static void LoadHearoCreation()
        {
            Console.WriteLine(GameScreenResources.LoadHearoCreation);
        }
        
        public static void LoadLogoIntro()
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
        
        private static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in logo)
            {
                Console.Write(item);
            }
        }

        private static void PrintLogoAnimated()
        {
            List<char> row = new List<char>();
            Console.ForegroundColor = ConsoleColor.Green;
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
    }
}
