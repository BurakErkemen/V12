namespace Repository.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
    }
}
