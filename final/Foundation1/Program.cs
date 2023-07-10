using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> vidList = new List<Video>();

        Video vid1 = new Video("vid1", "james", 120);
        vid1.addcomment("john", "nicely done");
        vid1.addcomment("josh", "i am way to tired for this");
        vid1.addcomment("benji", "well good job");
        vid1.addcomment("chloe", "very offensive to my people");

        Video vid2 = new Video("vid2", "peter", 190);
        vid2.addcomment("devin", "eh could have made it better");
        vid2.addcomment("ben", "well done could i try this?");
        vid2.addcomment("lucifer", "you all shall die");
        vid2.addcomment("zuse", "hey this offends the greek godesses");
        vid2.addcomment("steven", "ive already bought 10");

        Video vid3 = new Video("vid3", "michale", 62);
        vid3.addcomment("izuku", "allmight would love this");
        vid3.addcomment("doc oc", "this will help me in my upcoming battel with the spiderman --EDIT-- battle with wife");
        vid3.addcomment("jeff bezos", "whats going on in the comment section?");

        Video vid4 = new Video("vid4", "Goliath", 2020);
        vid4.addcomment("steve", "what a nice story");
        vid4.addcomment("david", "i really like the ending there is a lot to learn");
        vid4.addcomment("Goliathsmom128", "how could you post this my poor baby");
        vid4.addcomment("goliath2842", "maw please thats a different Goliath im still alive stop posting on every Goliath Vidio.");
        vid4.addcomment("allmight", "thats a true hero!");

        vidList.Add(vid1);
        vidList.Add(vid2);
        vidList.Add(vid3);
        vidList.Add(vid4);

        foreach(Video video in vidList){
            video.display();
        }
        
    }
}