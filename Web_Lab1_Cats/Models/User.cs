using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Web_Lab1_Cats.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
