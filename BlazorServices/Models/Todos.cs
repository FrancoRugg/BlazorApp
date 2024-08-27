using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Models
{
    public class Todos
    {
        //"userId": 1,
        //"id": 1,
        //"title": "delectus aut autem",
        //"completed": false

        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
