using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, int RunTime, Genre Category, params string[] Scenes) 
            : base(Title, RunTime, Category, Scenes)
        {
        }

        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch? please input 0 to "+(Scenes.Count -1));
            string input = Console.ReadLine();
            int index = int.Parse(input);
            string scene = Scenes[index];
            Console.WriteLine(scene);
        }
    }
}
