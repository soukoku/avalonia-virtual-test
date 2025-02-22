using Avalonia.Media;

namespace VirtualPanelTest.ViewModels;

public class ItemViewModel : ViewModelBase
{
    public string Name { get; }
    public IImmutableSolidColorBrush Color { get; }

    public ItemViewModel(string name, IImmutableSolidColorBrush color)
    {
        Name = name;
        Color = color;
    }
}