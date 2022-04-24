﻿using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Database.Interfaces
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetUser(string email);
        Task CreateUser(User user);
        Task EditUser(EditUserViewModel User);
        Task DeleteUser(string email);
        Task<int> SaveChangesAsync();
    }
}
