namespace LearnWebApi.Models.DTO
{
    public class BookDetailsDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }

    }
}
