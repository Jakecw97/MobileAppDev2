using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LP.Services
{
    public interface Storage<T>
    {
        Task<bool> AddWorkoutAsync(T workout);
        Task<bool> UpdateWorkoutAsync(T workout);
        Task<bool> DeleteWorkoutAsync(string day);
        Task<T> GetWorkoutAsync(string day);
        Task<IEnumerable<T>> GetWorkoutAsync(bool forceRefresh = false);
    }
}
