using OnlineTicaret.Data.Interfaces;
using OnlineTicaret.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicaret.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {

        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "IphoneX",
                        Price = 2100 , ShortDescription = "The most widely consumed phone",
                        LongDescription = "This phone is widely used [1][2][3] and most widely consumed[4]",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "/image/IphoneX.jpg",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "/image/IphoneX.jpg"
                    }

                };
            }
        }
        public IEnumerable<Product> PreferredProducts { get; }
        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product model)
        {
            throw new NotImplementedException();
        }
    }
}

