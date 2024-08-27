using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Models
{
    public class Photos
    {
        //"albumId": 1,
        //"id": 1,
        //"title": "accusamus beatae ad facilis cum similique qui sunt",
        //"url": "https://via.placeholder.com/600/92c952",
        //"thumbnailUrl": "https://via.placeholder.com/150/92c952"

        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
