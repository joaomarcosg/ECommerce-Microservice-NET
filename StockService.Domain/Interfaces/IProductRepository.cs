using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockService.Domain.Entities;

namespace StockService.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Delete(Guid id);
    }
}