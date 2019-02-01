using SE.Catalog.Contracts;
using SE.Catalog.Models;
using System;

namespace SE.Catalog.BusinessLogic
{
    public class PackageManager
    {
        private readonly IRepositoryBase<Package> _packageRepo;
        public PackageManager(IRepositoryBase<Package> PackageRepo)
        {
            _packageRepo = PackageRepo;
        }
        public void ValidatePackage(Package pak)
        {
            _packageRepo.Add(pak);            
        }
    }
}
