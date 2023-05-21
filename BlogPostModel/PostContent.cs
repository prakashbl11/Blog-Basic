namespace BlogPostModel
{
    public class PostContent
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

    }
}