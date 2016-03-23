namespace LearnWebApi.Models.Tables
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }

    }
}
