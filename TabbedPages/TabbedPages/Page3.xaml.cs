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
	public partial class Page3 : ContentPage
	{
		public Page3()
		{
			InitializeComponent();
			//https://et.tripnholidays.com/1495-italy-i-et
			var tap = new TapGestureRecognizer();
			ital.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

			var tap2 = new TapGestureRecognizer();
			ital2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

			var tap3 = new TapGestureRecognizer();
			ital3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
		}

		private void Tap3_Tapped(object sender, EventArgs e)
		{
			ital3 = sender as Frame;
			DisplayAlert("Pompei", "Metsa suitsetav vulkaan Vesuvius vaatab selle linna jäänuste hulka, mida see hävines AD 79-s. Kuid sama purskus säilitas ka paljud linna kunstiväärtused: freskot, mosaiiki ja skulptuure, mis olid lava ümbritsetud nii, et see jahutati. Mitmed sajandeid tehtud kaevamised on näidanud majade, turgude, vannide, templite, teatrite, tänavade ja inimeste jääkide jäänuseid.", "Aitäh");

		}

		private void Tap2_Tapped(object sender, EventArgs e)
		{
			ital2 = sender as Frame;
			DisplayAlert("Veneetsia kanalid", "Veneetsia kanalite kaudu sõitmine gondliga on traditsioon, mida reisijad on sajandeid naudinud. Veneetsia on saarte linn ja kanalid on pikka aega olnud linna peamised tänavad, mis on ühendatud kitsaste koridoride labürindiga. Kanalite vooderdamine on vanad ehitised, mis on sadade aastate jooksul suhteliselt muutumatud, lisades romantilisele võlule.", "Aitäh");
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			ital = sender as Frame;
			DisplayAlert("Colosseum", "Ehitatud koht avalike näkide ja näitab - isegi mõnitama mere lahingud, oli see puitpõrand, mis oli 83 48 meetrit. Selle all olid kaks lugusid tunnelitest, ruumidest, lahtritest ja lõigudest gladiaatoritele, töötajatele, metsloomadele ja ladudele.", "Aitäh");
		}
	}
}

