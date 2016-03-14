
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
	/// <summary>
	/// Representa el ancestro para los listItems.
	/// </summary>
	public class BaseItemList
	{
		/// <summary>
		/// Gets or sets the identifier image.
		/// </summary>
		/// <value>
		/// The identifier image.
		/// </value>
		public int IdImage { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>
		/// The text.
		/// </value>
		public String Text { get; set; }

		/// <summary>
		/// Gets or sets the type of the item.
		/// </summary>
		/// <value>
		/// The type of the item.
		/// </value>
		public Type ItemType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NMCAndroid.BaseItemList"/> class.
		/// </summary>
		/// <param name='idImage'>
		/// Identifier image.
		/// </param>
		/// <param name='text'>
		/// Text.
		/// </param>
		/// <param name='itemType'>
		/// Item type.
		/// </param>
		public BaseItemList (int idImage, string text, Type itemType)
		{
			this.IdImage = idImage;
			this.Text = text;
			this.ItemType = itemType;
		}
	}
}

