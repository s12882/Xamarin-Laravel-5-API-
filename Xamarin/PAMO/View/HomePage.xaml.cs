using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAMO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private void News_OnClicked(object sender, EventArgs e)
        {
            NewsPage news = new NewsPage();
            this.Navigation.PushAsync(news);
        }

        private void Weather_OnClicked(object sender, EventArgs e)
        {
            WeatherPage weather = new WeatherPage();
            this.Navigation.PushAsync(weather);
        }

        private async void Profile_OnClicked(object sender, EventArgs e)
        {
            MyProfilePage profile = new MyProfilePage();
            await this.Navigation.PushAsync(profile);
        }
    }
}