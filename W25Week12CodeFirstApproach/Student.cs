﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W25Week12CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int? StandardId { get; set; }

        // navigation property
        public Standard? Standard { get; set; }
    }
}
