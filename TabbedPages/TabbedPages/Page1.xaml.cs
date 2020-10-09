
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
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
            /*
                        lbl = new Label()
                        {
                            Text = "Berliini müür",
                            TextColor = Color.Black,
                            FontSize = 15
                        };
                        a = new Frame()
                        {
                            BackgroundColor = Color.LightBlue,
                            Content = lbl,
                            CornerRadius = 10,
                            Margin = new Thickness(150, 0, 150, 0)
                        };
                        StackLayout stackLayout = new StackLayout()
                        {
                            Children = { lbl }
                        };
                        stackLayout.Orientation = StackOrientation.Vertical;

                        https://www.germany.ee/10-koige-huvitavamat-vaatamisvaarsust-saksamaal/
            */
        }
    }
}