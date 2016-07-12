namespace TeamJaxConsoleGame.Lib
{
    using System;

    using Constants;
    using Entities;
    using Entities.Items;
    using Enumerations;
    using Factory.GameSceneFactory;
    using Factory.HeroFactory;
    using Factory.LocationEntitiesFactory;
    using Scenes;
    using ScreenText;
    using Factory.LocationFactory;
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

        protected static void InitializeStartingScene(SceneCreater sceneCreater, LocationCreater locationCreater)
        {
            var startingLocation = locationCreater.CreateLocation(Locations.Kalimdor);
            startingLocation.LocationObjects.Add(startingLocation.LocationFacotry.CreateEnemyEntity());
            currentScene = sceneCreater.CreateScene(GameSceneType.Town, playerHero, startingLocation);
        }

        protected static void CreateHero()
        {
            string userHeroNameInput;
            HeroType selectedHeroType;
            RaceType selectedHeroRace;
            GameScreen.LoadHearoCreation(out userHeroNameInput, out selectedHeroType, out selectedHeroRace);
            var heroCreater = new HeroCreater();

            playerHero = heroCreater.CreateHero(userHeroNameInput, selectedHeroRace, selectedHeroType);
            playerHero.Items.Add(new Stick("Starting Toqga", 0));
        }

        private static void Play()
        {
            CreateHero();
            var sceneCreater = new SceneCreater();
            var locationCreater = new LocationCreater();
            InitializeStartingScene(sceneCreater, locationCreater);
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
            //TODO:ADD EVENT
        }
    }
}

