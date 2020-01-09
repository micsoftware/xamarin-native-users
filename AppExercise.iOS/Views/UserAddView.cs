using System;
using AppExercise.Core.ViewModels;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace AppExercise.iOS.Views
{
    [Register(nameof(UserAddView))]
    [MvxChildPresentation(Animated = true)]
    public class UserAddView : MvxViewController<CreateUserViewModel>
    { 
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }
    }
}
