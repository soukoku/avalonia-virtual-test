using System.Collections.ObjectModel;
using System.Reflection;
using Avalonia.Media;
using SkiaSharp;

namespace VirtualPanelTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        foreach (var prop in typeof(Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static))
        {
            Items.Add(new ItemViewModel(prop.Name, (IImmutableSolidColorBrush)prop.GetValue(null)!));
        }
    }

    public ObservableCollection<ItemViewModel> Items { get; } = [];

    public string Greeting { get; } = "Welcome to Avalonia!";
}