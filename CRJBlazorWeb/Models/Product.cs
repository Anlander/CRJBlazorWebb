using System.ComponentModel.DataAnnotations;

namespace CRJBlazorWeb.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }
    [Required]
    public string Description { get; set; }

    [Required]
    public Double Price { get; set; }

    [Required]
    public string Image { get; set; }
    public int AvailableAmount { get; set; } = 100;
}

