
using LibrarySystem;
Library library = new();
while (true)
{
    System.Console.WriteLine("\t\t\t##Welcome To Library System :)##");
    System.Console.WriteLine("\t\t\t1- Start");
    System.Console.WriteLine("\t\t\t2- Exit");
    System.Console.Write("\t\tEnter Your Choice : ");
    char ch = Console.ReadLine()[0];
    if (ch == '1')
    {
        System.Console.WriteLine("##Welcome To Library System :)##");
        System.Console.Write("Are You Librarian Or Regular User (L / R)? ");
        char choice = Console.ReadLine().ToUpper()[0];



        switch (choice)
        {
            case 'L':
                {
                    System.Console.Write("Welcome Librarian, Plz Enter Your Name: ");
                    string librarianName = Console.ReadLine();
                    System.Console.Write("Plz Enter Employee Number: ");
                    int EmployeeNumber = int.Parse(Console.ReadLine());
                    Librarian librarianUser = new Librarian(librarianName, EmployeeNumber);
                    System.Console.WriteLine($"Welcome, {librarianUser.Name} ");
                    while (true)
                    {
                         System.Console.WriteLine("\t\t\t###############Librarian Menu Options#########################");
                        System.Console.WriteLine("\t\tPlz Choose From These Options : ");
                        System.Console.WriteLine("\t\t\t1- Add New Book");
                        System.Console.WriteLine("\t\t\t2- Remove Book");
                        System.Console.WriteLine("\t\t\t3- Display Books");
                        System.Console.WriteLine("\t\t\t4- Back ");
                        System.Console.Write("\tEnter Your Option: ");
                        char option = Console.ReadLine()[0];
                        if (option == '1')
                        {
                            Book newbook = new Book();
                            newbook.AddBookDetails();
                            librarianUser.AddBook(newbook, library);
                        }
                        else if (option == '2')
                        {

                            System.Console.WriteLine("\n\t\t==> Plz Enter Book Title To Remove The Book : ");
                            string bookTitle = Console.ReadLine();
                            librarianUser.RemoveBook(bookTitle, library);
                        }
                        else if (option == '3')
                        {
                            librarianUser.DisplayBooks(library);
                        }
                        else if (option == '4')
                        {
                            System.Console.WriteLine("\t\tGoing Back!!");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("\t\tInvalid Input, try again!!");
                        }

                    }
                    break;
                }
            case 'R':
                {

                    System.Console.WriteLine("\t\t########################################");
                    System.Console.WriteLine("\n\n\t\t\tWelcome Library User , Plz Enter Your Name: ");
                    string userName = Console.ReadLine();
                    System.Console.Write("\t=>Plz Enter Card Number: ");
                    LibraryCard card = new LibraryCard(int.Parse(Console.ReadLine()));
                    LibraryUser User = new LibraryUser(userName, card);
                    System.Console.WriteLine($"\t\tWelcome, {User.Name} ");
                    while (true)
                    {
                        System.Console.WriteLine("\t\t\t###############User Menu Options#########################");
                        System.Console.WriteLine("\t\tPlz Choose From These Options : ");
                        System.Console.WriteLine("\t\t\t1- Borrow Book");
                        System.Console.WriteLine("\t\t\t2- Display Books");
                        System.Console.WriteLine("\t\t\t3- Display Borrowed Books");
                        System.Console.WriteLine("\t\t\t4- Back ");
                        System.Console.Write("\tEnter Your Option: ");
                        char option = Console.ReadLine()[0];
                        if (option == '1')
                        {

                            System.Console.Write("\tPlz Enter Book Title To Borrow Book : ");
                            string bookTitle = Console.ReadLine();
                            User.BorrowBook(bookTitle, library);
                        }
                        else if (option == '2')
                        {
                            User.DisplayBooks(library);
                        }
                        else if (option == '3')
                        {
                            User.DisplayBorrowedBooks(library);
                        }
                        else if (option == '4')
                        {
                            System.Console.WriteLine("\t\tGoing Back!!");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("\t\tInvalid Input, try again!!");
                        }
                    }
                    break;
                }
            default:
                System.Console.WriteLine("\t\tInvalid Input, Try Again Plz !!");
                break;
        }
    }
    else if (ch == '2')
    {
        System.Console.WriteLine("\t\tThanks For Using My App :)");
        break;
    }
    else
    {
        System.Console.WriteLine("\t\tInvalid Input, Try Again Plz !!");
    }

}
// Notes!!
//1- handel borrow operation #####
//2- handel remove by one property ####
//3- enhance user interface     ####
//4- handel display by user #######
//5- add search function to make user search on specefic book by title 
//6- upload project on github 
