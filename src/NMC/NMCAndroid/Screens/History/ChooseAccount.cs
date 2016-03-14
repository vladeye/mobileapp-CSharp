
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
	[Activity (Label = "ChooseAccount")]			
	public class ChooseAccount : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.choose_account, "All", typeof(ChooseAccount)));
			items.Add(new BaseItemList(Resource.Drawable.card_american_express, "American Express ****9274", typeof(ChooseAccount)));
			items.Add(new BaseItemList(Resource.Drawable.card_master_card, "Masterdcard ****3642", typeof(ChooseAccount)));
			items.Add(new BaseItemList(Resource.Drawable.card_visa, "Bank of America ****0021", typeof(ChooseAccount)));
			items.Add(new BaseItemList(Resource.Drawable.card_discover, "Wells Fargo ****6558", typeof(ChooseAccount)));
			
			this.ListAdapter = new ImageList_Adapter(this, items);
		}

		/*  Por ahora no tiene eventos relacionados a cada item.

		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var b = ((ImageList_Adapter)this.ListAdapter).GetBaseItemList (position);
			this.StartActivity(new Intent(this, b.ItemType));
		}*/
	}
}

