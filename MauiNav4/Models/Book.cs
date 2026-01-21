using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiNav4.Models;

public partial class Book : ObservableObject
{
    public int Id { get; }
    public int NumPages { get; }

    [ObservableProperty]
    private string title;
    [ObservableProperty]
    private string author;
    [ObservableProperty, NotifyPropertyChangedFor(nameof(PercentRead))]
    private int pagesRead;
    public int PercentRead => (int)((double)PagesRead / NumPages * 100);
    public Book(int id, string title, string author, int numPages, int pagesRead = 0)
    {
        Id = id;
        Title = title;
        Author = author;
        NumPages = numPages;
        PagesRead = pagesRead;
    }
}
