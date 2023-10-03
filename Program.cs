using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("List of books in library");

             var keyValueArray = library.books.Select(kvp => new { Key = kvp.Key, Value = kvp.Value }).ToArray();
             if(keyValueArray.Length ==0) Console.WriteLine("None books is in library");
            foreach (var book in keyValueArray)
            {
                Console.WriteLine($"Id: {book.Key}, Title: {book.Value}");
            }
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. Remove Book");
            Console.WriteLine("5. Remove User");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Thêm sách (Add Book)
                   
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    library.AddBook( title);
                    Console.WriteLine("Book added successfully.");
                    break;

                case 2:
                    // Mượn sách (Borrow Book)
                    Console.Write("Enter user ID: ");
                    int userId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter book ID to borrow: ");
                    int bookIdToBorrow = Convert.ToInt32(Console.ReadLine());
                    string result = library.BorrowBook(userId, bookIdToBorrow);
                    Console.WriteLine(result);
                    break;

                case 3:
                    // Trả sách (Return Book)
                    Console.Write("Enter user ID: ");
                    int userIdToReturn = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter book ID to return: ");
                    int bookIdToReturn = Convert.ToInt32(Console.ReadLine());
                    string returnResult = library.ReturnBook(userIdToReturn, bookIdToReturn);
                    Console.WriteLine(returnResult);
                    break;

                case 4:
                    // Xóa sách (Remove Book)
                    Console.Write("Enter book ID to remove: ");
                    int bookIdToRemove = Convert.ToInt32(Console.ReadLine());
                    string removeBookResult = library.RemoveBook(bookIdToRemove);
                    Console.WriteLine(removeBookResult);
                    break;

                case 5:
                    // Xóa người dùng (Remove User)
                    Console.Write("Enter user ID to remove: ");
                    int userIdToRemove = Convert.ToInt32(Console.ReadLine());
                    string removeUserResult = library.RemoveUser(userIdToRemove);
                    Console.WriteLine(removeUserResult);
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

