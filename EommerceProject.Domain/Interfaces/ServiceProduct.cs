using EcommerceProject.Domain.Interfaces.InterfaceProduct;
using EcommerceProject.Domain.Interfaces.InterfaceServices;
using EcommerceProject.Entities.Entities;
using System;
using System.Threading.Tasks;

namespace EcommerceProject.Domain.Interfaces
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Name, "Name");

            var validatePrice = product.ValidatePropertyDecimal(product.Price, "Price");

            if (validateName && validatePrice)
            {
                product.Status = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validateName = product.ValidatePropertyString(product.Name, "Name");

            var validatePrice = product.ValidatePropertyDecimal(product.Price, "Price");

            if (validateName && validatePrice)
            {
                await _IProduct.Update(product);
            }
        }
    }
}
