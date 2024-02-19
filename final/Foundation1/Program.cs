using System;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._title = "How to build a house";
        v1._author = "Nick Johns";
        v1._lenght = 10.5;

        Comment c1 = new Comment();
        c1._name = "Rosa";
        c1._text = "This is awesome!";     

        Comment c2 = new Comment();
        c2._name = "Amelia";
        c2._text = "Hahahahahahahah";     

        Comment c3 = new Comment();
        c3._name = "Martin";
        c3._text = "No way!";     

        v1.AddEntry(c1);
        v1.AddEntry(c2);
        v1.AddEntry(c3);

        Video v2 = new Video();
        v2._title = "I'm sorry";
        v2._author = "Amelia Brous";
        v2._lenght = 5.5;

        Comment c4 = new Comment();
        c4._name = "Meredith";
        c4._text = "I just can't belive it";     

        Comment c5 = new Comment();
        c5._name = "Derek";
        c5._text = "Maybe another time";     

        Comment c6 = new Comment();
        c6._name = "Cristina";
        c6._text = "I love this video!";

        v2.AddEntry(c4);
        v2.AddEntry(c5);
        v2.AddEntry(c6);

        Video v3 = new Video();
        v3._title = "Creating a new look";
        v3._author = "Nicole Sands";
        v3._lenght = 15.45;

        Comment c7 = new Comment();
        c7._name = "Cristal";
        c7._text = "Maybe next time!";     

        Comment c8 = new Comment();
        c8._name = "Cornelia";
        c8._text = "Woooow, so beautiful!";     

        Comment c9 = new Comment();
        c9._name = "Martina";
        c9._text = "No way this is real!";

        v3.AddEntry(c7);
        v3.AddEntry(c8);
        v3.AddEntry(c9);

        Video v4 = new Video();
        v4._title = "Mistery of a new town";
        v4._author = "Brian Rodriguez";
        v4._lenght = 10.80;

        Comment c10 = new Comment();
        c10._name = "Elisa";
        c10._text = "Cryinggg!!!";     

        Comment c11 = new Comment();
        c11._name = "Lucas";
        c11._text = "What a big town!";     

        Comment c12 = new Comment();
        c12._name = "Carlos";
        c12._text = "I'm screaming!!";

        v4.AddEntry(c10);
        v4.AddEntry(c11);
        v4.AddEntry(c12);
        
        List<Video> videos = new List<Video>(){v1, v2, v3, v4};

        foreach(Video v in videos)
        {
            
            v.DisplayVideo();
            
        }


    }
}