﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using XLabs.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Telerik.XamarinForms.DataControlsRenderer.iOS;

//[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.DataControls.RadListView), typeof(Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer))]

namespace TelerikSample.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate //XFormsApplicationDelegate//global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new Telerik.XamarinForms.DataControlsRenderer.iOS.ListViewRenderer();            

            Forms.Init();
            LoadApplication(new App());
            
            return base.FinishedLaunching(app, options);
        }
    }
}
