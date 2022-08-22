using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Post> posts { get; set; }
    }
}
