using SocialMedia.Models;
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
        public virtual DbSet<ApplicationUser> ApplicationUsers{ get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
    }
}