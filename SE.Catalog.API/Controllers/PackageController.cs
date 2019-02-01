using Microsoft.AspNetCore.Mvc;
using SE.Catalog.Contracts;
using SE.Catalog.Models;

namespace SE.Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        public readonly IRepositoryBase<Package> _packageRepository;
        public PackageController()
        { }
    }
}