using BlazorServices.Models;
using BlazorServices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices.Services
{
    public class UserEntityService : UserEntityRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserEntityService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<ActionResult<List<UsersEntityModel>>> GetUserList()
        {
            return await _appDbContext.Users.ToListAsync();
        }
        public async Task<bool> DeleteUser(int id)
        {
            var userToDelete = await _appDbContext.Users.FindAsync(id);
            if (userToDelete != null)
            {
                _appDbContext.Users.Remove(userToDelete);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> PostUser(UsersEntityModel newUser)
        {
            try
            {
                _appDbContext.Users.Add(newUser);
                await _appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Task<bool> PutUser(UsersEntityModel newUser)
        {
            throw new NotImplementedException();
        }
    }
}
