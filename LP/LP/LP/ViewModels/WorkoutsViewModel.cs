using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using LP.Models;
using LP.Views;

namespace LP.ViewModels
{
    public class WorkoutsViewModel : BasicViewModel
    {
        public ObservableCollection<Workout> Workouts { get; set; }
        public Command LoadWorkoutsCommand { get; set; }

        public WorkoutsViewModel()
        {
            Title = "Browse";
            Workouts = new ObservableCollection<Workout>();
            LoadWorkoutsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<WorkoutPage, Workout>(this, "AddWorkout", async (obj, workout) =>
            {
                var newWorkout = workout as Workout;
                newWorkout.day += newWorkout.day;
                Workouts.Add(newWorkout);
                await DataStore.AddWorkoutAsync(newWorkout);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Workouts.Clear();
                var workouts = await DataStore.GetWorkoutAsync(true);
                foreach (var workout in workouts)
                {
                    Workouts.Add(workout);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
