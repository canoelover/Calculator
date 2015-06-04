using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Calculator
{
	public partial class CalculatorViewController : UIViewController
	{
		NSObject observer = null;
		private string _fontSize = null;
		private string _displayPrecision = null;
		private string _displayMode = null;
		private bool _background = true;
		private bool _numberSystem = false;

		public CalculatorViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			var c = new Calculate();
			 
			ClearButton.TouchUpInside += (object sender, EventArgs e) => {
				c.Expression = "";
				c.RunningBal = 0;
				c.HoldValue = "";
				ExpressionLabel.Text = "";
			};

			DivButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression ("/", true);
				ExpressionLabel.Text = c.Expression;
			};

			MultButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("X", true);
				ExpressionLabel.Text = c.Expression;
			};
				
			SubButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("-", true);
				ExpressionLabel.Text = c.Expression;
			};

			AddButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("+", true);
				ExpressionLabel.Text = c.Expression;
			};

			EqualButton.TouchUpInside += (object sender, EventArgs e) => {	
				c.BuildExpression("=", true);
//				ExpressionLabel.Text = c.RunningBal.ToString();
				if (_numberSystem == true) {
//					int decValue = Convert.ToInt32(c.RunningBal.ToString(), 16);
					ExpressionLabel.Text = c.RunningBal.ToString();
				} else {
					int runningBal = (int)c.RunningBal;
					string hexValue = runningBal.ToString("X");
					ExpressionLabel.Text = hexValue;
				}
					
				c.Expression = c.RunningBal.ToString();


			};

			ZeroButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("0", false);
				ExpressionLabel.Text = c.Expression;
			};

			OneButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression ("1", false);
				ExpressionLabel.Text = c.Expression;
			};

			TwoButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("2", false);
				ExpressionLabel.Text = c.Expression;
			};

			ThreeButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("3", false);
				ExpressionLabel.Text = c.Expression;
			};

			FourButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("4", false);
				ExpressionLabel.Text = c.Expression;
			};

			FiveButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("5", false);
				ExpressionLabel.Text = c.Expression;
			};
				
			SixButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("6", false);
				ExpressionLabel.Text = c.Expression;
			};

			SevenButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("7", false);
				ExpressionLabel.Text = c.Expression;
			};

			EightButton.TouchUpInside += (object sender, EventArgs e) => {	
				c.BuildExpression("8", false);
				ExpressionLabel.Text = c.Expression;
			};

			NineButton.TouchUpInside += (object sender, EventArgs e) => {
				c.BuildExpression("9", false);
				ExpressionLabel.Text = c.Expression;
			};				

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			// Update the values shown in view 1 from the StandardUserDefaults
			RefreshFields ();

			// Subscribe to the applicationWillEnterForeground notification
			var app = UIApplication.SharedApplication;
			// NSNotificationCenter.DefaultCenter.AddObserver (this, UIApplication.WillEnterForegroundNotification, "ApplicationWillEnterForeground", app);
			// NSNotificationCenter.DefaultCenter.AddObserver (UIApplication.WillEnterForegroundNotification, ApplicationWillEnterForeground);
			observer = NSNotificationCenter.DefaultCenter.AddObserver (aName: UIApplication.WillEnterForegroundNotification, notify: ApplicationWillEnterForeground, fromObject: app);

		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		private void RefreshFields()
		{
			var defaults = NSUserDefaults.StandardUserDefaults;

			_fontSize = defaults.StringForKey (Constants.FONT_SIZE);
			_displayPrecision = defaults.StringForKey (Constants.DISPLAY_PRECISION);
			_displayMode = defaults.StringForKey (Constants.DISPLAY_MODE);
			_background = defaults.BoolForKey (Constants.BACKGROUND);
			_numberSystem = defaults.BoolForKey (Constants.NUMBER_SYSTEM);

			if (_background == true)
				CalculatorView.BackgroundColor = UIColor.Blue;
			else
				CalculatorView.BackgroundColor = UIColor.White;
				
			
		}


		// We will subscribe to the applicationWillEnterForeground notification
		// so that this method is called when that notification occurs
		private void ApplicationWillEnterForeground(NSNotification notification)
		{
			var defaults = NSUserDefaults.StandardUserDefaults;
			defaults.Synchronize();
			RefreshFields();			
		}


		#endregion
	}
}

