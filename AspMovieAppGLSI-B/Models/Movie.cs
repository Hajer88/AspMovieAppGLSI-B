﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMovieAppGLSI_B.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Customer> customers { get; set; }
        public Genre genre { get; set; }
    }
}