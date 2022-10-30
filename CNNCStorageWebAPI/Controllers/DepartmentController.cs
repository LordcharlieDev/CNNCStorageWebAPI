using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
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
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return Ok(departmentService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(departmentService.GetById(id));
        }
        [HttpPost]
        public IActionResult Create([FromBody] DepartmentDTO department)
        {
            if (!ModelState.IsValid) return BadRequest();
            departmentService.Create(department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            departmentService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Edit([FromBody] DepartmentDTO department)
        {
            if (!ModelState.IsValid) return BadRequest();
            departmentService.Update(department);
            return Ok();
        }
    }
}
