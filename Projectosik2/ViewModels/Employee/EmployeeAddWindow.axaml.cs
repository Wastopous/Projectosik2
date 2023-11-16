using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Projectosik2.ViewModels.Employee;

public partial class EmployeeAddWindow : Window
{
    public EmployeeAddWindow()
    {
        InitializeComponent();
    }

    private void SaveBtn_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
      this.Close();
    }
}