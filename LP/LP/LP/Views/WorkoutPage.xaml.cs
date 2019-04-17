using LP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LP.Views
{
   
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutPage : ContentPage
	{
        public Workout Workout { get; set; }
        private String dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),"myDb.db1");

       
        public WorkoutPage ()
		{
			InitializeComponent ();

            Workout = new Workout
            {
                day = 0,
                squat = "0",
                bench = "0",
                deadlift = "0",
                overHead = "0",
                bicep = "0",
                tricep = "0"
            };



            BindingContext = this;
        }
        public string title { get { return title; } }
        async void Save_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Caution: Data cannot be altered, continue?", "Cancel", "Okay");
            if (action =="Okay"){
                MessagingCenter.Send(this, "AddWorkout", Workout);
                await Navigation.PopModalAsync();
            }
        }
    }
}
	
