using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Saving Private Ryan", 300, Genre.Drama, "D-Day", "Saluting", "War stuff happens", "They find Matt Damon"));
            Movies.Add(new DVD("Lion King", 102, Genre.Drama, "I can't wait to be king", "Simba blows up the death star", "Scar is a jerk"));
            Movies.Add(new DVD("Billy Madison", 90, Genre.Comedy, "What are looking at swan?", "Billy plays dodgeball", "Decatholon"));

        }

        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"Index: {i}, {m.Title}");
            }
        }

        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Which Movie would you like to watch?");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Movie m = Movies[index];
            m.PrintInfo();
            return m;
        }
    }
}
