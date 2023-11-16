using System.Collections.ObjectModel;

namespace Projectosik2.ViewModels.Employee;

public class EmployeeViewModel : ViewModelBase
{
    private ObservableCollection<Projectosik2.Employee> _employee;
    
    public ObservableCollection<Projectosik2.Employee> Employees
    {
        get => _employee;
        set => SetField(ref _employee, value);
    }

    public EmployeeViewModel()
    {
        Employees = new ObservableCollection<Projectosik2.Employee>();
        Employees.Add(new Projectosik2.Employee(1,"dd","dd",11,"dd"));
    }
}