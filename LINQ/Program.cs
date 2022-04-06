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
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title); 
            
            //Func is a delegate. it points to a method that gets a book as an argument and returns a boolean value and this is what we call a predicate. So the general predicate is to get a book,


            //books.OrderBy(b => b.Title + "" + Book.Price);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + "" + book.Price);

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


 */