using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace test.Droid
{
    [Activity(Label = "test", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //LoadApplication(new App());
            LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(
    this,
    new UXDivers.Gorilla.Config("Good Gorilla")
      // Register Grial Shared assembly
      .RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()
      // Register UXDivers Effects assembly
      .RegisterAssembly(typeof(UXDivers.Effects.Effects).Assembly)
      // FFImageLoading.Transformations
     // .RegisterAssemblyFromType<FFImageLoading.Transformations.BlurredTransformation>()
      // FFImageLoading.Forms
   //   .RegisterAssemblyFromType<FFImageLoading.Forms.CachedImage>()
    ));
        }
    }
}

