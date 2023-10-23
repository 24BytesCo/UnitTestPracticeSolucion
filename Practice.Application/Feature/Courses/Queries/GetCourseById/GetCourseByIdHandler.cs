using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Practice.Application.DTOs;
using Practice.Domain;
using Practice.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Queries.GetCourseById
{
    public class GetCourseByIdHandler : IRequestHandler<GetCourseByIdRequest, CourseDTO>
    {
        private readonly PracticeDbContext _context;

        private readonly IMapper _mapper;

        public GetCourseByIdHandler(PracticeDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<CourseDTO> Handle(GetCourseByIdRequest request, CancellationToken cancellationToken)
        {
            var courseById = await _context.Courses.FirstOrDefaultAsync(x=> x.CourseId == request.CourseId);

            return _mapper.Map<Course, CourseDTO>(courseById);
        }
    }
}
