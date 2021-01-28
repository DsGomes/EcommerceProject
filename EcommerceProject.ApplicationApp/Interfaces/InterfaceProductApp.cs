using EcommerceProject.Entities.Entities;
using System.Threading.Tasks;

namespace EcommerceProject.ApplicationApp.Interfaces
{
    public interface InterfaceProductApp : InterfaceGenericApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
