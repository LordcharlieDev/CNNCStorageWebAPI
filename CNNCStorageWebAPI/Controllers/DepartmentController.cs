using CNNCStorageDB.Data;
using CNNCStorageDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CNNCStorageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly CNNCDbContext context;

        public DepartmentController(CNNCDbContext context)
        {
            this.context = context;
        }

    }
}
