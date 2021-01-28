using EcommerceProject.Entities.Entities;
using System.Threading.Tasks;

namespace EcommerceProject.Domain.Interfaces.InterfaceServices
{
    public interface IServiceProduct
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
