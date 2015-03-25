using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CustomCellTableview.iOS
{
	partial class CustomCell : UITableViewCell
	{
		public CustomCell (IntPtr handle) : base (handle)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
		}
		public void UpdateCell (string name, UIImage image)
		{
			img_profile.Image = image;
			lbl_name.Text = name;
		}
	}
}
