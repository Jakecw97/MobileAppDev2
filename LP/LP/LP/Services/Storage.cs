using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LP.Services
{
    public interface Storag<T>
    {
        Task<bool> AddItemAsync(T Workout);
        Task<bool> UpdateItemAsync(T Workout);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
