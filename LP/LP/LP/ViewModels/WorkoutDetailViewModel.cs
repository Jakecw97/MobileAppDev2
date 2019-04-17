using LP.Models;

namespace LP.ViewModels
{
    public class WorkoutDetailViewModel : BasicViewModel
    {
        public Workout Workout { get; set; }
        public WorkoutDetailViewModel(Workout workout = null)
        {
            Workout = workout;
        }
    }
}
