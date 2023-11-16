namespace Projectosik2;

public class Client
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }
    public string Client_Status { get; set; }

    public Client(int id, string name, string lastname, int phone, string email, string cs)
    {
        this.ID = id;
        this.Name = name;
        this.Phone = phone;
        this.Email = email;
        this.Client_Status = cs;
    }
}