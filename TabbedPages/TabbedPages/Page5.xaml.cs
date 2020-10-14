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
	public partial class Page5 : ContentPage
	{
		public Page5()
		{
			var tap = new TapGestureRecognizer();
			arg.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

			var tap2 = new TapGestureRecognizer();
			arg2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

			var tap3 = new TapGestureRecognizer();
			arg3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
		}

		private void Tap3_Tapped(object sender, EventArgs e)
		{
			arg3 = sender as Frame;
			DisplayAlert("Ushuaia: maailma lõpp", "Argentina lõunaosas Patagonia on kuulus oma suurepäraste maastike poolest: dramaatiline Andide ja pikkade tasandike ja platoosidega segu. Enamik seiklusi siin algab Ushuaia, maailma kõige lõunapoolsem linn. 20. sajandi alguses rajatud karistusjärgseks kolooniaks, mis on nüüd populaarne Antarktika ja selle ümbruse Cape Horni matkadest Beagle Channel on ümbritsetud unikaalse maastikuga mägedes, meres, liustikes ja metsas Tierra del Fuego rahvuspark selle suurepärase maastikuga ning mitmekesise taimestiku ja loomastikuga.", "Aitäh");
		}

		private void Tap2_Tapped(object sender, EventArgs e)
		{
			arg2 = sender as Frame;
			DisplayAlert("Buenos Aires: Barriose linn", "Üks Lõuna-Ameerika kõige atraktiivsematest linnadest (ka üks suurimaid), on Buenos Aires sageli Argentina esmakordne pilguheit, mida külastajad saavad enne populaarsete turismisihtkohtade, nagu näiteks Patagonia, külastamist. Kuid nutikad jäävad siin siia ja võtavad vastu palju suurepäraseid vanu kolooniahooneid, mis asuvad kogu linnaosades või 'barriosides' asuvate paljude suurepäraste muuseumide ja kunstigaleriide juures. Kindlasti külastame must-see barriose La Boca, Buenos Airese kõige värvikas naabrus ja kodune lõbus Caminito tänava muuseum, suurepärane jalakäijate tsoon ja vabaõhumuuseum, mis on populaarne oma heledalt maalitud maja ees, lõbusad skulptuurid ja tango õppetundid.", "Aitäh");
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			arg = sender as Frame;
			DisplayAlert("Perito Moreno Glacier", "Patagonia UNESCO maailmapärandi nimistusse külastavate turistide peamine tuum Los Glaciaresi rahvuspark, väikelinnas El Calafate pakub mitmeid majutusvõimalusi ja muid mugavusi külastajatele. Siin on enamus külastajaid, kes külastavad ekskursioone, et näha pargi populaarseid liustikke, eriti uhke Perito Moreno Glacier'i, 30 km pikkust jääkoormust (ja maailma suuruselt kolmas mageveevaru) vaid 78 km kaugusel kesklinnast.", "Aitäh");
		}
	}
}