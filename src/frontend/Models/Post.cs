// ./wwwroot/Post.cs

namespace frontend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Image Image { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
    }
}