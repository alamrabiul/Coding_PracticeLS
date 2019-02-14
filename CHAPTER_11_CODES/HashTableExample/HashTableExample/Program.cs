using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    //A Library contains a list of books.
    class Library
    {
        public Hashtable bookList;
        public Library()
        {
            bookList = new Hashtable();
        }
    }
    //Books are placed in the Library
    class Book
    {
        public string Title;
        public int ISBN;

        public Book(string title, int isbn)
        {
            Title = title; ISBN = isbn;
        }
    }
    class ClassMain
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Programming with C#", 0735613702);
            Book book2 = new Book("Inside C#", 0735612889);
            Book book3 = new Book("Microsoft C# Language Specificatons", 0735614482);
            Book book4 = new Book("OOP with C#", 0735615543);

            Library myReferences = new Library();
            myReferences.bookList.Add(book1.ISBN, book1);
            myReferences.bookList.Add(book2.ISBN, book2);
            myReferences.bookList.Add(book3.ISBN, book3);
            myReferences.bookList.Add(book4.ISBN, book4);

            Book book = (Book)myReferences.bookList[0735612889];

            Console.WriteLine(book.Title);
            Console.ReadKey();
        }
    }
}

//Output: Inside C#