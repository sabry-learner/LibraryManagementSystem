namespace LibrarySystem;
internal abstract class User{
    public string Name{set;get;}
    public void DisplayBooks(Library library){
        library.Display();
    }
    
}