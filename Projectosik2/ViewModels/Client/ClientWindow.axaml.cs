using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using MySqlConnector;
using Projectosik2.ButtonsWindows;
using Projectosik2.ViewModels.CustService;
using Projectosik2.ViewModels.Employee;
using Projectosik2.ViewModels.Marketing;
using Projectosik2.ViewModels.Product;
using Projectosik2.ViewModels.Sale;

namespace Projectosik2;

public partial class ClientWindow : Window
{
    public ClientWindow()
    {
        InitializeComponent();
        DataContext = new ClientViewModel();
    }
    
    private void EmployeeBtn_OnClickBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        EmployeeWindow employeeWindow = new EmployeeWindow();
        employeeWindow.ShowDialog(this);
    }

    private void SaleBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        SaleWindow saleWindow = new SaleWindow();
        saleWindow.ShowDialog(this);
    }

    private void MarketingBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        MarketingWindow marketingWindow = new MarketingWindow();
        marketingWindow.ShowDialog(this);
    }

    private void ProductBtn_OnClickBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        ProductWindow productWindow = new ProductWindow();
        productWindow.ShowDialog(this);
    }

    private void CSBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        CustServWindow custServWindow = new CustServWindow();
        custServWindow.ShowDialog(this);
    }

    private void EditBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        ClientEditWindow clientEditWindow = new ClientEditWindow();
        clientEditWindow.DataContext = ClientGrid.SelectedItem;
        clientEditWindow.ShowDialog(this);
    }

    private void AddBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        ClientAddWindow clientAddWindow = new ClientAddWindow();
        clientAddWindow.DataContext = new Client(0," "," ", 0," "," ");
        clientAddWindow.ShowDialog(this);
    }

    private void DelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var con = new MySqlConnection(" ");
        con.Open();
        var cmd = new MySqlCommand("DELETE FROM Clients WHERE ID = @ID");
        cmd.Parameters.AddWithValue("@ID", (ClientGrid.SelectedItem as Client ).ID);
        cmd.ExecuteNonQuery();
    }

    private void CloseBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        L.IsVisible = true;
    }

    private void CloseBtn_OnDoubleTapped(object? sender, TappedEventArgs e)
    {
        this.Close();
    }
}