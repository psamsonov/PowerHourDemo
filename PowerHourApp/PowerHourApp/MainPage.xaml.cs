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
            Pin pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(43.643634, -79.4036502),
                Label = "KG",
                Address = "445 King St. West"
            };
            pin.Clicked += Pin_Clicked;
            PowerHourMap.Pins.Add(pin);
		}

        private void Pin_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.konradgroup.com/"));
        }
    }
}
