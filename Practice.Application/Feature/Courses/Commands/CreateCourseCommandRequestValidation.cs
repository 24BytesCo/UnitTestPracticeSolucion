using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Feature.Courses.Commands
{
    public class CreateCourseCommandRequestValidation: AbstractValidator<CreateCourseCommandRequest>
    {
        public CreateCourseCommandRequestValidation() 
        {
            RuleFor(x => x.Title);
            RuleFor(x => x.Description);

        }
    }
}
