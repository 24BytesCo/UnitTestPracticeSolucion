using AutoMapper;
using Practice.Application.DTOs;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
        }
    }
}
