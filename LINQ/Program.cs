// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;


namespace LINQ // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks(); //instantiate the BookRepository called the GetBooks method and get the results.

            //LINQ Extension Methods
            //books.Where();
            //book.single();
            //books.SingleOrDfault();

            //books.First();
            //books.FirstOrDefault();

            //books.Last();
            //books.LastOrDefault();

            //books.Min();
            //books.Max();
            //books.Count();
            //books.Sum();
            //books.Average(b => b.Price);

            //books.Skip(5).Take(3);






            //var totalPrices = books.Sum(b => b.Price);
            //Console.WriteLine(totalPrices);






            //var maxPrice = books.Max(b => b.Price);
            //var minPrice = books.Min(b => b.Price);

            //Console.WriteLine(maxPrice);
            //Console.WriteLine(minPrice);





            //foreach (var pagedBook in pagedBooks)
            //{
            //    Console.WriteLine(pagedBook.Title);
            //}

            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            //Console.WriteLine(book.Title + " " + book.Price);

        }
    }
}


/*
 What is LINQ?
Stands for: Language Inegrated Query

Gives you the capability to query objects

You can query:
1. Objects in memory, eg collections (LINQ to Objects)
2. Databases (LINQ to Entities)
3. XML (LINQ to XML)
4. ADO.NET Data Sets (LINQ to Data Sets)



//LINQ Query Operators
            var cheaperBooks = 
                from b in books 
                where b.Price > 10 
                orderby b.Title
                select b.Title;

            //LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title); 
            
            //Func is a delegate. it points to a method that gets a book as an argument and returns a boolean value and this is what we call a predicate. So the general predicate is to get a book,


            //books.OrderBy(b => b.Title + "" + Book.Price);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + "" + book.Price);

You can use LINQ in a lot of cases and what LINQ does for you or what Entity Framework

does more precisely is it takes this LINQ extension methods and when you call them, it translates them to SQL query.

So you never have to go and create a story procedure.

Again, this is a very comprehensive topic and it's beyond the scope of this video.



 */