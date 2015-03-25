using System;
using UIKit;
using System.Collections.Generic;
namespace CustomCellTableview.iOS
{
	public class TableSource : UITableViewSource
	{
	


		List<string> tableItems = new List<string>();
		string cellIdentifier="TableCell";


		public TableSource ( List<string> items)
		{
			tableItems = items;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Count;
		}
		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (cellIdentifier) as CustomCell;
			cell.UpdateCell(tableItems[indexPath.Row]
				, UIImage.FromFile ("Images/ic_facebook.png") );
			return cell;

		}
		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			new UIAlertView("Row Selected", tableItems[indexPath.Row], null, "OK", null).Show();
		
			tableView.DeselectRow (indexPath, true); // iOS convention is to remove the highlight
		}

		public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
		{
			switch (editingStyle) {
			case UITableViewCellEditingStyle.Delete:
				// remove the item from the underlying data source
				tableItems.RemoveAt(indexPath.Row);
				// delete the row from the table
				tableView.DeleteRows (new Foundation.NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
				break;
			case UITableViewCellEditingStyle.None:
				Console.WriteLine ("CommitEditingStyle:None called");
				break;
			}
		}

	}
}

