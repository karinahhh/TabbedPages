
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
            var tap = new TapGestureRecognizer();
            saks.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

            var tap2 = new TapGestureRecognizer();
            saks2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

            var tap3 = new TapGestureRecognizer();
            saks3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
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

		private void Tap3_Tapped(object sender, EventArgs e)
		{
            saks3 = sender as Frame;
            DisplayAlert("Schwarzwald ehk 'Mustmets'", "Schwarzwald ehk “must mets” on oma sügavate tumedate metsadega üks kõige huvitavamaid paiku Euroopas. See maagiline mets asub Saksamaa edelaosas ning ulatub lausa 160 kilomeetri kaugusele.", "Aitäh");

        }

        private void Tap2_Tapped(object sender, EventArgs e)
		{
            saks2 = sender as Frame;
            DisplayAlert("Brandenburgi värav", "Muljetavaldav 26 meetri kõrgune värav ehitati omal ajal kuningas Frederick William II auks.", "Aitäh");
        }

		private void Tap_Tapped(object sender, EventArgs e)
		{
            saks = sender as Frame;
            DisplayAlert ("Berliini müür", "Berliini müür ei pruugi olla küll piltilus paik, kuid kes külastab Berliini, peaks seda kindlasti nägema koha ajaloolisuse tõttu.", "Aitäh");
		}
	}
}