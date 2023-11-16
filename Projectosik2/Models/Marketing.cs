using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Projectosik2;

public class Marketing
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Marketing(int id, string name, DateTime sd, DateTime ed)
    {
        this.ID = id;
        this.Name = name;
        this.StartDate = sd;
        this.EndDate = ed;
    }
}