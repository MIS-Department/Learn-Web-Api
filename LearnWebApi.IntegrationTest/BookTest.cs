using System;
using System.Linq;
using LearnWebApi.DataLayer.Repositories;
using NUnit.Framework;

namespace LearnWebApi.IntegrationTest
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void GetAll()
        {
            var repo = new BookRepository();
            var output = repo.GetAll();

            Assert.AreEqual(4, output.Result.Count());

            //to get the value of book model
            //foreach (var book in output.Result)
            //{
            //    book.AuthorId
            //}
        }

        [Test]
        public void GetById()
        {
            var repo = new BookRepository();
            var output = repo.GetBookById(2);

            Assert.AreEqual(13, output.Price);
        }

        [Test]
        public void GetAuthorBookTest()
        {
            var repo = new BookRepository();

            var output = repo.GetAuthorBook();
            Assert.AreEqual(4, output.Result.Count());

            foreach (var bookView in output.Result)
            {
                Console.WriteLine("Name: {0}, Title: {1}", bookView.Author.Name, bookView.Title );
            }
        }
    }
}
