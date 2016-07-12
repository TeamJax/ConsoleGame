namespace TeamJaxConsoleGame.Lib.ScreenText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;

    using Resources;
    using Enumerations;

    public class GameScreen
    {
        private static int sleepdelay = 50;
            //TODO: move to GameScreenConstants
        private static string logo = File.ReadAllText(@"..\..\Content\TextArt\logo.txt");
        private static string Map = File.ReadAllText(@"..\..\Content\TextArt\MapBigger.txt");

        public static void SetScreen()
        {
            //TODO: move to GameScreenConstants
            //Console.WindowHeight = 60;
            //Console.BufferHeight = 60;
            //Console.WindowWidth = 120;
            //Console.BufferWidth = 120;
        }

        public static void LoadHearoCreation(out string userHeroNameInput, out HeroType selectedHeroType, out RaceType selectedHeroRace)
        {
            Console.WriteLine(GameScreenResources.LoadHearoCreation);
            userHeroNameInput = Console.ReadLine();

            var heroTypeValues = Enum.GetValues(typeof(RaceType));

            var index = 1;
            Console.WriteLine(GameScreenResources.RaceChoice);
            foreach (var item in heroTypeValues)
            {
                Console.Write("{0}: {1}; ", index, item);
                index++;
            }
            Console.WriteLine();

            ConsoleKeyInfo keyPressed;

            do
            {

             keyPressed = Console.ReadKey();

            } while (!char.IsNumber(keyPressed.KeyChar));

            int userChoice = int.Parse(keyPressed.KeyChar.ToString());
            selectedHeroRace = (RaceType)userChoice;

            heroTypeValues = Enum.GetValues(typeof(HeroType)); 

            index = 1;
            Console.WriteLine(GameScreenResources.ClassChoice);
            foreach (var item in heroTypeValues)
            {
                Console.Write("{0}: {1}; ", index, item);
                index++;
            }
            Console.WriteLine();
            
            do
            {

             keyPressed = Console.ReadKey();

            } while (!char.IsNumber(keyPressed.KeyChar));

            userChoice = int.Parse(keyPressed.KeyChar.ToString());
            selectedHeroType = (HeroType)userChoice;
        }
        
        
        public static void PrintMap()
        {
            Console.Clear();
            List<char> row = new List<char>();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in Map)
            {
                Console.Write(item);
            }
        }

        public static void PrintOutput(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("=*********************************************************************=");
            Console.WriteLine(output);
        }

        public static void LoadLogoIntro()
        {
            SetScreen();

            #region PrintLogo

            Console.Clear();
            PrintLogoAnimated(logo);
            //PrintMap();

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

        private static void PrintLogoAnimated(string fileSource)
        {
            List<char> row = new List<char>();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in fileSource)
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
