using System;

class MusicMixer
{
    private SaveSystem saveSystem;

    public MusicMixer(SaveSystem saveSystem)
    {
        this.saveSystem = saveSystem;
    }

    public void ChangeMusicTheme()
    {
        Console.WriteLine($"Play music theme of this level");
    }

    public void ChangeMusicTheme(string songName)
    {
        Console.WriteLine($"Play music theme {songName}");
    }

    public void ChangeGameMusic(bool isOn)
    {
        Console.WriteLine($"Game music is {isOn}");
    }

    public void ChangeMenuMusic(bool isOn)
    {
        Console.WriteLine($"Menu music is {isOn}");
    }

    public void ChangeMusicVolume(int volume = 5)
    {
        if (volume < 0)
            volume = 0;
        else if (volume > 10)
            volume = 10;

        Console.WriteLine($"Music load is {volume}");
    }
}


