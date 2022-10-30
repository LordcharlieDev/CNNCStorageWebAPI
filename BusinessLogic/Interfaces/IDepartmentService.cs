using BusinessLogic.DTOs;
using CNNCStorageDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDTO> GetAll();
        DepartmentDTO GetById(int id);
        void Create(DepartmentDTO departmentDTO);
        void Update(DepartmentDTO departmentDTO);
        void Delete(int id);
    }
}
