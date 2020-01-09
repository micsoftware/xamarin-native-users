using System;
using AppExercise.Core.ViewModels;
using AppExercise.iOS.Theme;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AppExercise.iOS.Views
{
    [Register(nameof(UsersView))]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class UsersView : MvxTableViewController<UserListViewModel>
    {
        public override void ViewDidLoad()
        {
            View.BackgroundColor = UIColor.White;
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            NavigationController.NavigationBar.BarTintColor = Colors.StrongBlue;
            NavigationItem.TitleView = new UILabel
            {
                Text = "Exercise",
                TextColor = UIColor.White,
                Font = UIFont.BoldSystemFontOfSize(17)
            };

            NavigationItem.RightBarButtonItem = new UIBarButtonItem
            {
                Image = new UIImage("icon_add"),

            };
            var set = this.CreateBindingSet<UsersView, UserListViewModel>();
            NavigationItem.RightBarButtonItem.Clicked += CreateUserEventHandler;
        }

        private void CreateUserEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Create User Event Handler");
            ViewModel.CreateNewCommand.Execute(); 
        }

        //public class UsersTableSource : MvxTableViewSource
        //{
        //    private static readonly NSString UserCellIdentifier = new NSString("UserCell");
        //    public UsersTableSource(UITableView tableView) : base(tableView)
        //    {
        //        tableView.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
        //        tableView.RegisterNibForCellReuse(UINib.FromName("UserCell", NSBundle.MainBundle), UserCellIdentifier);
        //    }

        //    protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        //    {

        //        throw new System.NotImplementedException();
        //    }
        //}
    }
}
