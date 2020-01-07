using System;
using AppExercise.Core.ViewModels;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
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
            View.BackgroundColor = UIColor.Green;

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            base.ViewDidLoad();
        }
    }
}
