using System.Diagnostics;
using Avalonia.Media;

namespace VirtualPanelTest.ViewModels;

public class ItemViewModel : ViewModelBase
{
    private string _category;

    private string _name;

    public string Name
    {
        get
        {
            Debug.WriteLine($"{_category} get name: {_name}");
            return _name;
        }
    }

    public IImmutableSolidColorBrush Color { get; }

    public ItemViewModel(string category, string name, IImmutableSolidColorBrush color)
    {
        _category = category;
        _name = name;
        Color = color;
    }
}