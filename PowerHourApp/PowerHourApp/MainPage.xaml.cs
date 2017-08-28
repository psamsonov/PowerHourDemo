using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PowerHourApp
{
	public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();
            
        }

        public async void OnPushButtonClicked(object sender, EventArgs e)
        {
            MainPage nextPage = new MainPage();
            nextPage.BindingContext = new StackSizeViewModel(BindingContext==null?1:(BindingContext as StackSizeViewModel).StackSize + 1);
            await Navigation.PushAsync(nextPage);
        }

        public async void OnPopButtonClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception)
            {
                await DisplayAlert("Cannot pop", "Cannot pop stack, are there any pages left?", "OK");
            }
        }
    }

    class StackSizeViewModel
    {
        public int StackSize { get; set; }
        public StackSizeViewModel(int size)
        {
            StackSize = size;
        }

    }
}
