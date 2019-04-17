using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LP.Models;
using LP.Views;
using LP.Views.Exercises;

namespace LP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
        }
        async void Squat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SquatWiki()));
        }
        async void Bench_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BenchWiki()));
        }
        async void OverHead_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new OverheadWiki()));
        }
        async void Deadlift_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new DeadLiftWiki()));
        }
        async void Bicep_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BicepWiki()));
        }
        async void Tricep_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new TricepWiki()));
        }
    }
}