﻿using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public interface IBirdService
    {
        Task<Bird> GetBirdAsync();
    }
}
