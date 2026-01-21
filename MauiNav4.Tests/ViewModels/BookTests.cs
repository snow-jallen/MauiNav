namespace MauiNav4.Tests.ViewModels;

public class BookTests
{
    [Fact]
    public void PercentageWorks()
    {
        var book = new Book(1, "Test Title", "Test Author", 200, 50);
        Assert.Equal(25, book.PercentRead);
    }

    [Fact]
    public void UpdatePercentageWorks()
    {
        var percentReadChanged = false;
        var book = new Book(1, "Test Title", "Test Author", 200, 50);
        book.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(Book.PercentRead))
            {
                percentReadChanged = true;
            }
        };
        book.PagesRead = 100;
        Assert.True(percentReadChanged);
        Assert.Equal(50, book.PercentRead);
    }
}

   