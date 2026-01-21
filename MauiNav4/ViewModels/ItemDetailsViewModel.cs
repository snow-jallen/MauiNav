using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiNav4.ViewModels;

[QueryProperty(nameof(ItemId), "itemId")]
public partial class ItemDetailsViewModel : ObservableObject
{
    [ObservableProperty]
    private string itemId;

    [RelayCommand]
    async Task GoHome()
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
