using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostBody { get; set; }
        public string AttachmentURL { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        public List<Comment> comments { get; set; }
    }
}
