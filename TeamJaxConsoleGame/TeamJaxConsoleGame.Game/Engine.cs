namespace TeamJaxConsoleGame.Game
{
    using System;

    /// <summary>
    /// A class that runs the main game loop.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Runs the main game loop - accepts user input, parses the input and executes the command.
        /// </summary>
        public void Run()
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine("Game Running");
                var command = Console.ReadLine();

                if (command == "exit")
                {
                    gameRunning = false;
                }
            }
        }
    }
}
