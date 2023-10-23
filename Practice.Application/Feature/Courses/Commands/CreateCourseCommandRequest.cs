using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Commands
{
    public class CreateCourseCommandRequest : IRequest
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

    }
}
