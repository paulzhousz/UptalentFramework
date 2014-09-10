using MVCTest.Models;
using UptalentFramework.Data;
using UptalentFramework.Data.PetaPoco;

namespace MVCTest.Repository
{
    public class RegionRepository:PetaPocoRepository<Region>,IRegionRepository
    {
        public RegionRepository(IUnitOfWorkProvider unitOfWorkProvider) : base(unitOfWorkProvider) { }
    }
}