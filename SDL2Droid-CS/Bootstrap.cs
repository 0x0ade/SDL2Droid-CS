using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System.Runtime.InteropServices;

namespace SDL2Droid_CS {
    delegate void Main();
    static class Bootstrap {

        public static void Main() {

            // Insert your main loop code here

        }

        public static void SetupMain() {
            // Give the main library something to call in Mono-Land afterwards
            SetMain(Main);

            // Insert your own post-lib-load, pre-SDL2 code here.
        }

        [DllImport("main")]
        static extern void SetMain(Main main);

    }
}