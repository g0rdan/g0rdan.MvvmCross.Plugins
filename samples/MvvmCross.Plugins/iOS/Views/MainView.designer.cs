// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace g0rdan.MvvmCross.Plugins.iOS
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SendEmailButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (SendEmailButton != null) {
				SendEmailButton.Dispose ();
				SendEmailButton = null;
			}
		}
	}
}
