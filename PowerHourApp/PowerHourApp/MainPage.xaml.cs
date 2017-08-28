using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PowerHourApp
{
	public partial class MainPage : CarouselPage
    {
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new ContactDetailPage("Multiplatform support"));
            Children.Add(new ContactDetailPage("Write once, run everywhere (totally works)"));
            Children.Add(new ContactDetailPage("C# is great"));

        }

    }
}
