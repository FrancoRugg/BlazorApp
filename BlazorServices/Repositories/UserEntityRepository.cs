using BlazorServices.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Repositories
{
    public interface UserEntityRepository
    {
        public Task<ActionResult<List<UsersEntityModel>>> GetUserList();

        public Task<bool> PostUser(UsersEntityModel newUser);
        public Task<bool> PutUser(UsersEntityModel newUser);
        public Task<bool> DeleteUser(int id);

    }
}
