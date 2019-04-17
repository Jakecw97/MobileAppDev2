using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LP.Models;
using LP.ViewModels;

namespace LP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutDetailPage : ContentPage
    {
        WorkoutDetailViewModel viewModel;

        public WorkoutDetailPage(WorkoutDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public WorkoutDetailPage()
        {
            InitializeComponent();

            var workout = new Workout
            {
                
            };

            viewModel = new WorkoutDetailViewModel(workout);
            BindingContext = viewModel;
        }
    }
}