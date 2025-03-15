using CRJBlazorWeb.Models;

namespace CRJBlazorWeb.Services;
public interface IProductService
{
    Task<List<Product>> GetProducts();
}
