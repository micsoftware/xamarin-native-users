using AppExercise.Core.ViewModels;
using AppExercise.iOS.Theme;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace AppExercise.iOS.Views
{
    [Register(nameof(UsersView))]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class UsersView : MvxViewController<UserListViewModel>
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

            var HeaderView = new UIView
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                
            };

            var LabelTitle = new UILabel()
            {
                Text = "Exercise",
                TextAlignment = UITextAlignment.Center,
                TextColor = UIColor.White,
                AdjustsFontSizeToFitWidth = true,
                TranslatesAutoresizingMaskIntoConstraints = false
            };
        }
    }
}
