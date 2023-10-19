using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAllCoursesQueryHandled : IRequestHandler<GetAllCoursesQueryRequest, List<Course>>
    {
        private readonly PracticeDbContext _context;

        private readonly IMediator _mediator;

        public GetAllCoursesQueryHandled(PracticeDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }



        public async Task<List<Course>> Handle(GetAllCoursesQueryRequest request, CancellationToken cancellationToken)
        {
            return await _context.Courses.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
