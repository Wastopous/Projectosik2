using System;
using System.Collections.ObjectModel;

namespace Projectosik2.ViewModels.Sale;

public class SaleViewModel : ViewModelBase
{
    private ObservableCollection<Projectosik2.Sale> _sales;

    public ObservableCollection<Projectosik2.Sale> Sales
    {
        get => _sales;
        set => SetField(ref _sales, value);
    }

    public SaleViewModel()
    {
        Sales = new ObservableCollection<Projectosik2.Sale>();
        Sales.Add(new Projectosik2.Sale(1,DateTime.Today, 123,"asd","gfdd"));
    }
}