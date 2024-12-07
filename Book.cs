namespace LibrarySystem;
internal class Book
{
    public string Title { set; get; }
    public string Author { set; get; }
    public int Year { set; get; }
    public void AddBookDetails()
    {
        System.Console.WriteLine("\n\t\t=> Plz Enter Book Info :-");
        System.Console.Write("\tEnter Title: ");
        Title = Console.ReadLine();
        System.Console.Write("\tEnter Author: ");
        Author = Console.ReadLine();
        System.Console.Write("\tEnter Year: ");
        Year = int.Parse(Console.ReadLine());
        System.Console.WriteLine("############");

    }
}