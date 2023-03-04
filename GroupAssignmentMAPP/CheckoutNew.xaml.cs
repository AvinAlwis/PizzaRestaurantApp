using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupAssignmentMAPP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheckoutNew : TabbedPage
	{
		App app = (App)Application.Current; //Getting global variables from App.cs
		public CheckoutNew()
		{
			InitializeComponent();
			if (app.LoggedIn) //Checking if user is logged in
			{
				//Not displaying fields when user is logged in
				lblFN.IsVisible = false;
				txtFirstname.IsVisible = false;
				lblSN.IsVisible = false;
				txtSurname.IsVisible = false;
				lblAdd.IsVisible = false;
				txtAddress.IsVisible = false;
				lblCN.IsVisible = false;
				txtContactNumber.IsVisible = false;
				lblEmail.IsVisible = false;
				txtEmail.IsVisible = false;
				lblFN2.IsVisible = false;
				txtFirstname2.IsVisible = false;
				lblSN2.IsVisible = false;
				txtSurname2.IsVisible = false;
				txtEmail2.IsVisible = false;
				lblEmail2.IsVisible = false;
				lblDel.IsVisible = false;
				lblDel2.IsVisible = false;

			}
			else
			{
				//Displaying fields when user is logged in
				lblFN.IsVisible = true;
				txtFirstname.IsVisible = true;
				lblSN.IsVisible = true;
				txtSurname.IsVisible = true;
				lblAdd.IsVisible = true;
				txtAddress.IsVisible = true;
				lblCN.IsVisible = true;
				txtContactNumber.IsVisible = true;
				lblEmail.IsVisible = true;
				txtEmail.IsVisible = true;
				lblFN2.IsVisible = true;
				txtFirstname2.IsVisible = true;
				lblSN2.IsVisible = true;
				txtSurname2.IsVisible = true;
				txtEmail2.IsVisible = true;
				lblEmail2.IsVisible = true;
				lblDel.IsVisible = true;
				lblDel2.IsVisible = true;
			}

		}

		private async void btnCheckoutTakeaway_Clicked(object sender, EventArgs e)
		{

			if(txtEmail2.Text == null || txtFirstname2.Text == null || txtSurname2.Text == null)
			{
				await DisplayAlert("Invalid Data", "Please enter data in all fields", "Ok");
				return;
			}

			//Setting DeliveryType as Takeaway
			app.DeliveryType = "Delivery Type: Takeaway";
			//Navigation
			await Navigation.PushAsync(new CheckoutSuccess());
		}

		private async void btnCheckoutDelivery_Clicked(object sender, EventArgs e)
		{
			if(txtAddress.Text == null || txtContactNumber.Text == null || txtEmail.Text == null || txtFirstname.Text == null || txtSurname.Text == null)
			{
				await DisplayAlert("Invalid Data", "Please enter data in all fields", "Ok");
				return;
			}
			//Setting DeliveryType as Delivery
			app.DeliveryType = "Delivery Type: Delivery";
			//Navigation
			await Navigation.PushAsync(new CheckoutSuccess());
		}

		private  async void btnAbout_Clicked(object sender, EventArgs e)
		{
			//Navigation
			await Navigation.PushAsync(new AboutPage());
		}
	}
}