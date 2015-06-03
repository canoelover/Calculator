using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace Calculator
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		
		public override UIWindow Window {
			get;
			set;
		}


		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method


			// Set default settings for this app, but only the first time it's run
			var defaultsDictionary = new NSMutableDictionary();
			defaultsDictionary.SetValueForKey ((NSString)"Fixed Point", (NSString)Constants.DISPLAY_MODE);
			defaultsDictionary.SetValueForKey ((NSNumber)1, (NSString)Constants.BACKGROUND);
			defaultsDictionary.SetValueForKey ((NSString)"15", (NSString)Constants.FONT_SIZE);
			defaultsDictionary.SetValueForKey ((NSString)"0", (NSString)Constants.DISPLAY_PRECISION);
			defaultsDictionary.SetValueForKey ((NSNumber)0, (NSString)Constants.NUMBER_SYSTEM);

			NSUserDefaults.StandardUserDefaults.RegisterDefaults (defaultsDictionary);

			return true;
		}

		
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}
	}
}

