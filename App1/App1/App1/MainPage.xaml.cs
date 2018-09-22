using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAndroidApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		void OnButtonClicked(object sender, EventArgs args)
		{
			lblSaluto.Text = "Ciao a tutti";
			int a = Convert.ToInt32(txtNum1.Text);
			int b = Convert.ToInt32(txtNum2.Text);
			int somma = a + b;
			lblRisultato.Text = somma.ToString();
		}
	}
}
