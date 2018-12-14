using System;

using UIKit;

namespace PassDataBack
{
    public partial class FirstViewController : UIViewController
    {
        public string Data 
        { 
            set 
            {
                ResultTextView.Text = value;
            } 
        }

        public FirstViewController(IntPtr handle) : base(handle)
        {
        }

        partial void FirstButton_TouchUpInside(UIButton sender)
        {
            if (Storyboard.InstantiateViewController(nameof(SecondViewController)) is SecondViewController next)
            {
                next.ParentVC = this;
                PresentViewController(next, true, null);
            }
        }
    }
}

