using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<IEnumerable<Product?>> GetById(Guid id);
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Guid id);
    }
}