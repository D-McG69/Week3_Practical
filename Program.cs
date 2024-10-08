class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayBooks()
    {
        // Output the book info to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book.Title: {Title}");
        Console.WriteLine($"Book.Author: {Author}");
        Console.WriteLine($"Book.ISBN: {ISBN}");
        Console.WriteLine($"Number of Pages: {NoOfPages}");
    }

    static void Main(string[] args)
    {
        // create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456789";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "6904200";
        book2.NoOfPages = 50;

        // Output book info to the console
        book.DisplayBooks();
        book2.DisplayBooks();


        //Output for Book2 info to the console

        /*Console.WriteLine($"Book.Title: {book2.Title}");
        Console.WriteLine($"Book.Author: {book2.Author}");
        Console.WriteLine($"Book.ISBN: {book2.ISBN}");*/
    }
}
