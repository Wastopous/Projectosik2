using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MySqlConnector;

namespace Projectosik2.ViewModels.CustService;

public partial class CustServWindow : Window
{
    public CustServWindow()
    {
        InitializeComponent();
        DataContext = new CustServViewModel();
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
        var cmd = new MySqlCommand("DELETE FROM Custom_Service WHERE ID = @ID");
        cmd.Parameters.AddWithValue("@ID", (ClientGrid.SelectedItem as CustServ ).ID);
        cmd.ExecuteNonQuery();
    }

    private void BackBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}