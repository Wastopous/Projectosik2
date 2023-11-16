using System;
using System.Collections.ObjectModel;

namespace Projectosik2.ViewModels.Marketing;

public class MarketingViewModel : ViewModelBase
{
    private ObservableCollection<Projectosik2.Marketing> _marketings;

    public ObservableCollection<Projectosik2.Marketing> Marketings
    {
        get => _marketings;
        set => SetField(ref _marketings, value);
    }

    public MarketingViewModel()
    {
        Marketings = new ObservableCollection<Projectosik2.Marketing>();
        Marketings.Add(new Projectosik2.Marketing(1, "qq", DateTime.Now, DateTime.MaxValue));
    }
}