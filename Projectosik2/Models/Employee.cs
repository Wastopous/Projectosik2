namespace Projectosik2;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; } 
    public int Phone { get; set; }
    public string Email { get; set; }

    public Employee(int id, string name, string lastname, int phone, string email)
    {
        this.ID = id;
        this.Name = name;
        this.LastName = lastname;
        this.Phone = phone;
        this.Email = email;
    }
}