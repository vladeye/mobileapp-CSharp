
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NMCAndroid
{
	[Activity (Label = "Acordeon")]			
	public class Acordeon : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
						
			ScrollView scroll = new ScrollView (this);	
			LinearLayout contenedor = new LinearLayout(this);
			scroll.AddView (contenedor);
			SetContentView(Resource.Layout.Acordeon);

		}
	}
}

