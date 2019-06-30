using System.Collections.Generic;
using System.Linq;
using DellChallenge.D1.Api.Dto;

namespace DellChallenge.D1.Api.Dal
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext _context;

        public ProductsService(ProductsContext context)
        {
            _context = context;
        }
        
        public ProductDto Get(string id) 
        {
            return _context.Products.Select(p => MapToDto(p)).Where(z => z.Id == id).FirstOrDefault();
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _context.Products.Select(p => MapToDto(p));
        }

        public ProductDto Add(NewProductDto newProduct)
        {
            var product = MapToData(newProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            var addedDto = MapToDto(product);
            return addedDto;
        }

        public ProductDto Put(int id, string value) 
        {
            var item = _context.Products.Select(p => MapToDto(p)).Where(z => z.Id == id).FirstOrDefault();
            item.Name = value;
        }

        public ProductDto Delete(string id)
        {
            var item = _context.Products.Select(p => MapToDto(p)).Where(z => z.Id == id).FirstOrDefault();
            _context.Products.Remove(item);
            return item;
        }

        private Product MapToData(NewProductDto newProduct)
        {
            return new Product
            {
                Category = newProduct.Category,
                Name = newProduct.Name
            };
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category
            };
        }
    }
}
