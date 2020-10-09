using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPage1 : TabbedPage
	{
		public TabbedPage1()
		{
			Label lbl;
			InitializeComponent();
			lbl = new Label
			{
				Text = "Kus saab puhata Euroopas",
				FontSize=30
			};


		}
	}
}