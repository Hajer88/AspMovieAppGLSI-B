using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMovieAppGLSI_B.Models
{
    public class Membershiptype
    {
        public int Id { get; set; }
        public int SignupFee { get; set; }
        public int DurationInMonth { get; set; }
        public int DiscountRate { get; set; }
    }
}