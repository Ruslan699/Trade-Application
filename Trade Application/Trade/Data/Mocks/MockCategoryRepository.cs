using OnlineTicaret.Data.Interfaces;
using OnlineTicaret.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicaret.Data.Mocks
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Tv",Description="All Tv's"},
                    new Category {CategoryName = "Phone",Description="All Phones"},
                    new Category {CategoryName = "Book",Description="All Books"},
                    new Category {CategoryName = "Automobile",Description="All Automobiles"},
                   



                };
            }

        }
    }
}
