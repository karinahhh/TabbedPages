﻿
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
	public partial class Page1 : ContentPage
	{
		Label lbl, lbl2;
		public Page1()
		{
			lbl = new Label()
			{
				Text = "Vana linn"
				
			};
			lbl2 = new Label()
			{
				Text = "Raekoja plats"
			};
			
		}
	}
}