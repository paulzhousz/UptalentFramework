using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using MVCTest.Models;
using MVCTest.Repository;
using UptalentFramework.Data;

namespace MVCTest.Service
{
    public class TestService:ITestService
    {
        private IUintOfWork _uow;
        private IRegionRepository _regionRepository;
        private ICategoryRepository _categoryRepository;

        public TestService(
            IUintOfWork uow,
            IRegionRepository regionRepository,
            ICategoryRepository categoryRepository
            )
        {
            _uow = uow;
            _regionRepository = regionRepository;
            _categoryRepository = categoryRepository;
        }


        public void Method1()
        {
            //using (_uow)
            //{
                //try
                //{
                   // _uow.BeginTransaction();
                    var r1 = new Region {RegionDescription = "test"};
                    _regionRepository.Insert(r1);
                    //throw (new Exception("aaa"));
                    //_categoryRepository.Insert(new Category{CategoryName = "eet"});
                    //_uow.Commit();
                //}
                //catch (Exception)
                //{
                    
                //    _uow.RollbackTransaction();
                //    throw;
                //}


            //}
        }
    }
}