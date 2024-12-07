namespace LibrarySystem;
internal class Library
{
    private List<Book> Books = new List<Book>();
    private List<Book> BorrowedBooks = new List<Book>();


    public void Add(Book newbook)
    {
        Books.Add(newbook);
        System.Console.WriteLine("Book Is Added Successfully :)");

    }
    public void Remove(string book_title)
    {
        if (Books.Count == 0)
        {
            System.Console.WriteLine("Library is Empty, No Books to remove");
            return;
        }
        if(searchByBookTitle(book_title)){
            foreach(var book in Books){
                if(book.Title==book_title){
                    Books.Remove(book);
                    BorrowedBooks.Remove(book);
                    break;
                }
            }
            System.Console.WriteLine("Book Is Removed Successfully!!");
        }else{
            System.Console.WriteLine($"Your {book_title} is Not Found !!!");
        }
    }
    private bool searchByBookTitle(string book_title)
    {
        foreach (var book in Books)
        {
            if (book.Title == book_title)
                return true;
        }
        return false;
    }
    private bool IsBorrowed(string book_title)
    {
        foreach (var book in BorrowedBooks)
        {
            if (book.Title == book_title)
                return true;
        }
        return false;
    }
    public void Borrow(string book_title)
    {

        
        //1- if book not exist in library
        if (!searchByBookTitle(book_title))
        {
            System.Console.WriteLine($"\tSorry, The Book {book_title} Is Not Exist in Library!!");
            return;
        }

        //2- search in borrowed list if book already is borrowed
        if (IsBorrowed(book_title))
        {
            System.Console.WriteLine($"\tSorry, The Book {book_title} Is Already Borrowed :( ");
        }
        else
        {
            //4- add book in borrowed book list
            foreach (var book in Books)
            {
                if (book.Title == book_title)
                {

                    BorrowedBooks.Add(book);
                }

            }
            System.Console.WriteLine("\tBook Is Borrowed Successfully :)");

        }



    }
    public void Display()
    {
        if (Books.Count == 0)
        {
            System.Console.WriteLine("\tSorry, Library is Empty !!");
            return;
        }
        int i = 1;
        System.Console.WriteLine("\t\t\t#####Display All Books##### ");
        System.Console.WriteLine($"\t\t##Total Number Books In Library is {Books.Count}");
        foreach (var book in Books)
        {
            System.Console.WriteLine($"\t##Book Number {i} In Library");
            System.Console.WriteLine($"\tBook Title: {book.Title}");
            System.Console.WriteLine($"\tBook Author: {book.Author}");
            System.Console.WriteLine($"\tBook Year: {book.Year}");
            System.Console.WriteLine("\t\t-------------------------------------");
            i++;
        }
    }
    public void DisplayBorrowedBooks()
    {
        if (Books.Count == 0)
        {
            System.Console.WriteLine("No Borrow Books Now");
            return;
        }
        int i = 1;
        System.Console.WriteLine("\t\t\t#####Display Borrowed Books#####\n ");
        System.Console.WriteLine($"\t\t##Total Number Borrowed Books In Library is {BorrowedBooks.Count}");
        foreach (var book in BorrowedBooks)
        {
            System.Console.WriteLine($"\t##Book Number {i} In Library");
            System.Console.WriteLine($"\tBook Title: {book.Title}");
            System.Console.WriteLine($"\tBook Author: {book.Author}");
            System.Console.WriteLine($"\tBook Year: {book.Year}");
            System.Console.WriteLine("\t\t-------------------------------------");
            i++;
        }
    }
}
