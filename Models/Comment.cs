using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentBody { get; set; }
        public string AttachmentURL { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public List<Reply> Replies { get; set; }
    }
}
