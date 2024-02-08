using System;
using System.Collections.Generic;

namespace WebApplication2MVC.Models;

public partial class Site
{
    public int Id { get; set; }

    public string? City { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Leader { get; set; }
}
