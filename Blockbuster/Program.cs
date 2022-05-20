namespace Blockbuster
{
    public class Program
    {
        public static void Main()
        {
            //Movie is abstract and therefore we cannot use its constructor 
            //Since we can't make it directly, how do test our abstract class? 

            //Movie m = new Movie();

            DVD d = new DVD("Shrek 2", 800, Genre.Romance, "Shrek Roars", "Shrek discovers the meaning of life", "They go to waffle house", "Ludacris ending Musical number");
            d.Play();
            d.PrintInfo();
            d.PrintScenes();

            Blockbuster b = new Blockbuster();
            //b.PrintMovies();
            b.Checkout();
        }
    }
}