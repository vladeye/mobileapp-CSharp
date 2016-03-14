
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
using Android.Util;

namespace NMCAndroid
{
	[Activity (Label = "History")]			
	public class History : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.History);

			FindViewById<TableLayout>(Resource.Id.tableLayout3).AddView (tableHistory (BRL.ListHistory.getListHistory ()));

			ImageView iVFiltro = FindViewById<ImageView>(Resource.Id.iVFiltro);
			iVFiltro.Click += (object sender, EventArgs e) => {
				Toast.MakeText (this, "si funciona", ToastLength.Long).Show ();
			};

		}

		private TableLayout tableHistory (List<DTO.History> items)
		{		
			TableLayout tLHistory = new TableLayout(this);
			int contador = 0;
			foreach (var item in items) {				
				TableRow tRHistory = new TableRow(this);	

				tRHistory.Click += (object sender, EventArgs e) => {
					TableRow temporal = (TableRow)sender;
					TextView tVTemporal = (TextView)temporal.GetChildAt (0);
					Toast.MakeText (this, tVTemporal.Text, ToastLength.Long).Show ();
				};

				TableRow.LayoutParams tRParametros = new TableRow.LayoutParams(LinearLayout.LayoutParams.FillParent, 
				                                                               LinearLayout.LayoutParams.WrapContent);
				if((++contador%2) == 0)
					tRHistory.SetBackgroundColor (Android.Graphics.Color.White);

				tRParametros.SetMargins(0, 5, 0, 0);
				
				TextView tVDate = new TextView (this);
				TextView tVStore = new TextView(this);
				ImageView iVStatus = new ImageView(this);
				TextView tVAmount = new TextView(this);		
				TextView tVId = new TextView(this);

				tVId.SetWidth (0);
				tVId.SetHeight (0);
				tVId.Text = item.IdHistory;

				tVDate.Text = item.Date;
				tVDate.SetWidth (55);
				tVDate.SetHeight (25);
				tVDate.SetPadding (2, 4, 0, 0);
				tVDate.SetTextColor (Android.Graphics.Color.Black);

				tVStore.Text = item.Store;
				tVStore.TextSize = 12;
				tVStore.SetPadding (0, 4, 0, 0);
				tVStore.SetTextColor (Android.Graphics.Color.Blue);

				ToolGeo.pintarStatus ( iVStatus, item.Status);
				iVStatus.SetPadding (0, 4, 10, 0);

				tVAmount.Text = item.Amount+"";
				tVAmount.SetWidth (45);
				tVAmount.SetPadding (5, 4, 0, 0);
				tVAmount.SetTextColor (Android.Graphics.Color.Black);

				tRHistory.AddView (tVId);
				tRHistory.AddView (tVDate, tRParametros);
				tRHistory.AddView (tVStore, tRParametros);
				tRHistory.AddView (iVStatus, tRParametros);
				tRHistory.AddView (tVAmount, tRParametros);
				
				tLHistory.AddView(tRHistory);
				tLHistory.SetColumnStretchable (1, true);
			}
			
			return tLHistory;
		}
	}
}

