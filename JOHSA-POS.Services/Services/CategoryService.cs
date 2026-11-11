using System.Collections.Generic;
using JOHSA_POS.Domain;
using JOHSA_POS.Data.Repositories;

namespace JOHSA_POS.Services.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<KeyValuePair<int, string>> GetAll()
        {
            return categoryRepository.GetAll();
        }
    }
}
