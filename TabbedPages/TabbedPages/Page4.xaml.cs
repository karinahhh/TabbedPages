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
	public partial class Page4 : ContentPage
	{
		public Page4()
		{
			InitializeComponent();
			var tap = new TapGestureRecognizer();
			bras.GestureRecognizers.Add(tap);
			tap.Tapped += Tap_Tapped;

			var tap2 = new TapGestureRecognizer();
			bras2.GestureRecognizers.Add(tap2);
			tap2.Tapped += Tap2_Tapped;

			var tap3 = new TapGestureRecognizer();
			bras3.GestureRecognizers.Add(tap3);
			tap3.Tapped += Tap3_Tapped;
		}

		private void Tap3_Tapped(object sender, EventArgs e)
		{
			bras3 = sender as Frame;
			DisplayAlert("Sukrupeamägi", "Suhkrupeamägi asub Rio de Janeiros.Mägi tõuseb merepinnast 396 m kõrgusele. Tippu viib 1400 m pikkune köisraudtee mis kannatab 65 inimese raskust, mäetipust avaneb suurepärane vaade Atlandi ookeanile, Rio de Janeiro linnale ja Lunastaja Kristuse kujule.", "Aitäh");
		}

		private void Tap2_Tapped(object sender, EventArgs e)
		{
			bras2 = sender as Frame;
			DisplayAlert("Lunastaja Kristuse kuju", "Lunastaja Kristuse kuju Rio de Janeiro-s on Brasiilia ja kogu maailma suurim Art Deco stiilis skulptuur.Kuju on 39,6 meetrit kõrge ja kaalub 635 tonni. Merepinnast on Jeesuse kuju umbes 700 meetri kõrgusel. Kuju on valmistatud raudbetoonist javoolukivist. Lunastaja Kristuse kuju on katoliikluse sümbol Brasiilias", "Aitäh");
		}

		private void Tap_Tapped(object sender, EventArgs e)
		{
			bras = sender as Frame;
			DisplayAlert("Iguazu joad", "Iguazu joad asuvad Argentiina ja Brasiilia piiri peal.  Joad on maailma võimsaim jugade kompleks ning üks seitsmest uuest loodusimest. See on 2,7 kilomeetrit pikk, 82 meetrit kõrge ning koosneb 270 joast.", "Aitäh");
		}
	}
}

