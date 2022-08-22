namespace SocialMedia.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string ReplyBody { get; set; }
        public string AttachmentURL { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
