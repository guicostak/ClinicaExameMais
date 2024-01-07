﻿using api.Dtos.Request;
using api.Models;

namespace api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task RegisterNewUser(UserModel user);
    }
}
