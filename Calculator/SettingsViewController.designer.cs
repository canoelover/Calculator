// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Calculator
{
	[Register ("SettingsViewController")]
	partial class SettingsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch BackgroundSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch NumberSystemSwitch { get; set; }

		[Action ("BackgroundSwitch_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BackgroundSwitch_ValueChanged (UISwitch sender);

		[Action ("NumberSystemSwitch_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void NumberSystemSwitch_ValueChanged (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (BackgroundSwitch != null) {
				BackgroundSwitch.Dispose ();
				BackgroundSwitch = null;
			}
			if (NumberSystemSwitch != null) {
				NumberSystemSwitch.Dispose ();
				NumberSystemSwitch = null;
			}
		}
	}
}
