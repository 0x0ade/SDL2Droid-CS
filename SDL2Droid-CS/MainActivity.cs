using Android.App;
using Android.Widget;
using Android.OS;
using Org.Libsdl.App;

namespace SDL2Droid_CS {
    [Activity(
        Label = "SDL2Droid CS",
        MainLauncher = true,
        Icon = "@drawable/icon",
        HardwareAccelerated = true
        // ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape
    )]
    public class MainActivity : SDLActivity {

        public override void LoadLibraries() {
            base.LoadLibraries();
            Bootstrap.SetupMain();
        }

    }
}

