namespace TeamJaxConsoleGame.Lib
{
    using Constants;
    using Entities;
    using Enumerations;
    using Factory;
    using Factory.GameSceneFactory;
    using Factory.HeroFactory;
    using Scenes;
    using ScreenText;
    using System;

    public abstract class GameEngine
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
            string userHeroNameInput;
            HeroType selectedHeroType;
            RaceType selectedHeroRace;
            GameScreen.LoadHearoCreation(out userHeroNameInput, out selectedHeroType, out selectedHeroRace);
            var heroCreater = new HeroCreater();

            playerHero = heroCreater.CreateHero(userHeroNameInput, selectedHeroRace, selectedHeroType);
        }

        private static void Play()
        {
            CreateHero();
            var sceneCreater = new SceneCreater();
            InitializeStartingScene(sceneCreater);
            var selectedSceneType = currentScene.SceneType;

            while (true)
            {
                Console.Clear();
                currentScene.DescribeScene();

                ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();
                bool showInvalidInput = false;

                do
                {
                    if (showInvalidInput)
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    if (selectedSceneType == GameSceneType.Invenotry)
                    {
                        //ASCI Codes chars values:
                        //'0' = 48; '9' = 57; '10' = 58
                        int inventoryInput;
                        
                        while (int.TryParse(Console.ReadLine(), out inventoryInput))
                        {
                            char charRepresentation = (char)(48 + inventoryInput);
                            ConsoleKey keyRepresent;
                            Enum.TryParse<ConsoleKey>(charRepresentation.ToString(), out keyRepresent);
                            keyPressed = new ConsoleKeyInfo(charRepresentation, keyRepresent, false, false, false);
                        }
                    }
                    else
                    {
                        keyPressed = Console.ReadKey();
                    }

                    showInvalidInput = true;

                } while (!currentScene.ValidateUserInput(keyPressed));

                selectedSceneType = currentScene.GetUserSelectedScene(keyPressed);

                currentScene = sceneCreater.CreateScene(selectedSceneType, playerHero, currentScene.CurrentLocation);
            }
            //TODO:think how to change the locations?
            //TODO:ADD EVENT
            //TODO: FIX GAMEENGIGE name :D
            //TODO: EBASI ZMQTA
        }
    }
}

