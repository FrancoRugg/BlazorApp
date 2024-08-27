using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class PostsService
    {
        
        private readonly HttpClient _httpClient;

        public PostsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Posts>> getPostList()
        {
            return await _httpClient.GetFromJsonAsync<List<Posts>>("https://jsonplaceholder.typicode.com/posts");
        }
    }
}
