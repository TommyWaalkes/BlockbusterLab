using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public enum Genre
    {
        Drama, 
        Comedy, 
        Horror, 
        Romance, 
        Action 
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public List<string> Scenes { get; set; }
        public int RunTime { get; set; }
        public Genre Category { get; set; }

        public Movie(string Title, int RunTime, Genre Category, params string[] Scenes)
        {
            this.Title = Title;
            this.RunTime = RunTime;
            this.Category = Category;
            this.Scenes = Scenes.ToList();
        }

        public void PrintInfo()
        {
            Console.WriteLine("Title: "+ Title);
            Console.WriteLine("Run Time: "+ RunTime);
            Console.WriteLine("Category: "+ Category);
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }

        //Play will have no body since it its abstract 
        //Abstract methods make a promise that the children of this class will fill 
        //in the implementation 
        public abstract void Play();

    }
}
