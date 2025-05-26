using System.Reflection;

namespace W2InClassAssignment;

public class Book
{
    string title;
    string author;
    int yearPublished;

    public Book (string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nYear Published: {yearPublished}");
    }
    
}