using meetneighbours.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.services.contracts
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        void AddCategory(Category Category);
    }
}
