using DapperExtensions.Mapper;

namespace LearnWebApi.Models.Tables.Mapper
{
    public sealed class BookMapper : ClassMapper<Book>
    {
        public BookMapper()
        {
            Table("Book");
            Map(s => s.BookId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
