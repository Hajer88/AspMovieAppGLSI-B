using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspMovieAppGLSI_B.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool SubscribedToNewsletter { get; set; }
        public int membershiptypeId { get; set; }
        public virtual Membershiptype membershiptype { get; set; }
        public ICollection<Movie> movies { get; set; }
    }
}