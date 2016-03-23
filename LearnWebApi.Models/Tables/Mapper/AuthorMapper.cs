using DapperExtensions.Mapper;

namespace LearnWebApi.Models.Tables.Mapper
{
    public sealed class AuthorMapper : ClassMapper<Author>
    {
        public AuthorMapper()
        {
            Table("Author");
            Map(s => s.AuthorId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
