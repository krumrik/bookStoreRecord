using System;

public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    static void Main()
    {
        Bookstore book1 = new Bookstore(1, "Berserk", "Kentaro Miura", 30.33);
        Bookstore book2 = new Bookstore(2, "Naruto Box Set", "Masashi Kishimoto", 135.44);
        Bookstore book3 = new Bookstore(3, "One Piece Box Set", "Eiichiro Oda", 195.99);

        DisplayBookInfo(book1);
        DisplayBookInfo(book2);
        DisplayBookInfo(book3);
    }

    static void DisplayBookInfo(Bookstore book)
    {
        Console.WriteLine($"Book ID: {book.ID}");
        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine($"Price: ${book.Price:F2}\n");
    }
}
