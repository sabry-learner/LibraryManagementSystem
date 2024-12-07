namespace LibrarySystem;
internal class LibraryUser:User{
    public LibraryUser(string Name,LibraryCard Card)
    {
        this.Name=Name;
        this.Card=Card;
    }
    public LibraryCard Card{set;get;}
    public void BorrowBook(string book_title,Library library){
        library.Borrow( book_title);
    }
    public void DisplayBorrowedBooks(Library library){
        library.DisplayBorrowedBooks();
    }
    
}