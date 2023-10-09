namespace Lektion19Sthlm.Classes;

public class Book
{
    public int Id { get; init; }
    public string Title { get; set; }

    public Book(int id, string title) => (Id, Title) = (id, title);
}

public class LambdaMethods
{
    List<Book> Books { get; } = new();

    public LambdaMethods()
    {
        Books.Add(new Book(1, "Dragon Ninja"));
        Books.Add(new Book(2, "Shadow Walker"));
        Books.Add(new Book(3, "Dragon Reborn"));
    }

    public List<Book> Get(Func<Book, bool>? lambda)
    {
        try
        {
            return lambda is null ? Books : Books.Where(lambda).ToList();

            /*if (lambda is null) return Books;
            return Books.Where(lambda).ToList();*/
        }
        catch
        {
            return new List<Book>();
        }
    }
}
