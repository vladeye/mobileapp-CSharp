
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
	[Activity (Label = "Splash", MainLauncher = true, NoHistory = true)]			
	public class Splash : BaseActivity
	{
		// the app spares 5 seconds
		int waitingTime = 5000;

		// every 100 miliseconds the app update the progressbar
		int updateFrequency = 100;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set the number of steps to fill the progress bar
			SetContentView (Resource.Layout.Splash);
			var pgbLoad = FindViewById<ProgressBar> (Resource.Id.pgbLoad);
			int steps = waitingTime/updateFrequency;
			pgbLoad.Max = steps;
			pgbLoad.Progress = 0;

			// setup the timer used to fill the progress bar
			System.Timers.Timer tmrProgress = new System.Timers.Timer(updateFrequency);
			tmrProgress.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => {
				tmrProgress.Stop();
				if (pgbLoad.Progress < pgbLoad.Max) {
					pgbLoad.Progress++;
					tmrProgress.Start();
				}
				else {
					//History, Prueba, ShoppingAssistant, Settings, History, PushedCoupon
					StartActivity (typeof(HistoryDetail));
				}
			};
			tmrProgress.Start();
		}
	}
}