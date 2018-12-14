using Foundation;
using System;
using UIKit;

namespace PassDataBack
{
    public partial class SecondViewController : UIViewController
    {
        public UIViewController ParentVC;

        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


        }

        partial void SendBackButton_TouchUpInside(UIButton sender)
        {
            (ParentVC as FirstViewController).Data = TextToSend.Text;
            DismissViewController(true, null);
        }
    }
}