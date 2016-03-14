
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
using BRL;
using DTO;

namespace NMCAndroid
{
	[Activity (Label = "Pushed Coupon")]			
	public class PushedCoupon : Activity
	{
		/*estas dos variables representan mi ubicacion tomada del gps del telefono*/
		double latitudInicial = 40.979886271548764; 
		double longitudInicial = -104.72165468749992;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			
			ScrollView scroll = new ScrollView (this);	

			TableLayout tLPushedCoupons = new TableLayout(this);
			TableLayout.LayoutParams tLPPushedCoupons = new TableLayout.LayoutParams(LinearLayout.LayoutParams.FillParent, 
			                                                                         LinearLayout.LayoutParams.WrapContent);
			tLPPushedCoupons.SetMargins(5, 0, 5, 0);

			TextView tVLinea = new TextView(this);
			tVLinea.SetHeight (1);
			tVLinea.SetBackgroundColor(Android.Graphics.Color.Gray);

			tLPushedCoupons.AddView(tableImageText(), tLPPushedCoupons);
			tLPushedCoupons.AddView(tVLinea);
			tLPushedCoupons.AddView(tableSuppliersPushedCoupon(BRL.Locations.getListPushedCoupons ()), tLPPushedCoupons);
			tLPushedCoupons.SetBackgroundResource(Resource.Drawable.bg_Aopen_00_Splashscreen);
			scroll.AddView (tLPushedCoupons);
			SetContentView(scroll);

		}
	
		protected TableLayout tableImageText ()
		{
			
			TableLayout tLLoyaltySettings = new TableLayout(this);
			TableRow tRLoyaltySettings = new TableRow(this);
			TableRow.LayoutParams tRParametrosLS = new TableRow.LayoutParams(LinearLayout.LayoutParams.FillParent, 
			                                                                 LinearLayout.LayoutParams.WrapContent);
			tRParametrosLS.SetMargins(0, 5, 0, 5);
			
			ImageView iVLoyaltySettings = new ImageView(this);
			iVLoyaltySettings.SetPadding (20, 3, 20, 3);
			iVLoyaltySettings.SetImageResource (Resource.Drawable.loyalty_settings);
			iVLoyaltySettings.SetBackgroundResource(Resource.Drawable.gradientGreenBars1);
			
			TextView tVLoyaltySettings = new TextView (this);
			tVLoyaltySettings.SetBackgroundResource(Resource.Drawable.gradientGreenBars2);
			tVLoyaltySettings.Text = "Loyalty Settings";
			tVLoyaltySettings.SetPadding (5, 5, 0, 0);
			tVLoyaltySettings.SetHeight(25);
			
			tRLoyaltySettings.AddView (iVLoyaltySettings, tRParametrosLS);
			tRLoyaltySettings.AddView (tVLoyaltySettings, tRParametrosLS);
			
			tLLoyaltySettings.AddView(tRLoyaltySettings);
			tLLoyaltySettings.SetColumnStretchable (1, true);

			return tLLoyaltySettings;
		}
	
		protected TableLayout tableSuppliersPushedCoupon (List<DTO.Location> items)
		{			
			TableLayout tLArticulos = new TableLayout(this);

			foreach (var item in items) {
				
				TableRow trArticulo = new TableRow(this);
				
				TableRow.LayoutParams tRParametros = new TableRow.LayoutParams(LinearLayout.LayoutParams.FillParent, LinearLayout.LayoutParams.WrapContent);
				tRParametros.SetMargins(0, 5, 0, 0);
				
				TextView tVDistancia = new TextView (this);
				ImageView iVDireccion = new ImageView(this);
				TextView tVDescripcion = new TextView(this);
				
				
				tVDistancia.Text = UtilGeo.distancia(latitudInicial, longitudInicial, item.Latitude, item.Longitude)+" mi";
				tVDistancia.SetBackgroundResource(Resource.Drawable.gradient2);
				tVDistancia.SetWidth(50);
				tVDistancia.SetHeight(25);
				tVDistancia.SetPadding (5, 5, 0, 0);
				
				ToolGeo.pintarImagen ( iVDireccion, UtilGeo.direccion(latitudInicial, longitudInicial, item.Latitude, item.Longitude));
				
				iVDireccion.SetBackgroundResource(Resource.Drawable.gradient2);
				iVDireccion.SetPadding (0, 8, 5, 7);
				
				tVDescripcion.Text = item.Name;
				tVDescripcion.SetHeight(25);
				tVDescripcion.SetPadding (5, 5, 0, 0);
				tVDescripcion.SetBackgroundResource(Resource.Drawable.gradient);
				
				trArticulo.AddView (tVDistancia, tRParametros);
				trArticulo.AddView (iVDireccion, tRParametros);
				trArticulo.AddView (tVDescripcion, tRParametros);
				
				tLArticulos.AddView(trArticulo);
				tLArticulos.SetColumnStretchable (2, true);
			}

			return tLArticulos;
		}
	
	}
}

