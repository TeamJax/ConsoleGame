namespace TeamJaxConsoleGame.Lib
{
    using Constants;
    using Entities;
    using Enumerations;
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

        protected static void InitializeStartingScene(GameSceneFactory sceneFactory, string locationName, string locationDescription)
        {
            currentScene = sceneFactory.CreateScene(playerHero, locationName, locationDescription);
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
            InitializeStartingScene(new TownSceneFactory(), LocationConstants.INIT_LOCATION_NAME, LocationConstants.INIT_LOCATION_DESCRIPTION);

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
