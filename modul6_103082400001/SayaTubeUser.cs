using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string username)
    {
        // PRECONDITION
        if (username == null || username.Length > 100)
        {
            throw new ArgumentException("Username tidak valid");
        }

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        // PRECONDITION
        if (video == null)
        {
            throw new ArgumentException("Video tidak boleh null");
        }

        if (video.GetPlayCount() == int.MaxValue)
        {
            throw new ArgumentException("Play count video sudah maksimum");
        }

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;

        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }

        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + Username);

        // POSTCONDITION (maks 8 video)
        int max = Math.Min(8, uploadedVideos.Count);

        for (int i = 0; i < max; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].GetTitle());
        }
    }
}