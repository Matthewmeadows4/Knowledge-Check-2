using System;

namespace KnowCheck;


public class Book
{
    public int pageNumber { get; set; }

    public Book()
    {
        this.pageNumber = 0;

    }
}

public class Novel : Book
{
    public Novel()
    {
        this.pageNumber = 0;
    }
}
