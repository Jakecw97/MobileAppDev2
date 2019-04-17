using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LP.Services
{
    public interface Storage<T>
    {
        Task<bool> AddWorkoutAsync(T workout);
        //Task<bool> UpdateItemAsync(T workout);
        //Task<bool> DeleteItemAsync(string id);
        Task<T> GetWorkoutAsync(string id);
        Task<IEnumerable<T>> GetWorkoutAsync(bool forceRefresh = false);
    }
}
