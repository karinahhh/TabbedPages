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
	public partial class Page7 : ContentPage
	{
		public Page7()
		{
			InitializeComponent();
			var haf = new TapGestureRecognizer();
			jam.GestureRecognizers.Add(haf);
			haf.Tapped += Haf_Tapped;

			var haf2 = new TapGestureRecognizer();
			jam2.GestureRecognizers.Add(haf2);
			haf2.Tapped += Haf2_Tapped;

			var haf3 = new TapGestureRecognizer();
			jam3.GestureRecognizers.Add(haf3);
			haf3.Tapped += Haf3_Tapped;
		}

		private void Haf3_Tapped(object sender, EventArgs e)
		{
			jam3 = sender as Frame;
			DisplayAlert("Dunni jõe kallas", "Lõbutseva täiskohaga lõbutsema jaoks proovige Jamaica Combo Touri: Dunn River Falls ja Bob Marley üheksa miili. See rong peatub Nine Mile'i küla, Bob Marley sünnikohas, seejärel läheb üle Dunni jõe kaldale, et sõita hüppeliselt matkata kuni kukkumise ja slaidini või ujuda looduslikesse basseinidesse. Lisavõimalused on hotellis, majutuskoha korrastamine ja sissepääs, sissepääs, lõunaeine ja juhend.", "Aitäh");
		}

		private void Haf2_Tapped(object sender, EventArgs e)
		{
			jam2 = sender as Frame;
			DisplayAlert("Rafting Martha Brae jõgi", "Martha Brae rafting on üks populaarsemaid asju Jamaical. Martha Brae Rafteri küla juures saate libiseb maalilise jõe äärde kohalike giidide poolt sobitatud bambuspartidel. See lõõgastav reis on suurepärane võimalus mõnda troopilist maastikku imeda ja mõned juhendid meelelahutavad teid mööda teed, lauldes või jagades teavet taimestiku ja loomastiku kohta.", "Aitäh");
		}

		private void Haf_Tapped(object sender, EventArgs e)
		{
			jam = sender as Frame;
			DisplayAlert("Negrili rand ja Negri liinid", "Tuntud ka kui Seven Mile'i rand, on Negri rand üks Jamaica kõige ilusamaid valge liiva ja akvaariumiga ning pakub Kariibi mere parimatele randadele nimekirja. Rand ulatub alates Verine laht et Long Bay ja linna lõuna pool asuv Negrilinen kaljud. Siin on kookospähkli peopesade kaste, siit rannikuäärseid kuurorte, alates suurtest kõikehõlmavatest kuurortidest kuni väiksemate butiikivarade külge.", "Aitäh");
		}
	}
}
/*
 * jam = sender as Frame;
			DisplayAlert("","","Aitäh");
*/