using System;
using udemy_cs_StringBuilder.Entities;

namespace udemy_cs_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post p1 = new Post(DateTime.Parse("20/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);
            p1.AddComment(c1);
            p1.AddComment(c2);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.Write(p1.ToString());
            Console.WriteLine();
            Console.WriteLine(p2.ToString());


        }
    }
}
