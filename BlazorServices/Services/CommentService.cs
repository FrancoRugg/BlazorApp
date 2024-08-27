using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorServices.Services
{
    public class CommentService
    {
        
        private readonly HttpClient _httpClient;

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Comments>> getCommentList()
        {
            return await _httpClient.GetFromJsonAsync<List<Comments>>("https://jsonplaceholder.typicode.com/comments");
        }
    }
}
