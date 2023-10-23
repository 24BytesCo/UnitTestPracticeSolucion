using MediatR;
using Practice.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Queries.GetCourseById
{
    public class GetCourseByIdRequest: IRequest<CourseDTO>
    {
        public Guid CourseId { get; set; }
    }
}
