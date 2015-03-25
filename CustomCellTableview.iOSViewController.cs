using System;
using System.Drawing;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace CustomCellTableview.iOS
{
	public partial class CustomCellTableview_iOSViewController : UIViewController
	{
		public CustomCellTableview_iOSViewController (IntPtr handle) : base (handle)
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

			List<string> tableData = new List<string>();

			tableData.Add ("Vegetables");
			tableData.Add ("Fruits");
			tableData.Add ("Flower Buds");
			tableData.Add ("Legumes");
			tableData.Add ("Bulbs");
			tableData.Add ("Tubers");



			//string[] itemData = new string[] {"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};
			tableView.Source = new TableSource (tableData);

			// Perform any additional setup after loading the view, typically from a nib.
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

