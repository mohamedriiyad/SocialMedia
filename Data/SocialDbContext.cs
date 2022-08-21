using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SocialMedia.Data
{
    public class SocialDbContext : IdentityDbContext
    {
        public SocialDbContext(DbContextOptions<SocialDbContext> options) 
            : base(options)
        {
            
        }
    }
}