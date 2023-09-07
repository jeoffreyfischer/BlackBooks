namespace BlackBooks_API.Services;

public class BookService
{
    public List<string> GetAll()
    {
        var allBooks = new List<string>
        {
            "Book 1",
            "Book 2",
            "Book 3",
            "Book 4"
        };
        return allBooks;
    }

    public List<string> Search(string searchTerm)
    {
        var searchedBooks = new List<string>
        {
            $"Book 1 containing { searchTerm }",
            $"Book 2 containing { searchTerm }"
        };
        return searchedBooks;
    }
}