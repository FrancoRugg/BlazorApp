using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Models
{
    public class UsersEntityModel
    {
        public int Id { get; set; }
        public string? Usuario { get; set; }
        public string? Clave { get; set; }
        public string? Rol { get; set; }
        public string? Estado { get; set; }
    }
}
