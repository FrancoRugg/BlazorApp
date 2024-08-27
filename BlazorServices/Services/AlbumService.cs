using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class PostService
    {
        
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Albums>> getAlbumList()
        {
            return await _httpClient.GetFromJsonAsync<List<Albums>>("https://jsonplaceholder.typicode.com/albums");
        }
    }
}
