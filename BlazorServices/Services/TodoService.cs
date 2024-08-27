using BlazorServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class TodoService
    {
        
        private readonly HttpClient _httpClient;

        public TodoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Todos>> getTodosList()
        {
            return await _httpClient.GetFromJsonAsync<List<Todos>>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}
