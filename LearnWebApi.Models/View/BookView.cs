using LearnWebApi.Models.Tables;

namespace LearnWebApi.Models.View
{
    public class BookView : Book
    {
        public Author Author { get; set; }
    }
}
