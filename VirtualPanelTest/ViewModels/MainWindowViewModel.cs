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
            StandardItems.Add(new ItemViewModel("std", prop.Name, (IImmutableSolidColorBrush)prop.GetValue(null)!));
            FortnitePortingItems.Add(new ItemViewModel("fp", prop.Name, (IImmutableSolidColorBrush)prop.GetValue(null)!));
            AnotherItems.Add(new ItemViewModel("other", prop.Name, (IImmutableSolidColorBrush)prop.GetValue(null)!));
        }
    }

    public ObservableCollection<ItemViewModel> StandardItems { get; } = [];
    
    public ObservableCollection<ItemViewModel> FortnitePortingItems { get; } = [];
    public ObservableCollection<ItemViewModel> AnotherItems { get; } = [];
}