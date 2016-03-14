
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
	[Activity (Label = "HistoryDetail")]			
	public class HistoryDetail : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.HistoryDetail);

			TableLayout tLItemDetail = FindViewById<TableLayout>(Resource.Id.tLDetailItem);
			tLItemDetail.AddView (tableHistoryDetail (BRL.ListHistoryDetail.getListHistoryDetail()));
			tLItemDetail.SetBackgroundResource (Resource.Drawable.RoundShapeFront);
			//Intent temporal = new Intent(this, typeof(
			// Create your application here
		}
		
		private TableLayout tableHistoryDetail (List<DTO.HistoryDetail> items)
		{		
			TableLayout tLHistoryDetail = new TableLayout(this);
			int contador = 0;
			foreach (var item in items) {				
				TableRow tRHistoryDetail = new TableRow(this);					
				TableRow.LayoutParams tRParametros = new TableRow.LayoutParams(LinearLayout.LayoutParams.FillParent, 
				                                                               LinearLayout.LayoutParams.WrapContent);
				if((++contador%2) == 0)
					tRHistoryDetail.SetBackgroundColor (Android.Graphics.Color.White);
				
				tRParametros.SetMargins(0, 5, 0, 0);
				
				TextView tVIdHistory = new TextView(this);
				TextView tVCode = new TextView (this);
				TextView tVItem = new TextView(this);
				TextView tVItemDescription = new TextView(this);		
				TextView tVCantidad = new TextView(this);		
				TextView tVPrecio = new TextView(this);	
				LinearLayout lLItem = new LinearLayout(this);
				lLItem.Orientation = Orientation.Vertical;
				
				tVIdHistory.SetWidth (0);
				tVIdHistory.SetHeight (0);
				tVIdHistory.Text = item.IdHistory;
				
				tVCode.Text = item.CodItem;
				tVCode.SetWidth (60);
				tVCode.SetHeight (35);
				tVCode.SetPadding (2, 4, 0, 0);
				tVCode.SetTextColor (Android.Graphics.Color.Gray);
				
				tVItem.Text = item.Item;
				tVItem.TextSize = 12;
				tVItem.SetTextColor (Android.Graphics.Color.Blue);
				
				tVItemDescription.Text = item.DescriptionItem;
				tVItemDescription.SetWidth (120);
				tVItemDescription.TextSize = 12;
				tVItemDescription.SetTextColor (Android.Graphics.Color.Gray);

				tVCantidad.Text = item.Cant+"";
				tVCantidad.SetWidth (20);
				tVCantidad.SetHeight (35);
				tVCantidad.SetPadding (2, 4, 0, 0);
				tVCantidad.SetTextColor (Android.Graphics.Color.Gray);

				tVPrecio.Text = item.Valor+"";
				tVPrecio.SetWidth (60);
				tVPrecio.SetHeight (35);
				tVPrecio.SetPadding (2, 4, 0, 0);
				tVPrecio.SetTextColor (Android.Graphics.Color.Gray);
				
				tRHistoryDetail.AddView (tVIdHistory);
				tRHistoryDetail.AddView (tVCode, tRParametros);
				lLItem.AddView (tVItem);
				lLItem.AddView (tVItemDescription);
				tRHistoryDetail.AddView (lLItem, tRParametros);
				tRHistoryDetail.AddView (tVCantidad, tRParametros);
				tRHistoryDetail.AddView (tVPrecio, tRParametros);
				
				tLHistoryDetail.AddView(tRHistoryDetail);
				//tLHistoryDetail.SetColumnStretchable (1, true);
			}
			
			return tLHistoryDetail;
		}
	}
}

