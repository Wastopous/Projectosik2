using System;
using System.Collections.ObjectModel;

namespace Projectosik2;

public class CustServViewModel : ViewModelBase
{
    private ObservableCollection<CustServ> _custserv;
    
    public ObservableCollection<CustServ> CustServ
    {
        get => _custserv;
        set => SetField(ref _custserv, value);
    }

    public CustServViewModel()
    {
        CustServ = new ObservableCollection<CustServ>();
        CustServ.Add(new CustServ(1, DateTime.Now, "as", "ds", "df", "fg", "fg", "ddd"));
    }
}