
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
using Android.Graphics;

namespace NMCAndroid
{
	/// <summary>
	/// Class to display an array of items, each item includes an image and a text.
	/// </summary>
	public class StringList_Adapter : ArrayAdapter <String> {
		Activity context;

		IList<String> _items;

		/// <summary>
		/// Initializes a new instance of the <see cref="NMCAndroid.ImageList_Adapter"/> class.
		/// </summary>
		/// <param name='context'>
		/// Context.
		/// </param>
		/// <param name='objects'>
		/// Items to render.
		/// </param>
		public StringList_Adapter(Activity context, IList<String> items)
			: base(context, Android.Resource.Id.Text1, items)
		{
			this.context = context;
			_items = items;
		}
		
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = context.LayoutInflater.Inflate(Android.Resource.Layout.ActivityListItem, null);
			var item = GetItem(position);

			view.SetBackgroundColor(Color.Blue);

			view.FindViewById<TextView> (Android.Resource.Id.Text1).Text = item;
			view.SetBackgroundResource(Resource.Drawable.gradient);
			parent.SetBackgroundResource(Resource.Drawable.bg_Aopen_00_Splashscreen);

			
			return view;
		}

		public String GetString (int position) {
			return _items[position];
		}
		
		public override int ViewTypeCount {
			get {
				return _items.Count;
			}
		}

		public override int GetItemViewType(int position)
		{
			return 0;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override int Count
		{
			get { return _items.Count; }
		}

		public override bool AreAllItemsEnabled()
		{
			return true;
		}

		public override bool IsEnabled(int position)
		{
			return true;
		}
	}
}

