using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using CNNCStorageDB.Data;
using CNNCStorageDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly CNNCDbContext context;
        private readonly IMapper mapper;

        public DepartmentService(CNNCDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Create(DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }

    }
}
