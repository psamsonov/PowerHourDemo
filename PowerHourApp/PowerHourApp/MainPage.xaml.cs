using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PowerHourApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello, World!", String.Format("Welcome to Xamarin on {0} {1} ", Device.RuntimePlatform, Device.Idiom), "OK");
        }
    }
}
