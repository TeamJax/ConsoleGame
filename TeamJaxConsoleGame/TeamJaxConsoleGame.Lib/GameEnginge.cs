namespace TeamJaxConsoleGame.Lib
{
    using Constants;
    using Entities;
    using Enumerations;
    using Factory;
    using Factory.GameScreenFactory;
    using Scenes;
    using ScreenText;
    using System;

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

        protected static void InitializeStartingScene(GameSceneFactory sceneFactory,GameFactory locationFactory)
        {
            var startingLocation = new Location(LocationConstants.INIT_LOCATION_NAME, LocationConstants.INIT_LOCATION_DESCRIPTION, locationFactory);

            startingLocation.LocationObjects.Add(startingLocation.LocationFacotry.CreateEnemyEntity());
            currentScene = sceneFactory.CreateScene(playerHero, startingLocation);
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
            InitializeStartingScene(new TownSceneFactory(), new TownFactory());

            while (true)
            {
                Console.Clear();
                currentScene.DescribeScene();

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


            }
        }
    }
}
