using BusinessLogic.DTOs;
using CNNCStorageDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Department, DepartmentDTO>().ReverseMap();
        }
    }
}
