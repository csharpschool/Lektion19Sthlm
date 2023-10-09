using Lektion19Sthlm.Classes;

namespace Lektion19Sthlm.Exceptions;

public class BookException : ArgumentNullException
{
    //public string Message { get; init; }
    public Book? Book { get; init; }
    public BookException(string message, Book? book = null) : base(message)
    {
       Book = book;
    }
}
