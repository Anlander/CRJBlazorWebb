using System.ComponentModel.DataAnnotations;

namespace CRJBlazorWeb.Models;

public class Product
{
    public int Id { get; set; }

    public required string Name { get; set; }
    [Required]
    public required string Description { get; set; }

    [Required]
    public required Double Price { get; set; }

    [Required]
    public required string Image { get; set; }
    public int AvailableAmount { get; set; } = 100;
}

