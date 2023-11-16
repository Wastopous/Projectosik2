using System.Collections.ObjectModel;

namespace Projectosik2.ViewModels.Product;

public class ProductViewModel : ViewModelBase
{
    private ObservableCollection<Projectosik2.Product> _products;

    public ObservableCollection<Projectosik2.Product> Products
    {
        get => _products;
        set => SetField(ref _products, value);
    }

    public ProductViewModel()
    {
        Products = new ObservableCollection<Projectosik2.Product>();
        Products.Add(new Projectosik2.Product(1,"hfg","asd",12,"sad"));
    }
}