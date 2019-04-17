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
	public partial class StatsPage : ContentPage
	{
        private ListView listView;
        private String dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDb.db1");

        public StatsPage ()
		{
			InitializeComponent ();

            var db = new SQLiteConnection(dbPath);

            Grid stackLayout = new Grid();
            listView = new ListView();
            listView.ItemsSource = db.Table<Workout>().ToList();
            stackLayout.Children.Add(listView);
            //Content = stackLayout;
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new WorkoutPage()));
        }
    }
}