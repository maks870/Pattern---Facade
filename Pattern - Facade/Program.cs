using System;

namespace Pattern___Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveSystem saveSystem = new SaveSystem();
            Spawner spawner = new Spawner(saveSystem);
            LevelLoader loader = new LevelLoader(spawner, saveSystem);
            MusicMixer mixer = new MusicMixer(saveSystem);
            Menu menu = new Menu();
            Physics physics = new Physics();

            GameFacade game = new GameFacade(spawner, loader, mixer, menu, physics);
            Console.WriteLine("Try to load level");
            game.LoadLevel(4);
            Console.WriteLine();
            
            Console.WriteLine("Try to load last checkpoint");
            game.SwitchMenu(true);
            Console.WriteLine("Press load last checkpoint button");
            game.LoadLastCheckpoint();
            Console.WriteLine();

            Console.WriteLine("Try to restartLevel");
            game.SwitchMenu(true);
            Console.WriteLine("Press restart level button");
            game.RestartLevel();

            Console.ReadKey();
        }
    }
}


