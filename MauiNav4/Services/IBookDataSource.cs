using MauiNav4.Models;

namespace MauiNav4.Services;

public interface IBookDataSource
{
    IEnumerable<Book> GetBooks();
    void SaveBooks(IEnumerable<Book> books);
}