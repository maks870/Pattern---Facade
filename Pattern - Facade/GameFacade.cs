using System;

class GameFacade
{
    private Spawner spawner;
    private LevelLoader loader;
    private MusicMixer mixer;
    private Menu menu;
    private Physics physics;

    public GameFacade(Spawner spawner, LevelLoader loader, MusicMixer mixer, Menu menu, Physics physics)
    {
        this.spawner = spawner;
        this.loader = loader;
        this.mixer = mixer;
        this.menu = menu;
        this.physics = physics;
    }

    public void SwitchMenu(bool isOn)
    {
        if (isOn)
        {
            Console.WriteLine("Opening menu");
            physics.SetTimeSpeed(0);
            mixer.ChangeGameMusic(false);
            mixer.ChangeMenuMusic(true);
            menu.Open();
        }
        else
        {
            Console.WriteLine("Closing menu");
            physics.SetTimeSpeed(1);
            mixer.ChangeGameMusic(true);
            mixer.ChangeMenuMusic(false);
            menu.Close();
        }
    }

    public void LoadLevel(int levelLoad)
    {
        loader.LoadLevel(levelLoad);

        spawner.SpawnPlayer();
        spawner.SpawnEnemies();

        mixer.ChangeMenuMusic(false);
        mixer.ChangeGameMusic(true);
        mixer.ChangeMusicTheme();
    }

    public void LoadLastCheckpoint()
    {
        loader.LoadLevel();
        spawner.SpawnPlayer("Last checkpoint place");
        spawner.SpawnEnemies();

        mixer.ChangeMenuMusic(false);
        mixer.ChangeGameMusic(true);
        mixer.ChangeMusicTheme($"Music theme of last checkpoint moment");
    }

    public void RestartLevel()
    {
        SwitchMenu(false);
        spawner.SpawnPlayer();
        spawner.SpawnEnemies();

        mixer.ChangeMusicTheme();
    }

    public void ChangeLocation(bool isOuter, int index)
    {
        if (isOuter)
            loader.LoadOuterLocation();
        else
            loader.LoadInnerLocation(index);

        spawner.SpawnPlayer("Location enter/exit point");
        mixer.ChangeMusicTheme("Current location theme");
    }

}


