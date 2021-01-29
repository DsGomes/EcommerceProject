using EcommerceProject.Domain.Interfaces.InterfaceProduct;
using EcommerceProject.Entities.Entities;
using EcommerceProject.Infrastructure.Repository.Generics;

namespace EcommerceProject.Infrastructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGeneric<Product>, IProduct
    {

    }
}
