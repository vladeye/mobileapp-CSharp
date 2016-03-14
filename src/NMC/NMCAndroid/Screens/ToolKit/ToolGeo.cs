
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
	class ToolGeo
	{

		public static void pintarImagen (ImageView control, string direccion)
		{
			if( direccion.Equals("Norte"))
				control.SetImageResource(Resource.Drawable.n);
			else
				if( direccion.Equals("Nor-Este"))
					control.SetImageResource(Resource.Drawable.n_e);
			else 
				if( direccion.Equals("Este"))
					control.SetImageResource(Resource.Drawable.e);
			else 
				if( direccion.Equals("Sur-Este"))
					control.SetImageResource(Resource.Drawable.s_e);
			else 
				if( direccion.Equals("Sur"))
					control.SetImageResource(Resource.Drawable.s);
			else 
				if( direccion.Equals("Sur-Oeste"))
					control.SetImageResource(Resource.Drawable.s_o);
			else 
				if( direccion.Equals("Oeste"))
					control.SetImageResource(Resource.Drawable.o);
			else 
				control.SetImageResource(Resource.Drawable.n_o);
			
		}

		public static void pintarStatus (ImageView control, char status)
		{
			switch (status)
			{
				case 'A': control.SetImageResource(Resource.Drawable.history_blue); break;
				case 'P': control.SetImageResource(Resource.Drawable.history_green); break;
				case 'R': control.SetImageResource(Resource.Drawable.history_red); break;
			}
			
		}
		
	}
}

