using System;
using System.Runtime.InteropServices.JavaScript;

namespace Projectosik2;

public class CustServ
{
    public int ID { get; set; }
    public DateTime Application_Date { get; set; }
    public string Application_Type { get; set; }
    public string Application_Status { get; set; }
    public string Problem_Description { get; set; }
    public string Client { get; set; }
    public string Employee { get; set; }
    public string Marketing { get; set; }

    public CustServ(int id, DateTime appd, string appt, string apps, string pd, string client, string employee, string marketing)
    {
        this.ID = id;
        this.Application_Date = appd;
        this.Application_Type = appt;
        this.Application_Status = apps;
        this.Problem_Description = pd;
        this.Client = client;
        this.Employee = employee;
        this.Marketing = marketing;
    }
}