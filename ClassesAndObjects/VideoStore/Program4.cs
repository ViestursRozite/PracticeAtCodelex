using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program4
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");//PG raiting is default

            // Testing for task 11
            VideoStore coolStoreName = new VideoStore();
            coolStoreName.AddVideo("The Matrix");
            coolStoreName.AddVideo("The Matrix");
            coolStoreName.AddVideo("Godfather II");
            coolStoreName.AddVideo("Star Wars Episode IV: A New Hope");
            // giving out ratings
            coolStoreName.TakeUsersRating(5, "The Matrix");
            coolStoreName.TakeUsersRating(3, "The Matrix");
            coolStoreName.TakeUsersRating(2, "Godfather II");
            coolStoreName.TakeUsersRating(3, "Star Wars Episode IV: A New Hope");
            coolStoreName.TakeUsersRating(4, "Star Wars Episode IV: A New Hope");
            //Rent out videoes
            Console.WriteLine(coolStoreName.Checkout("The Matrix"));// rent out 1st instance
            Console.WriteLine(coolStoreName.Checkout("The Matrix"));// rent out 2nd instance
            Console.WriteLine(coolStoreName.Checkout("The Matrix"));// nothing should happen
            Console.WriteLine(coolStoreName.Checkout("Godfather II"));//rent out only instance
            Console.WriteLine(coolStoreName.ReturnVideo("The Matrix"));//return 1st instance
            Console.WriteLine(coolStoreName.ReturnVideo("The Matrix"));//return 2nd instance
            Console.WriteLine(coolStoreName.ReturnVideo("The Matrix"));//try returning too many movies
            Console.WriteLine(coolStoreName.ReturnVideo("101 Dalmations"));//return a movie we do not have

            coolStoreName.ListInventory();

            Console.ReadKey();
        }
      
    }
}
