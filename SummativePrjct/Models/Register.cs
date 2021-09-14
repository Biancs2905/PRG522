using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummativePrjct.Models
{
    public class Register
    {
        public string Email { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
    }
}