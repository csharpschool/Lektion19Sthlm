using Lektion19Sthlm.Exceptions;

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
            if (lambda is null)
                throw new BookException("The lambda expression is null.");

            return Books.Where(lambda).ToList();

            //return lambda is null ? Books : Books.Where(lambda).ToList();

            /*if (lambda is null) return Books;
            return Books.Where(lambda).ToList();*/
        }
        catch (BookException) { throw; }
        catch
        {
            return new List<Book>();
        }
        
    }

    public void TestTryCatch()
    {
        try
        {

        }
        catch (Exception)
        {
            
        }
    }
}
