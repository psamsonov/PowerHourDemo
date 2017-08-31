using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PowerHourApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem("Reason 4", "XAML is also pretty good"));
            masterPageItems.Add(new MasterPageItem("Reason 5", "Visual Studio never crashes"));
            masterPageItems.Add(new MasterPageItem("Reason 6", "Bottom text"));

            listView.ItemsSource = masterPageItems;
        }

        public ListView getListView()
        {
            return listView;
        }
	}

    class MasterPageItem
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public string IconSource { get; set; }

        public MasterPageItem(string title, string contents)
        {
            Title = title;
            IconSource = "button.png";
            Contents = contents;
        }
    }
}