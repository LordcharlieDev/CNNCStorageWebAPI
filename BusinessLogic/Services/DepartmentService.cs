using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Extentions;
using BusinessLogic.Interfaces;
using BusinessLogic.Resources;
using CNNCStorageDB.Data;
using CNNCStorageDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
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
        public IEnumerable<DepartmentDTO> GetAll()
        {
            return mapper.Map<IEnumerable<DepartmentDTO>>(context.Departments.ToList());
        }

        public DepartmentDTO GetById(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null)
            {
                throw new HttpException(ErrorMessages.DepartmentNotFound, HttpStatusCode.NotFound);
            }
            return mapper.Map<DepartmentDTO>(department);
        }
        public void Create(DepartmentDTO departmentDTO)
        {
            context.Departments.Add(mapper.Map<Department>(departmentDTO));
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null)
            {
                throw new HttpException(ErrorMessages.DepartmentNotFound, HttpStatusCode.NotFound);
            }
            context.Departments.Remove(department);
            context.SaveChanges();
        }
        public void Update(DepartmentDTO departmentDTO)
        {
            context.Departments.Update(mapper.Map<Department>(departmentDTO));
            context.SaveChanges();
        }
    }
}
