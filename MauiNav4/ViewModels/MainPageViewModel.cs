using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiNav4.Models;
using MauiNav4.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MauiNav4.ViewModels;


public partial class MainPageViewModel : ObservableObject
{
    private readonly IBookDataSource dataSource;

    public MainPageViewModel(IBookDataSource dataSource)
    {
        this.dataSource = dataSource;
        foreach(var book in dataSource.GetBooks())
        {
            Books.Add(book);
        }
    }

    public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

    public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

    [RelayCommand]
    void AddBook()
    {
        var newBook = new Book(Books.Count + 1, "New Book", "Unknown Author", 100, 0);
        Books.Add(newBook);
    }

    [RelayCommand]
    void SaveBooks()
    {
        dataSource.SaveBooks(Books);
    }   

    [RelayCommand]
    void AddItem()
    {
        var newItem = new Item
        {
            Id = Items.Count + 1,
            Name = $"Item {Items.Count + 1}"
        };
        Items.Add(newItem);
    }

    [RelayCommand]
    async Task ViewItemDetails(Item item)
    {
        await Shell.Current.GoToAsync($"ItemDetails?itemId={item.Id}");
    }
}

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}