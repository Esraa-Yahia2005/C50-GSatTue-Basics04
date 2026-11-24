using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3_Roote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
            //the second price(index 1).

            //double[] Prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(Prices[1]);

            #endregion


            #region Question2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
            // shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            int[,] ShelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(ShelfCopies[1, 0]);


            #endregion



            #region Question3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints 
            //"Welcome to the Library!".Call it from Main

            PrintWelcomeMessage();
            #endregion


            #region Question4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
            //"Clean Code".

            PrintBookTitle("Clean Code");


            #endregion

            #region Question5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
            //int pages = 400; and print pages afterward. What do you expect to see, and why?


            AddBonusPages(400);   //450


            #endregion

            #region Question6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
           // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
           //see, and why? 

            ApplyDiscount(new double[] { 25.5, 40.0 });

            #endregion


            #region Question7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. 
            //Call it and print pages afterward. How is the result different from question 5 ?

            int Pages = 400;
            AddBonusPagesByRef(ref Pages);
            Console.WriteLine($"After bonus: Pages = {Pages}");

            #endregion

            #region Question8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a 
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward

            double[] Prices = { 25.5, 40.0, 33.75, 10.0 };
            ReplaceArray(ref Prices);
            Console.WriteLine($"Prices length afterward: {Prices.Length}");


            #endregion


            #region Question9
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets 
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //and print the price if found

           Console.WriteLine(TryGetPrice("Clean Code", out double price));
            Console.WriteLine(price);


            #endregion


            #region Question10
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call 
            //it once with only a title, and once passing both a title and pages.
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 400);

            #endregion

            #region Question11
            //Using the PrintBookInfo method from the question above, call it by naming the 
            //parameters, passing pages before title.

            PrintBookInfo( pages:500 ,title:"Clean Code");
            #endregion


            #region Question12
            //Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. 
            //Call it with three book titles. 

            PrintAllTitles("Clean Code", "Design Patterns", "Refactoring");


            #endregion

        }


        //Question3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        //Question4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }


        //Question5
        static void AddBonusPages(int Pages)
        {
            Console.WriteLine($"After bonus: Pages = { 50+Pages}");
        }


        //Question6
        static void ApplyDiscount(double[] Prices)
        {
            Console.WriteLine($"Prices[0] afterward {Prices[0] - 5}");
        }

        //Question7
        static void AddBonusPagesByRef(ref int Pages)
        {
            Pages = 50 + Pages;
        }

        //Question8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }


        //Question9
       static bool TryGetPrice(string title, out double price)
        { 
            if(title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }

            
        }



        //Question10

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        //Question12
        static void PrintAllTitles(params string[] titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }



    }
}
