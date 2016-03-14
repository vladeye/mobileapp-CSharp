
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
	[Activity (Label = "Settings")]			
	public class Settings : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var items = new List<BaseItemList>();
			items.Add(new BaseItemList(Resource.Drawable.loyalty_settings, "Loyalty Settings", typeof(PusNotification)));
			items.Add(new BaseItemList(Resource.Drawable.language, "Language", typeof(Language)));
			items.Add(new BaseItemList(Resource.Drawable.scan_time_out, "Scan Timeout", typeof(ScannTimeout)));
			items.Add(new BaseItemList(Resource.Drawable.cards, "Cards", typeof(Cards)));
			items.Add(new BaseItemList(Resource.Drawable.user_info, "User Info", typeof(UserInfo)));
			items.Add(new BaseItemList(Resource.Drawable.addresses, "Addresses", typeof(Addresses)));
			items.Add(new BaseItemList(Resource.Drawable.about, "About", typeof(About)));
			items.Add(new BaseItemList(Resource.Drawable.terms, "Terms", typeof(Terms)));
			items.Add(new BaseItemList(Resource.Drawable.contact_us, "ContactUs", typeof(ContactUs)));
			items.Add(new BaseItemList(Resource.Drawable.report_abuse, "Report Abuse", typeof(ReportAbuse)));
			
			this.ListAdapter = new ImageList_Adapter(this, items);
		}
	
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var b = ((ImageList_Adapter)this.ListAdapter).GetBaseItemList (position);
			this.StartActivity(new Intent(this, b.ItemType));
		}
	}
}