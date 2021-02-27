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
                    new Category{ categoryName="Сарни", desc=""},
                    new Category{ categoryName="Дослідна станція", desc=""},
                    new Category{ categoryName="Клесів", desc=""},
                    new Category{ categoryName="Карпилівка", desc=""},
                };
            }
        }

    }
}