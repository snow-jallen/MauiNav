using MauiNav4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MauiNav4.Services;

public class BookDataSource : IBookDataSource
{
    private readonly List<Book> books = new();

    public IEnumerable<Book> GetBooks()
    {
        if(Preferences.Default.ContainsKey("books"))
        {
            var booksJson = Preferences.Default.Get("books", string.Empty);
            var savedBooks = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(booksJson);
            if (savedBooks != null)
            {
                books.Clear();
                books.AddRange(savedBooks);
            }
        }
        return books;
    }

    public void SaveBooks(IEnumerable<Book> books)
    {
        this.books.Clear();
        this.books.AddRange(books);
        var json = JsonSerializer.Serialize(books);
        Preferences.Set("books", json);
    }
}
