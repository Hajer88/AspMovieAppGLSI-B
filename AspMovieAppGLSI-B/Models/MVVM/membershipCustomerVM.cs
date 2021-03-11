using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMovieAppGLSI_B.Models.MVVM
{
    public class membershipCustomerVM
    {
        public Customer customer { get; set; }
        public IEnumerable<Membershiptype> membershiptypes { get; set; }
    }
}