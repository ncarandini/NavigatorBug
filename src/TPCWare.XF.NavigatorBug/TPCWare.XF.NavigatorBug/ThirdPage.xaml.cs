using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPCWare.XF.NavigatorBug
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPage : ContentPage
	{
		public ThirdPage ()
		{
			InitializeComponent ();
		}

        private async void GoBackButton_Clicked(object sender, EventArgs e)
        {
            var secondPage = Navigation.NavigationStack.LastOrDefault(p => p is SecondPage);

            if (secondPage != null)
            {
                Navigation.RemovePage(secondPage);
            }

            await Navigation.PopAsync();
        }
    }
}