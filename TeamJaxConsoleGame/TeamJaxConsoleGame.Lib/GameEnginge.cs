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
        private static Hero playerHero;
        protected static GameScene currentScene;

        protected static void Start()
        {
            GameScreen.LoadLogoIntro();
            Console.Clear();
            Play();
        }

        protected static void InitializeStartingScene(SceneCreater sceneCreater)
        {
            GameFactory locationFactory = new TownFactory();
            var startingLocation = new Location(LocationConstants.INIT_LOCATION_NAME, LocationConstants.INIT_LOCATION_DESCRIPTION, locationFactory);

            startingLocation.LocationObjects.Add(startingLocation.LocationFacotry.CreateEnemyEntity());
            currentScene = sceneCreater.CreateScene(GameSceneType.Town, playerHero, startingLocation);// sceneFactory.CreateScene(playerHero, startingLocation);
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
            var sceneCreater = new SceneCreater();
            InitializeStartingScene(sceneCreater); // new TownSceneFactory(), new TownFactory());

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

                GameSceneType selectedScene = currentScene.GetUserSelectedScene(keyPressed);
                
                currentScene = sceneCreater.CreateScene(selectedScene, playerHero, currentScene.CurrentLocation);

                //TODO:think how to change the locations?

            }
        }
    }
}
