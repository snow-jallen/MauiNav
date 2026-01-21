using MauiNav4.ViewModels;
using Xunit;

namespace MauiNav4.Tests.ViewModels;

public class ItemDetailsViewModelTests
{
    [Fact]
    public void ItemId_ShouldBeSettable()
    {
        // Arrange
        var viewModel = new ItemDetailsViewModel();
        var expectedId = "123";

        // Act
        viewModel.ItemId = expectedId;

        // Assert
        Assert.Equal(expectedId, viewModel.ItemId);
    }

    [Theory]
    [InlineData("1")]
    [InlineData("42")]
    [InlineData("999")]
    public void ItemId_ShouldAcceptDifferentValues(string itemId)
    {
        // Arrange
        var viewModel = new ItemDetailsViewModel();

        // Act
        viewModel.ItemId = itemId;

        // Assert
        Assert.Equal(itemId, viewModel.ItemId);
    }
}
