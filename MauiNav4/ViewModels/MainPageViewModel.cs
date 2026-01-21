using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MauiNav4.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

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