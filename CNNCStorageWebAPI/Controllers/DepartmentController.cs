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
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return Ok(context.Departments.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var department = context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return Ok("Successful");
        }
    }
}
