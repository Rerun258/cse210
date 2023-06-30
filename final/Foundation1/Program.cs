using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> vidList = new List<Video>();

        Video vid1 = new Video("vid1", "james", 120, "john", "well made good job");
        Video vid2 = new Video("vid2", "peter", 190, "buster", "rad vidio dude!");
        Video vid3 = new Video("vid3", "michale", 62, "knuckuls", "great just punch him already");
        Video vid4 = new Video("vid4", "Goliath", 2020, "David", "hey who gave you permission to post this");
        vidList.Add(vid1);
        vidList.Add(vid2);
        vidList.Add(vid3);
        vidList.Add(vid4);


        
    }
}