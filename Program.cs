using System;
using Viajando.Entities;

namespace Viajando
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!"); //Tenha uma boa Viagem
            Comment c2 = new Comment("Woe that´s awesome! "); //ual que legal
            Post p1 = new Post(
                DateTime.Parse("03/10/2019 12:05:44"),
                "Traveling to Brasil",
                "I´m going to visit worderfull country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good NIght!");
            Comment c4 = new Comment("May the force be with you"); // Que a força esteja com você
            Post p2 = new Post(
                DateTime.Parse("03/10/2019 13:05:05"),
                "Good nigth guys ", //Boa noite pessoal
                "See you Tommorow ", // ATÉ AMANHA
                5);


            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
