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
	public partial class Page12 : ContentPage
	{
		public Page12()
		{
			InitializeComponent();
			var bsa = new TapGestureRecognizer();
			hin.GestureRecognizers.Add(bsa);
			bsa.Tapped += Bsa_Tapped;

			var bsa2 = new TapGestureRecognizer();
			hin2.GestureRecognizers.Add(bsa2);
			bsa2.Tapped += Bsa2_Tapped;

			var bsa3 = new TapGestureRecognizer();
			hin3.GestureRecognizers.Add(bsa3);
			bsa3.Tapped += Bsa3_Tapped;
		}

		private void Bsa3_Tapped(object sender, EventArgs e)
		{
			hin3 = sender as Frame;
			DisplayAlert("Redaktori valik Terrakota armee", "Xi'ani külaelu kaevamine 1970. aastatel, kui talupidajad komistasid selle üle, mis oli kahtlemata Hiina kõige olulisem arheoloogiline leid: Terrakota armee. Kõigi kolme suurte maa-aluste süvendite jaoks, mis olid ehitatud esimest imperaatori hauda valvamiseks, oli enam kui 8000 elussuurusega sõdalast, ligikaudu 520 hobust ja enam kui 100 sõjaväeosa koos paljude teiste mittesõjaliste tegelastega, mis pärinesid umbes 280 eKr.", "Aitäh");
		}

		private void Bsa2_Tapped(object sender, EventArgs e)
		{
			hin2 = sender as Frame;
			DisplayAlert("Keelatud linn ja kuninglik palee Pekingis", "Hiina suurim ja kõige olulisem hoone, Keelatud Linn - tuntud ka kui Imperial Palace - on Pekingi südames ja see peab olema riigist külastades. Alanud ajavahemikul 1271-1368 Yuani dünastia ajal tekkis suur osa tänapäevasest kompleksist (see on tõesti palju suurepäraseid paleisid ühes), mis ehitati ajavahemikus 1406-1420 kui 24 Mingi ja Qingi keisri elukoht, mille kohalolek keelas kedagi peale impeeriumi perekond ja nende kutseteanss. See ulatuslik kompleks hõlmab umbes 720 000 ruutmeetrit ja 10 meetri kõrgune seina, mis on kaitstud valvuritega ja laia ääriga.", "Aitäh");
		}

		private void Bsa_Tapped(object sender, EventArgs e)
		{
			hin = sender as Frame;
			DisplayAlert("Toimetaja valib hiina müüri", "Suurepärane Hiina suurlaager - tuntud hiina keelt kui Changcheng või Long Wall - ulatub üle 6000 kilomeetri kaugusel Shanhaiguani kindlusest ida pool Jiayuguani läänes, läbides Hebei, Tientsini, Pekingi - kus on kõige paremini säilinud lõik seest saab külastada - Sise-Mongoolia, Ningxia ja Gansu mööda teed. Keskmiselt kuus kuni kaheksa meetrit kõrgemal, kuid tõustes kuni 16 meetri paiku ja piisavalt lai, et ratsavägi läbida, on seinal hulk arvukaid torni ja vaatetorne, millest mõned ulatuvad 7. sajandist eKr, kõige tuntumate alade umbes 210 eKr, kui tema eri osad ühinesid.", "Aitäh");
		}
	}
}
/*
 * hin2 = sender as Frame;
			DisplayAlert("","","Aitäh");
*/