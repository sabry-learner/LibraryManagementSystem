namespace LibrarySystem;
internal class Librarian : User{
    public Librarian(string Name,int EmployeeNumber)
    {
        this.Name = Name;
        this.EmployeeNumber =EmployeeNumber;
    }
    public int EmployeeNumber{set;get;}
    
    public void AddBook( Book newbook, Library library){
        library.Add( newbook);
    }
    public void RemoveBook(string book_title,Library library){
        library.Remove(book_title);
    }
}