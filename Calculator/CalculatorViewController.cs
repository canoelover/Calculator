using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Calculator
{
	public partial class CalculatorViewController : UIViewController
	{
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
				ExpressionLabel.Text = c.RunningBal.ToString();
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

		#endregion
	}
}

