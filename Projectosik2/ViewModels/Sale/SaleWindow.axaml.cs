using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MySqlConnector;

namespace Projectosik2.ViewModels.Sale;

public partial class SaleWindow : Window
{
    public SaleWindow()
    {
        InitializeComponent();
        DataContext = new SaleViewModel();
    }

    private void BackBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void EditBtn_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void AddBtn_OnClick(object? sender, RoutedEventArgs e)
    {

    }

    private void DelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var con = new MySqlConnection(" ");
        con.Open();
        var cmd = new MySqlCommand("DELETE FROM Sale WHERE ID = @ID");
        cmd.Parameters.AddWithValue("@ID", (ClientGrid.SelectedItem as Projectosik2.Sale ).ID);
        cmd.ExecuteNonQuery();
    }
}