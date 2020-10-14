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
	public partial class Page2 : ContentPage
	{
		public Page2()
		{
			InitializeComponent();
			//https://www.arcgis.com/apps/MapJournal/index.html?appid=619376a0229a4c45820b79c2e8f55e90&webmap=bec2e32e91474227ae2d0701a5241c6e
			var tap = new TapGestureRecognizer();
			prants.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

			var tap2 = new TapGestureRecognizer();
			prants2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

			var tap3 = new TapGestureRecognizer();
			prants3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
		}

		private void Tap3_Tapped(object sender, EventArgs e)
		{
			prants3 = sender as Frame;
			DisplayAlert("Arc de Triomphe", "See on üks Pariisi kuulsamaid ja külastatumaid vaatamisväärsusi. See asub ühe suure teede ristmiku – Place Charles de Gaulle'i keskel.", "Aitäh");
		}

		private void Tap2_Tapped(object sender, EventArgs e)
		{
			prants2 = sender as Frame;
			DisplayAlert("Eiffeli torn", "Torn on saanud oma nime kogu projekti juhtinud ettevõtja Gustave Eiffeli järgi, arhitekt oli Stephen Sauvestre. Ehitamist alustati 1887 ja torn valmis 1889. aasta Pariisi maailmanäituseks, et sellega tähistada Prantsuse Revolutsiooni 100. aastapäeva.", "Aitäh");
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			prants = sender as Frame;
			DisplayAlert("Pont-Neuf", "Pont Neuf on vanim säilinud sild Pariisis. Sild on 238 meetrit pikk ja 20 meetrit lai.See ühendab Quai de Louvre'it ja Quai de la Mégisserie'd Seine'i paremal kaldal (1. ringkond ehkarrondissement) Quai de Conti ja Quai des Grands Augustins'iga jõe vasakul kaldal(6.ringkond).","Aitäh");
		}
	}
}