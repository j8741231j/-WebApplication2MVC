using System;
using System.Collections.Generic;

namespace WebApplication2MVC.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Customer { get; set; }

    public decimal? Revenue { get; set; }
}
