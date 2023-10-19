using MediatR;
using Practice.Application.DTOs;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Queries
{
    public class GetAllCoursesQueryRequest : IRequest<List<CourseDTO>>
    {
    }
}
