
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
	[Activity (Label = "Cards")]			
	public class Cards : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.card_american_express, "American Express ****9274", typeof(InfoCard)));
			items.Add(new BaseItemList(Resource.Drawable.card_master_card, "Masterdcard ****3642", typeof(InfoCard)));
			items.Add(new BaseItemList(Resource.Drawable.card_visa, "Bank of America ****0021", typeof(InfoCard)));
			items.Add(new BaseItemList(Resource.Drawable.card_discover, "Wells Fargo ****6558", typeof(InfoCard)));
			items.Add(new BaseItemList(Resource.Drawable.Cvacia, "Add New Card ...", typeof(Cards)));
			
			this.ListAdapter = new ImageList_Adapter(this, items);
		}
		
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var b = ((ImageList_Adapter)this.ListAdapter).GetBaseItemList (position);
			this.StartActivity(new Intent(this, b.ItemType));
		}
	}
}

