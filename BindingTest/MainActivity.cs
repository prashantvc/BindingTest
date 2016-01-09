using Android.App;
using Android.Widget;
using Android.OS;

using Consumeapi;

namespace BindingTest
{
	[Activity (Label = "BindingTest", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{


		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				int value = ConsumeAPI.Function1();
				string stringValue = ConsumeAPI.Function11(); 

				System.Console.WriteLine ("Function1 - {0}, Function 11 - {1}", value, stringValue);
			};
		}
	}
}


