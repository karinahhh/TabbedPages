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
	public partial class Page11 : ContentPage
	{
		public Page11()
		{
			InitializeComponent();
			var bas = new TapGestureRecognizer();
			ind.GestureRecognizers.Add(bas);
			bas.Tapped += Bas_Tapped;

			var bas2 = new TapGestureRecognizer();
			ind2.GestureRecognizers.Add(bas2);
			bas2.Tapped += Bas2_Tapped;

			var bas3 = new TapGestureRecognizer();
			ind3.GestureRecognizers.Add(bas3);
			bas3.Tapped += Bas3_Tapped;
		}

		private void Bas3_Tapped(object sender, EventArgs e)
		{
			ind3= sender as Frame;
			DisplayAlert("Ijeni kraater", "Võta end kokku ja luba endale üks magamata öö, et laskuda väävlit pritsiva vulkaani kraatrisse Ida-Jaaval. Samal ajal kui kohalikud töömehed tundidepikkusel rännakul korvidega kollaseid väävlitükke üles-alla tassivad, jalutad sina, gaasimask peas, siniste sädemete ja mürgiste gaaside poole. Aga see on vaeva väärt – nii kui päike tõuseb, avaneb sulle vaade üle helesinise järve kraatri põhjas.", "Aitäh");
		}

		private void Bas2_Tapped(object sender, EventArgs e)
		{
			ind2 = sender as Frame;
			DisplayAlert("Borobudur", "Budistlik Borobuduri tempel on vinge, eriti kui oled seal kohal varahommikul, mil turiste on veel vähe. Aga veel vingem on tempel iga-aastase Vesaki festivali ajal, mil budistlikud mungad üle maailma sinna rändavad, et Buddha sündi, surma ja hiilgust tähistada. Laternad lendavad, kõlaritest kostavad palvused ja kogu öö lausa särab maagiast.", "Aitäh");
		}

		private void Bas_Tapped(object sender, EventArgs e)
		{
			ind = sender as Frame;
			DisplayAlert("Warung", "Hüvasti, hügieen! Söö parem tänavaäärses warung’is või osta toitu mõnest kärust, mis mööda veereb. Nasi goreng (praeriis), masakan Padang (Padangi päritolu toit), pepes ikan (vürtsikas kala banaanilehes) – nendest sa ei pääse. Kui magusat igatsed, telli üks rasvane martabak – kook juustu, või ja šokolaadiga – ning rüüpa peale tomati-maasika värskelt pressitud segumahla.", "Aitäh");
		}
	}
}