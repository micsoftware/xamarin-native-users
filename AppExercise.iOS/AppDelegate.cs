using AppExercise.Core;
using AppExercise.Core.Interface;
using AppExercise.Services.Todo;
using AppExercise.Services.Users;
using Foundation;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace AppExercise.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            Mvx.IoCProvider.RegisterSingleton<IUserService>(new UserService());

            return result;
        }
    }
}

