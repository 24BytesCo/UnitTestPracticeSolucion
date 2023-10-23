using MediatR;
using Practice.Domain;
using Practice.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Commands
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest>
    {
        private readonly PracticeDbContext _context;

        public CreateCourseCommandHandler(PracticeDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
        {
            var newCourse = new Course 
            {
                CourseId = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
                CreationDate = DateTime.UtcNow,
                PublicationDate = request.PublicationDate
            };

            _context.Add(newCourse);

            var saveResult = await _context.SaveChangesAsync();

            if (saveResult > 0)
            {
                return Unit.Value;
            }

            throw new Exception("No se pudo crear el curso");
        }
    }
}
