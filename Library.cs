class Library
{
    private Dictionary<int, string> books = new Dictionary<int, string>();
    private Dictionary<int, List<int>> users = new Dictionary<int, List<int>>();

    public void AddBook(int bookId, string title)
    {
        books[bookId] = title;
    }

    public string BorrowBook(int userId, int bookId)
    {
        if (books.ContainsKey(bookId))
        {
            if (!users.ContainsKey(userId))
            {
                users[userId] = new List<int>();
            }

            if (users[userId].Contains(bookId))
            {
                return "Book is already borrowed by this user.";
            }

            users[userId].Add(bookId);
            return "Book borrowed successfully.";
        }
        else
        {
            return "Book not found.";
        }
    }
      public string ReturnBook(int userId, int bookId)
    {
        // Kiểm tra điều kiện và thực hiện trả sách
        // ...
        if(users.ContainsKey(userId)){
           if( users[userId].Contains(bookId)){
                users[userId].Remove(bookId);
                return "Book returned successfully";
            }
        }
        return "Book returned failed.";
    }

    public string RemoveBook(int bookId)
    {
        if (books.ContainsKey(bookId))
        {
            books.Remove(bookId);
            return "Book removed successfully.";
        }
        else
        {
            return "Book not found.";
        }
    }

    public string RemoveUser(int userId)
    {
        if (users.ContainsKey(userId))
        {
            if (users[userId].Count == 0)
            {
                users.Remove(userId);
                return "User removed successfully.";
            }
            else
            {
                return "User still has borrowed books. Remove books first.";
            }
        }
        else
        {
            return "User not found.";
        }
    }
}
