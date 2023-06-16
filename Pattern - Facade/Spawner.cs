using System;

class Spawner
{
    private SaveSystem saveSystem;

    public Spawner(SaveSystem saveSystem)
    {
        this.saveSystem = saveSystem;
    }

    public void SpawnPlayer()
    {
        Console.WriteLine("Spawn player");
    }

    public void SpawnPlayer(string point)
    {
        Console.WriteLine($"Spawn player in point {point}");
    }

    public void SpawnEnemies()
    {
        Console.WriteLine("Spawn enemy");
    }
}


