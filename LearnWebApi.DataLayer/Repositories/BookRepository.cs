using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using LearnWebApi.Models.Tables;
using LearnWebApi.Models.View;

namespace LearnWebApi.DataLayer.Repositories
{
    public class BookRepository
    {
        public async Task<IEnumerable<Book>> GetAll()
        {
            try
            {
                var connection = new SqlConnection(ConfigurationSettings.GetConnectionString());

                return await connection.QueryAsync<Book>("BookAll", commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public Book GetBookById(int bookId)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationSettings.GetConnectionString());
                var p = new DynamicParameters();

                p.Add("@BookId", bookId);

                return connection.Query<Book>("BookById",p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Delete(int bookId)
        {
            try
            {
                var connection = new SqlConnection(ConfigurationSettings.GetConnectionString());
                var p = new DynamicParameters();

                p.Add("@BookId", bookId);
                await connection.QueryAsync<Book>("BookDelet", p, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<BookView>> GetAuthorBook()
        {
            try
            {
                var conection = new SqlConnection(ConfigurationSettings.GetConnectionString());

                return await conection.QueryAsync<BookView, Author, BookView>("AuthorBook", (book, author) =>
                {
                    book.Author = author;
                    return book;
                }, splitOn: "Name",
                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
