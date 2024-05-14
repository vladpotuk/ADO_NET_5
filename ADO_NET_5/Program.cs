using System;
using GameLibrary;
using GameDbContext;

namespace ADO_NET_4_TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameContext())
            {
                
                var game = new Game
                {
                    Name = "The Witcher 3: Wild Hunt",
                    Studio = "CD Projekt Red",
                    Genre = "Action RPG",
                    ReleaseDate = new DateTime(2015, 5, 19)
                };

                context.Games.Add(game);
                context.SaveChanges();

                Console.WriteLine("Гра додана до бази даних.");

                
                Console.WriteLine("Усі ігри у базі даних:");
                foreach (var g in context.Games)
                {
                    Console.WriteLine($"Назва: {g.Name}, Студія: {g.Studio}, Жанр: {g.Genre}, Дата релізу: {g.ReleaseDate.ToShortDateString()}");
                }
            }
        }
    }
}
