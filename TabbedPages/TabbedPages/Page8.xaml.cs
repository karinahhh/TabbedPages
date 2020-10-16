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
	public partial class Page8 : ContentPage
	{
		public Page8()
		{
			InitializeComponent();
			var cli = new TapGestureRecognizer();
			meh.GestureRecognizers.Add(cli);
			cli.Tapped += Cli_Tapped;

			var cli2 = new TapGestureRecognizer();
			meh2.GestureRecognizers.Add(cli2);
			cli2.Tapped += Cli2_Tapped;

			var cli3 = new TapGestureRecognizer();
			meh3.GestureRecognizers.Add(cli3);
			cli3.Tapped += Cli3_Tapped;
		}

		private void Cli3_Tapped(object sender, EventArgs e)
		{
			meh3 = sender as Frame;
			DisplayAlert("Tulum", "Tulumis asuvad ainsad maiade varemed, mis on mere kaldal. Pärast seda, kui oled lauspäikese käes varemeid imetlenud, on ideaalne jalutada veidi eemale ning sulpsata merevette. Tõsi küll, tegemist on Mehhiko mõistes siiski keskpäraste randadega. Hoopis parem idee on sõita Tulumist näiteks Akumali randa (mikrobussiga umbes 20 minutit), kus on võimalik kilpkonnadega ujuda.", "Aitäh");
		}

		private void Cli2_Tapped(object sender, EventArgs e)
		{
			meh2 = sender as Frame;
			DisplayAlert("Isla Holbox", "Et saada Holboxi saarele, tuleb sõita Cancúnist 140 kilomeetrit põhja poole Chiquilasse. Kui Cancun on pigem turistirohke, siis Chiquila näol on tegemist unise kalurikülaga. Inimesed tulevad sinna vaid selleks, et sõita laevaga poole tunni kaugusel asuvale Holboxi saarele. Holboxi rannad on sama lummavad nagu Mujeresil – võib-olla isegi kaunimad. Siin on aga väike nõks: linna (küla?) keskme lähedal asuvad pigem keskpärased rannad. Hakka kõndima mööda randa ja juba poole tunni pärast vaatavad vastu vaated, mida poleks osanud oodatagi.", "Aitäh");
		}

		private void Cli_Tapped(object sender, EventArgs e)
		{
			meh = sender as Frame;
			DisplayAlert("Isla Mujeres", " Kariibi mere ääres asuvasse turistimekasse Cancúni on soodsam lennata kui nii mõnessegi teise Mehhiko linna. Cancúnis iseenesest kuigi palju teha ei ole ning peaasjalikult on seal hotellidele kuuluvad rannad. Cancúnist tunnise laevasõidu kaugusel asub aga Isla Mujeres ehk Naiste saar. Tõsi küll, sealgi kipub olema palju turiste (eriti nädalavahetusel, sest siis lähevad sinna ka mehhiklased), kuid rannad on IMELISED. Kõige populaarsemaks rannaks on pikk Playa del Norte ehk Põhjarand. Vesi on kristallselge, helesinine ja soe.", "Aitäh");
		}
	}
}