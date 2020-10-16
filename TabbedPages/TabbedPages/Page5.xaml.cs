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
			InitializeComponent();
			var bap = new TapGestureRecognizer();
			groo.GestureRecognizers.Add(bap);
			bap.Tapped += Bap_Tapped;

			var bap2 = new TapGestureRecognizer();
			groo2.GestureRecognizers.Add(bap2);
			bap2.Tapped += Bap2_Tapped;

			var bap3 = new TapGestureRecognizer();
			groo3.GestureRecognizers.Add(bap3);
			bap3.Tapped += Bap3_Tapped;
		}

		private void Bap3_Tapped(object sender, EventArgs e)
		{
			groo2 = sender as Frame;
			DisplayAlert("Qaqortoqi muuseum ", "Qaqortoq on eredalt maalitud majadega kividega seotud kaluriküla, mis ronib sadama kohal mäenõlvale. Qaqortoqi muuseum, mis asus 1804. aastal hoones, mis oli kunagi Julianehåbi koloonia juhataja, oli eksponeeritud Dorseti, Thule ja Põhjamaade kultuuride esemeid, millel on eraldi eksponaadid ja tõlgendused.", "Aitäh");
		}

		private void Bap2_Tapped(object sender, EventArgs e)
		{
			groo = sender as Frame;
			DisplayAlert("Uunartoqi kuumaveeallikad", "Kuumaveeallikaid leidub kogu Gröönimaal, kuid asustamata Uunartoqi saarel on allikad suplemiseks ideaalne temperatuur. Siin sulanduvad kolm looduslikult soojendatud allikat väikesesse basseini, kus saate end ümbritseda jäämägede ja uimaste mäetippude poolt.", "Aitäh");
		}

		private void Bap_Tapped(object sender, EventArgs e)
		{
			groo = sender as Frame;
			DisplayAlert("Nuuk - Gröönimaa pealinn", "Nuuk, Gröönimaa pealinn ja halduskeskus, elab umbes 16 000 inimest ja on Gröönimaa rahvusmuuseumi külastajate seas eriti populaarne . Selle jahitarvete, süstade, nikerduste ja Vikingi leidude kollektsioonid maalivad ereda pildi siinse elu algusest peale.", "Aitäh");
		}
	}
}