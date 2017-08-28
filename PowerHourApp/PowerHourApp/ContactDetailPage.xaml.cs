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
	public partial class ContactDetailPage : ContentPage
	{

		public ContactDetailPage (string title, string text)
		{
			InitializeComponent ();
            BindingContext = new ContactDetailViewModel(title, text);
		}
	}

    class ContactDetailViewModel
    {
        public string ContentPageText { get; set; }
        public string ContentPageTitle { get; set; }

        public ContactDetailViewModel(string title, string text)
        {
            ContentPageText = text;
            ContentPageTitle = title;
        }
    }

}