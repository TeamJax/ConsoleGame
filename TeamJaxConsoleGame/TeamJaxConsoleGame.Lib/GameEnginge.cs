namespace TeamJaxConsoleGame.Lib
{
    using Entities;
    using Factory;
    using ScreenText;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameEnginge
    {
        protected static GameScene currentScene;

		protected static void Start()
		{
			GameScreen.BattleCity();
			Console.Clear();
			Play();
		}

        protected static void CreateScene()
        {
            //TODO: load locations descriptions, names from some files
            var sceneDescription = "A village whose very buildings emanate with the feel of magic. Around you are the scared looking faces of other young adventurers. You have no idea exactly how it is that you got to this place, but you feel that it is very safe to remain here for some time.";
            var startSceneFactory = new TownFactory();
            var startLocation = new Location("Starting location", sceneDescription, startSceneFactory);

            startLocation.LocationObjects.Add(startLocation.LocationFacotry.CreateEnemyEntity());

            var sceneHero = new Hero("Current hero name");
            currentScene = new GameScene(startLocation, sceneHero);
        }

        private static void Play()
		{
            CreateScene();
            Console.WriteLine(currentScene.CurrentLocation.Describe());
            Console.WriteLine(currentScene.Hero.Describe());
			//while (true)
			//{
			////	if (Console.KeyAvailable)
			////	{
			////		ConsoleKeyInfo keyPressed = Console.ReadKey(true);
			////		while (Console.KeyAvailable) { Console.ReadKey(true); }
			////		switch (keyPressed.Key)
			////		{
			////			case ConsoleKey.DownArrow:

			////			case ConsoleKey.LeftArrow:

			////			case ConsoleKey.RightArrow:

			////			case ConsoleKey.UpArrow:
			////				if (level != null)
			////					level.Player1.Move(keyPressed.Key);
			////				break;

			////			case ConsoleKey.Spacebar:
			////				if (level != null)
			////				{
			////					level.Player1.Fire();
			////					Sounds.FireWeapon();
			////				}
			////				break;

			////			default:
			////				break;
			////		}
			////	}
			//}
		}
    }
}
