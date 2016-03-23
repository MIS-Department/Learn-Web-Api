using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using LearnWebApi.Models.View;
using Newtonsoft.Json;

namespace LearnWebApi.Web.Services
{
    public class AuthorService
    {
        private readonly string _uri = "http://localhost:5023/api/authors";

        public List<BookView> GetBookAuthors()
        {
            try
            {
                var webClient = new WebClient();

                return JsonConvert.DeserializeObject<List<BookView>>(webClient.DownloadString(_uri));
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        public async Task<List<BookView>> GetBookAuthorsAsync()
        {
            try
            {
                var httpClient = new HttpClient();

                return JsonConvert.DeserializeObject<List<BookView>>(
                    await httpClient.GetStringAsync(_uri));
            }
            catch (Exception ex)
            {
                
                throw;
            }
        } 
    }
}