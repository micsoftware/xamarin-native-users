using System;
using UIKit;

namespace AppExercise.iOS.Theme
{
    public static class Colors
    {
        private static Lazy<UIColor> strongBlue = new Lazy<UIColor>(() => UIColor.FromRGB(0, 64, 117));
        public static UIColor StrongBlue
        {
            get { return strongBlue.Value; }
        }
    }
}
