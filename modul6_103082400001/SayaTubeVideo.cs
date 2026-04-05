using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // PRECONDITION
        if (title == null || title.Length > 200)
        {
            throw new ArgumentException("Judul tidak valid");
        }

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // PRECONDITION
        if (count < 0 || count > 25000000)
        {
            throw new ArgumentException("Input play count tidak valid");
        }

        // EXCEPTION (overflow)
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada play count!");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}