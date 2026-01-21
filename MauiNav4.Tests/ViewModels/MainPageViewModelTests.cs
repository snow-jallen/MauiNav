using MauiNav4.ViewModels;
using Xunit;

namespace MauiNav4.Tests.ViewModels;

public class MainPageViewModelTests
{
    [Fact]
    public void AddItem_ShouldAddItemToCollection()
    {
        // Arrange
        var viewModel = new MainPageViewModel();
        var initialCount = viewModel.Items.Count;

        // Act
        viewModel.AddItemCommand.Execute(null);

        // Assert
        Assert.Equal(initialCount + 1, viewModel.Items.Count);
    }

    [Fact]
    public void AddItem_ShouldCreateItemWithCorrectId()
    {
        // Arrange
        var viewModel = new MainPageViewModel();

        // Act
        viewModel.AddItemCommand.Execute(null);
        var addedItem = viewModel.Items[^1];

        // Assert
        Assert.Equal(1, addedItem.Id);
    }

    [Fact]
    public void AddItem_ShouldCreateItemWithCorrectName()
    {
        // Arrange
        var viewModel = new MainPageViewModel();

        // Act
        viewModel.AddItemCommand.Execute(null);
        var addedItem = viewModel.Items[^1];

        // Assert
        Assert.Equal("Item 1", addedItem.Name);
    }

    [Fact]
    public void AddMultipleItems_ShouldIncrementIdCorrectly()
    {
        // Arrange
        var viewModel = new MainPageViewModel();

        // Act
        viewModel.AddItemCommand.Execute(null);
        viewModel.AddItemCommand.Execute(null);
        viewModel.AddItemCommand.Execute(null);

        // Assert
        Assert.Equal(3, viewModel.Items.Count);
        Assert.Equal(1, viewModel.Items[0].Id);
        Assert.Equal(2, viewModel.Items[1].Id);
        Assert.Equal(3, viewModel.Items[2].Id);
    }
}
