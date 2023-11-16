using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MySqlConnector;

namespace Projectosik2.ButtonsWindows;
public partial class ClientAddWindow : Window
{
    public ClientAddWindow()
    {
        InitializeComponent();
    }

    private void SaveBtn_OnClick(object? sender, RoutedEventArgs e)
    {   
        var con = new MySqlConnection(" ");
        con.Open();
        var cmd = new MySqlCommand("INSERT Clients SET Name = @Name, LastName = @LastName, Phone = @Phone, Email = @Email, Client_Status = @Client_Status");
        cmd.Parameters.AddWithValue("@Name", NewName.Text);
        cmd.Parameters.AddWithValue("@LastName", NewLastName.Text);
        cmd.Parameters.AddWithValue("@Phone", NewPhone.Text);
        cmd.Parameters.AddWithValue("@Email", NewEmail.Text);
        cmd.Parameters.AddWithValue("@Client_Status", NewClient_Status.Text);
        cmd.ExecuteNonQuery();
    }

    private void CancelBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}