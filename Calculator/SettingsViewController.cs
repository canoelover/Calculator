using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Calculator
{
	partial class SettingsViewController : UIViewController
	{
		public SettingsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			RefreshFields ();
		}

		partial void BackgroundSwitch_ValueChanged (UISwitch sender)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.SetBool (BackgroundSwitch.On, Constants.BACKGROUND);
			defaults.Synchronize();
		}

		partial void NumberSystemSwitch_ValueChanged (UISwitch sender)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.SetBool (NumberSystemSwitch.On, Constants.NUMBER_SYSTEM);
			defaults.Synchronize();
		}

		private void RefreshFields()
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			BackgroundSwitch.On = defaults.BoolForKey (Constants.BACKGROUND);
			NumberSystemSwitch.On = defaults.BoolForKey (Constants.NUMBER_SYSTEM);
			defaults.Synchronize();
		}

	}
}
