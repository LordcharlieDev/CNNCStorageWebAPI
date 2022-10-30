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
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Create([FromBody] Department department)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            
            return Ok();
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Department department)
        {

            return Ok();
        }
    }
}
