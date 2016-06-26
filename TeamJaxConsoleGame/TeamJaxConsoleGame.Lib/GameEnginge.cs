namespace TeamJaxConsoleGame.Lib
{
    using ScreenText;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameEnginge
    {
		protected static void Start()
		{
			GameScreen.BattleCity();
			Console.Clear();
			//Play();
		}
    }
}
