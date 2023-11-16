using System.Collections.ObjectModel;

namespace Projectosik2;

public class ClientViewModel : ViewModelBase
{
    private ObservableCollection<Client> _clients;

    public ObservableCollection<Client> Clients
    {
        get => _clients;
        set => SetField(ref _clients, value);
    }

    public ClientViewModel()
    {
        Clients = new ObservableCollection<Client>();
        Clients.Add(new Client(1, "aa", "sadasd", 12, "wda", "asdas"));
    }
}