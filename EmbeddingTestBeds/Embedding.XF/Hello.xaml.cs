﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.XF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Hello : ContentPage
	{
		public Hello()
		{
			InitializeComponent();
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			this.Items[1].IsEnabled = !this.Items[1].IsEnabled;
		}
	}
}