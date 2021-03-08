using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.mocks
{
    public class MockCategory : ITarufsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName="Сарни", Desc=""},
                    new Category{ CategoryName="Дослідна станція", Desc=""},
                    new Category{ CategoryName="Клесів", Desc=""},
                    new Category{ CategoryName="Карпилівка", Desc=""},
                };
            }
        }

    }
}