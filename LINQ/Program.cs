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
            var cheapBooks = books.Where(books => books.Price < 10); //Func is a delegate. It points It points to a method that gets a book as an argument and returns a boolean value and this is what we call a predicate. So the general predicate is to get a book,


            //if we didn't have LINQ
            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
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