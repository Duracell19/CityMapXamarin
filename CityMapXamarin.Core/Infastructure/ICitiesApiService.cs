﻿using CityMapXamarin.Core.Models;
using System.Threading.Tasks;

namespace CityMapXamarin.Core.Infastrucure
{
    public interface ICitiesApiService
    {
        Task<Data> GetDataAsync();
    }
}
