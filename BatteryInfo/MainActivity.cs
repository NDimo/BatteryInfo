using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace BatteryInfo
{
    [Activity(Label = "Battery Info", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
            AndroidBattery battery = new AndroidBattery();

            TextView tLevel = FindViewById<TextView>(Resource.Id.Level);
            TextView tStatus = FindViewById<TextView>(Resource.Id.Status);
            TextView tHealth = FindViewById<TextView>(Resource.Id.Health);
            TextView tTemperature = FindViewById<TextView>(Resource.Id.Temperature);
            TextView tTechnology = FindViewById<TextView>(Resource.Id.Technology);

            tLevel.Text = String.Format("Level: {0}%", battery.Level);
            tStatus.Text = String.Format("Status: {0}", battery.Status);
            tHealth.Text = String.Format("Health: {0}", battery.Health);
            tTemperature.Text = String.Format("Temperature: {0}C", battery.Temperature / 10);
            tTechnology.Text = String.Format("Technology: {0}", battery.Technology);
        }
    }
}