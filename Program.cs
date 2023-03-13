
using System;
using System.Collections.Generic;

namespace KnowCheck;

class Program
{
    static void Main(string[] args)
    {

        var LordOfTheRings = new Book();
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Book>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myBook= new Book();

            Console.WriteLine("How many pages does your book have?");
            myBook.pageNumber = Convert.ToInt32(Console.ReadLine());


            recordList.Add(myBook);
            Console.WriteLine("Number of pages: " + myBook.pageNumber);
        }
    }
}
