using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> faveFoods = new List<string>() { "pizza", "alfredo", "chicken", "sushi", "broccoli" };
            //Console.WriteLine(faveFoods[3]);
            //Console.WriteLine(faveFoods[4]);

            ////THIS DOESN'T WORK////
            //List<string> leastFavFoods = new List<string>();
            //leastFavFoods[0] = "Onions";
            //leastFavFoods[1] = "beets";
            //leastFavFoods[2] = "Liver";
            //leastFavFoods[3] = "Banana";
            ////leastFavFoods.Add("Tootsie Rolls");//this won't work. if you have an index, stick to it.

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(13);
            //luckyNumbers.Add(8);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(14);


            //count property

            //List<string> favoriteMovies = new List<string>() { "Big", "Toys", "The Birdcage" };
            //favoriteMovies.Insert(0, "The Big Sick");
            //favoriteMovies.Insert(3, "Dumbo");
            //USING FOR LOOP//
            //for (int counter = 0; counter < favoriteMovies.Count; counter++)
            //{
            //    Console.WriteLine(favoriteMovies[counter]);
            //}

            ////USING FOREACH//
            //foreach (string film in favoriteMovies)
            //{
            //    Console.WriteLine(film);
            //}


            ////REMOVE ITEMS FROM A LIST//
            //favoriteMovies.Remove("Toys");
            //favoriteMovies.Remove("Big");

            //foreach (string movie in favoriteMovies)
            //{
            //    Console.WriteLine(movie);
            //}

            //Create a list
            //add five animals using the .Add()
            //Print each animal in the list

            //List<string> animals = new List<string>();
            //animals.Add("Cat");
            //animals.Add("Dog");
            //animals.Add("Rabbit");
            //animals.Add("Chicken");
            //animals.Add("Pig");
            //animals.Add("Goat");
            //foreach (string mammal in animals)
            //{
            //    Console.WriteLine(mammal);
            //}


            //create the following list
            //list bool list = new List{true, false, false, true, false};
            //loop through each value
            //if the value is true rpint:"Better bring an umbrella"
            //if the value is false print: "No rain today enjoy the sun!"

            //List <bool>list = new List<bool>() { true, false, false, true, false };
            //foreach (bool item in list)
            //{
            //    if (item == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today enjoy the sun!");
            //    }
            //}

            //Create a list with the following numbers: 1, 23, 9, 77, 922, 6, 32, 63, 14, 5
            //use the .Contains() method with the following values 23, 77, 15
            //remove the 4 elements 27, 77, 32, 6
            //use the .Contains() method with the following values 23, 77, 15

            //List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));
            //numbers.Remove(27);
            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));


            //Insert
            //List<int> random = new List<int>() { 9, 26, 21, 54 };
            //random.Insert(0, 440);
            //foreach (int phone in random)
            //{
            //    Console.WriteLine(phone);
            //}
            //come up with an example for how to use each of the method/properties listed in the 
            //Common Properties & Methods section

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();

            int x = 1;
            int y = x;
            x = 10;
            Console.WriteLine(x);
            Console.WriteLine(y);
            
            ///Customer customer1 = new Customer(1);
            ///Customer customer1 = customer1;
            ///Console.WriteLine(customer1.age);
            ///customer2.age=30;
            ///Console.WriteLine(customer1.age);
            ///Console.WriteLine(Customer2.age);
            ///


        }
    }
}
