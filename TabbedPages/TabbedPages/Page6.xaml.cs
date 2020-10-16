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
	public partial class Page6 : ContentPage
	{
		public Page6()
		{
			InitializeComponent();
			var tap = new TapGestureRecognizer();
			colum.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

			var tap2 = new TapGestureRecognizer();
			colum2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

			var tap3 = new TapGestureRecognizer();
			colum3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
		}

		private void Tap3_Tapped(object sender, EventArgs e)
		{
			colum3 = sender as Frame;
			DisplayAlert("Guadalupe'i Neitsi Maarja mägi", "Kolumbia pealinna patroon on Guadalupe'i Neitsi Maarja. See on kõige austusväärne Ladina-Ameerika pühamu. Tema viieteistkümne meetri pikkune kuju on paigutatud Bogotale Guadalupe'i mäe peal 3317 meetrit. Veidi skulptuuri all on väike kirik, mille lähedal on kaunis vaateplatvorm, kust avanevad maalilised panoraamvaated pealinnale. On legend, et Neitsi Maarja kujutis ilmus talupojale, kellele ta teatas oma soovist ehitada oma tempel mäele.","Aitäh");
		}

		private void Tap2_Tapped(object sender, EventArgs e)
		{
			colum2 = sender as Frame;
			DisplayAlert("Volcano Cerro Machin", "Los Nevadose rahvuspargi territooriumil on Colombia lääneosas Cerro Machin. Tal on mitu kõrgust. Suurim on kõrgusel 2750 meetrit merepinnast kõrgemal. Nende eripäraks on koonusekujuline vorm, mis on loodud paljude karastatud laava ja tuhkade kihiga. Seda vulkaani peetakse kõige ohtlikumaks, sest selle läheduses on asulaid. Iga vulkaanilise tegevuse märk võib põhjustada paanikat, nagu see oli 2008. aastal. Vulkanoloogide sõnul toimus viimane vulkaanipurse umbes 1200 aastat.", "Aitäh");
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			colum = sender as Frame;
			DisplayAlert("Arheoloogiline park", "Riigi lõunaosas San Augustini 30 tuhandes linnas avastati väljakaevamiste ajal unikaalsed arheoloogilised leiud Kolumbia eelse perioodi jooksul. Nende põhjal loodi arheoloogiline park, mis UNESCO sisaldas maailmapärandi nimekirja.Parki tunnuseks on kõige totemide ja kivist kujude ilus seisund.See on tingitud kohalike elanike esemete austamisest ja soodsast kohalikust kliimast.Pargi külastamisest saadav tulu on suur osa linna eelarvest.","Aitäh");
		}
	}
}