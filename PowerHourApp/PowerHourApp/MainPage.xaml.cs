using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PowerHourApp
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();
            masterPage.getListView().ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new ContactDetailPage(item.Title, item.Contents);
                masterPage.getListView().SelectedItem = null;
                IsPresented = false;
            }
        }
    }
    
}
