using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Practice.Application.DTOs;
using Practice.Domain;
using Practice.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Queries
{
    public class GetAllCoursesQueryHandled : IRequestHandler<GetAllCoursesQueryRequest, List<CourseDTO>>
    {
        private readonly PracticeDbContext _context;

        private readonly IMapper _mapper;

        public GetAllCoursesQueryHandled(PracticeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public async Task<List<CourseDTO>> Handle(GetAllCoursesQueryRequest request, CancellationToken cancellationToken)
        {
            var allCourses = await _context.Courses.ToListAsync(cancellationToken: cancellationToken);

            return _mapper.Map<List<Course>, List<CourseDTO>>(allCourses);

        }
    }
}
