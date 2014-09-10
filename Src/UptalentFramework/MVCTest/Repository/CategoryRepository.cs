using MVCTest.Models;
using UptalentFramework.Data;
using UptalentFramework.Data.PetaPoco;

namespace MVCTest.Repository
{
    public class CategoryRepository:PetaPocoRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(IUnitOfWorkProvider unitOfWorkProvider) : base(unitOfWorkProvider) { }
    }
}