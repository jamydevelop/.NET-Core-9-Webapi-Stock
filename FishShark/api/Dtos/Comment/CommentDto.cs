namespace api.Dtos.Comment
{
    public class CommentDto
    {
        public string Title { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
    }
}