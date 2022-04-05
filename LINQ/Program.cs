// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks(); //instantiate the BookRepository called the GetBooks method and get the results.

            //if we didn't have LINQ
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if(book.Price < 10)
                    cheapBooks.Add(book);
            }

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + "" + book.Price);
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