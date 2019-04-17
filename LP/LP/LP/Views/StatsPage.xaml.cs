using LP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP.ViewModels;
using LP.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatsPage : ContentPage
	{
        WorkoutsViewModel viewModel;
    //    private String dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDb.db1");

        public StatsPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new WorkoutsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Workouts.Count == 0)
                viewModel.LoadWorkoutsCommand.Execute(null);
        }
        async void OnWorkoutSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var workout = args.SelectedItem as Workout;
            if (workout == null)
                return;

            await Navigation.PushAsync(new WorkoutDetailPage(new WorkoutDetailViewModel(workout)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new WorkoutPage()));
        }
    }
}