using CRJBlazorWeb.Data;
using CRJBlazorWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CRJBlazorWeb.Services;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;
    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Product>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return products;
    }
}
