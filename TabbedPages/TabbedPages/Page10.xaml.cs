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
	public partial class Page10 : ContentPage
	{
		public Page10()
		{
			InitializeComponent();
			var das = new TapGestureRecognizer();
			jap.GestureRecognizers.Add(das);
			das.Tapped += Das_Tapped;

			var das2 = new TapGestureRecognizer();
			jap2.GestureRecognizers.Add(das2);
			das2.Tapped += Das2_Tapped;

			var das3 = new TapGestureRecognizer();
			jap3.GestureRecognizers.Add(das3);
			das3.Tapped += Das3_Tapped;
		}

		private void Das3_Tapped(object sender, EventArgs e)
		{
			jap3 = sender as Frame;
			DisplayAlert("Hiroshima rahu mälestuspark", "Siiski, kui 1945. aasta augustis Hiroshima aurinkombinatsiooni õudusi peetakse väga vähe, võib öelda palju sellest, et see elav linn on teinud maailma esimese tuumarünnaku ohvrite mälestuseks ja võib-olla veelgi olulisemaks Hiroshima püsiva rahu sümbol on sellest ajast alates saanud. Hiroshima rahu mälestusparki (Hiroshima Heiwa Kinen Kōen) külastavad rohkem kui miljon inimest aastas, paljud Hiinast pärit ülemeremaadest paiknevad tuumalõhkkonna epitsentril, mis oli kunagi linna pealetükkiv osa, ja sisaldab mitmeid olulisi mälestisi, memoriaalid ja muuseumid, mis on seotud selle saatusliku päeva sündmustega.", "Aitäh");
		}

		private void Das2_Tapped(object sender, EventArgs e)
		{
			jap2 = sender as Frame;
			DisplayAlert("Imperial Tokyo", "okyo kõige kuulsam maamärk Imperial Palace mille seina ja küngastega ümbritsetud ilusad 17. sajandist pärinevad pargid on rahva pealinna külastamiseks vajalik. Ärge jätke ära asjaolu, et enamus paleest on üldsusele suletud (see on ikka veel kasutuses Imperial perekond), kuna seal on veel piisavalt, et näha lihtsalt põhjuste jalutama. Lisaks paljudele suurepärilistele vaadetega paleele paljudest punktidest ümbritsevas pargis - kaasa arvatud kuulus Nijubashi sildvõi 'kahekordne sild', mida nimetatakse selle veetse peegeldusena - külastajad on lubatud Ida-Higashi-Gyoen aed, üks väheseid üldsusele avatud alasid.", "Aitäh");
		}

		private void Das_Tapped(object sender, EventArgs e)
		{
			jap = sender as Frame;
			DisplayAlert("Fuji mägi", "Kahtlemata on Jaapani kõige äratuntav maamärk, majesteetlik Fuji mägi (Fuji-san) on ka riigi kõrgeim mägi tipp, mis tõuseb 3776 meetri võrra üle muidu suuresti lameda maastiku lõuna ja ida poole, piisavalt pikk, et sellest Tokyost näha üle 100 kilomeetri ära. Fuji mäel on sajandeid tähistatud kunstis ja kirjanduses ning seda peetakse nüüd oluliseks ikooniks, mille UNESCO tunnustas oma maailma kultuurilise tähenduse 2013. aastal.", "Aitäh");
		}
	}
}