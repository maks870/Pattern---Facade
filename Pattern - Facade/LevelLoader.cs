using System;

class LevelLoader
{
    private Spawner spawner;
    private SaveSystem saveSystem;

    public LevelLoader(Spawner spawner, SaveSystem saveSystem)
    {
        this.spawner = spawner;
        this.saveSystem = saveSystem;
    }

    public void LoadLevel()
    {
        Console.WriteLine("Load last checkpoint level");
    }

    public void LoadLevel(int level)
    {
        Console.WriteLine($"Load {level} level");
    }

    public void LoadOuterLocation()
    {
        Console.WriteLine("Load outer location");
    }

    public void LoadInnerLocation(int index)
    {
        Console.WriteLine($"Load innet location #{index}");
    }
}


