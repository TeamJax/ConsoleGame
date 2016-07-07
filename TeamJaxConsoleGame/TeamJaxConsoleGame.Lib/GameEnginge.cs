namespace TeamJaxConsoleGame.Lib
{
    using Entities;
    using Enumerations;
    using Factory;
    using Scenes;
    using ScreenText;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameEnginge
    {
        protected static GameScene currentScene;
        private static Hero playerHero;

        protected static void Start()
        {
            GameScreen.LoadLogoIntro();
            Console.Clear();
            Play();
        }

        //TODO: Move createScene to factory method
        protected static void CreateTownScene()
        {
            //TODO: load locations descriptions, names from some files
            var sceneDescription = "A village whose very buildings emanate with the feel of magic. Around you are the scared looking faces of other young adventurers. You have no idea exactly how it is that you got to this place, but you feel that it is very safe to remain here for some time.";
            var startSceneFactory = new TownFactory();
            var startLocation = new Location("Starting location", sceneDescription, startSceneFactory);
            
            startLocation.LocationObjects.Add(startLocation.LocationFacotry.CreateEnemyEntity());
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { "Inventory", GameSceneType.Invenotry  },
                { "Travel", GameSceneType.Travel  },
                { "Forest", GameSceneType.Forest  },
                { "Shop", GameSceneType.Shop  }
            };

            currentScene = new TownScene(startLocation, playerHero, GameSceneType.Town, menuOptions);
        }

        protected static void CreateHero()
        {
            GameScreen.LoadHearoCreation();
            var userHeroNameInput = Console.ReadLine();
            playerHero = new Hero(userHeroNameInput, RaceType.Human);
        }

        private static void Play()
        {
            CreateHero();
            while (true)
            {
                Console.Clear();
                CreateTownScene();

                //TODO: Move to currentScene.Descibe() -->
                Console.WriteLine(currentScene.CurrentLocation.Describe());
                Console.WriteLine(currentScene.Hero.Describe());
                currentScene.WriteOptionsMenu();
                //TODO:  Move to currentScene.Descibe() <--

                ConsoleKeyInfo keyPressed;
                bool showInvalidInput = false;

                do
                {
                    if (showInvalidInput)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    keyPressed = Console.ReadKey();

                   showInvalidInput = true;


                } while (!currentScene.ValidateUserInput(keyPressed));

                //if (keyPressed.Key == ConsoleKey.D9)
                //{
                //    break;
                //}
                //if (Console.KeyAvailable)
                //{
                //    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                //    while (Console.KeyAvailable) { Console.ReadKey(true); }

                //    System.Threading.Thread.p
                //    switch (keyPressed.Key)
                //    {
                //        //invnetory
                //        case ConsoleKey.D1:
                //            break;

                //        //exit
                //        case ConsoleKey.D9:
                //            return;
                //        default:
                //            break;
                //    }
                //}
            }
        }
    }
}
