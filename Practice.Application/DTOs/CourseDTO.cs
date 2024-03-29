﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.DTOs
{
    public class CourseDTO
    {
        public Guid CourseId { get; set; }

        public string? Title { get; set; }
        
        public string? Description { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

    }
}
