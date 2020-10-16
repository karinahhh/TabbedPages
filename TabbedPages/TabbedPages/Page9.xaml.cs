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
	public partial class Page9 : ContentPage
	{
		public Page9()
		{
			InitializeComponent();
			var sad = new TapGestureRecognizer();
			kuuba.GestureRecognizers.Add(sad);
			sad.Tapped += Sad_Tapped;

			var sad2 = new TapGestureRecognizer();
			kuuba2.GestureRecognizers.Add(sad2);
			sad2.Tapped += Sad2_Tapped;

			var sad3 = new TapGestureRecognizer();
			kuuba3.GestureRecognizers.Add(sad3);
			sad3.Tapped += Sad3_Tapped;
		}

		private void Sad3_Tapped(object sender, EventArgs e)
		{
			kuuba3 = sender as Frame;
			DisplayAlert("Trinidad", "Trinidad on tänapäeval üks parimaid Kuuba külastatavaid linnu peale Havana. Võite oma praeguse atmosfääri nautida Plaza Mayor, linna keskväljak. Ruutu kõrgus on neoklassikaline Püha Kolmainsuse kirik (Iglesia Parroquial de la Santisima Trinidad). Teised esiletõstetud on Püha Francisuse kirik ja klooster (Iglesia y Convento de San Francisco), millel on oma iseloomulik kellatorn; a Koloniaalarhitektuuri muuseum (Museo de Arquitectura Colonial); kunstigalerii Casa de Aldeman Ortiz; ja Palacio Brunet, suur köök, mis on ehitatud 1812. aastal ja kus esinevad originaalsed freskojad ja marmorpõrandad.", "Aitäh");
		}

		private void Sad2_Tapped(object sender, EventArgs e)
		{
			kuuba2 = sender as Frame;
			DisplayAlert("Varadero", "Varadero on üks Kuuba kõige kuulsamad rand sihtkohad ja on üks Kariibi mere parimaid randu. See ulatub piki Hicacose poolsaaret, mis ulatub mereni põhja rannikult, kus tõmbekanal ühendab selle mandriosaga. See populaarne peopesamaine riba on üle 50 hotelli ja selle suurepärased valge liivaga rannad meelitavad külastajaid kogu maailmast. Tähtsündmused hõlmavad Parque Natural Punta Hicacos (Parque Natural de Varaderos), päris rannas olev looduskaitseala ja kaks koobast Cueva de Ambrosio ja Cueva de Musulmanes.", "Aitäh");
		}

		private void Sad_Tapped(object sender, EventArgs e)
		{
			kuuba = sender as Frame;
			DisplayAlert("Vana Havana", "UNESCO maailmapärandi nimistusse Habana Vieja või vana Havana on hästi säilinud Kuuba ajaloo viil. Varjatud munakividest tänavate ümber ja vaatega suurtele barokk- ja neoklassikalistele hoonetele on lihtne ette kujutada, milline elu Kuubal oli nagu 200 aastat tagasi. Laialdased renoveerimistööd hoogustavad nüüdisaegseid hooneid. Siin on peamised vaatamisväärsused Plaza de la Catedral, kus asub Kuuba barokk San Cristobali katedraal; legendaarne restoran ja Hemingway hangout Bodeguita del Medio; ja sõjaline linnus Castillo de la Real Fuerza.", "Aitäh");
		}
	}
}