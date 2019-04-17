using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LP.Models;

namespace LP.Services
{
        public class DataStorage : Storage<Workout>
        {
            List<Workout> workouts;

            public DataStorage()
            {
                workouts = new List<Workout>();
                var mockItems = new List<Workout>
            {
                new Workout { id = Guid.NewGuid().ToString(), day=1,squat = "80", bench="60",overHead="40",deadlift="100",bicep="20",tricep="25" },
                new Workout { id = Guid.NewGuid().ToString(), day=2,squat = "85", bench="65",overHead="45",deadlift="110",bicep="25",tricep="30" },
                new Workout { id = Guid.NewGuid().ToString(), day=3,squat = "87.5", bench="65",overHead="50",deadlift="112.5",bicep="27.5",tricep="35" },
        
            };

                foreach (var item in mockItems)
                {
                workouts.Add(item);
                }
            }

            public async Task<bool> AddWorkoutAsync(Workout workout)
            {


            ++workout.day;
            workouts.Add(workout);
            return await Task.FromResult(true);
            }

            public async Task<bool> UpdateWorkoutAsync(Workout workout)
            {
                var oldItem = workouts.Where((Workout arg) => arg.id == workout.id).FirstOrDefault();
                workouts.Remove(oldItem);
                workouts.Add(workout);

                return await Task.FromResult(true);
            }

            public async Task<bool> DeleteWorkoutAsync(string id)
            {
                var oldItem = workouts.Where((Workout arg) => arg.id == id).FirstOrDefault();
                workouts.Remove(oldItem);

                return await Task.FromResult(true);
            }

            public async Task<Workout> GetWorkoutAsync(string id)
            {
                return await Task.FromResult(workouts.FirstOrDefault(s => s.id == id));
            }

            public async Task<IEnumerable<Workout>> GetWorkoutAsync(bool forceRefresh = false)
            {
                return await Task.FromResult(workouts);
            }
        }
    }
