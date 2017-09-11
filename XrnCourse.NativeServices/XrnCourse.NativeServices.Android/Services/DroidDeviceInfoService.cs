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
using Xamarin.Forms;
using XrnCourse.NativeServices.Droid.Services;
using XrnCourse.NativeServices.Services;
using XrnCourse.NativeServices.Domain;
using Android.Hardware;

[assembly: Dependency(typeof(XrnCourse.NativeServices.Droid.Services.DroidDeviceInfoService))]

namespace XrnCourse.NativeServices.Droid.Services
{
    internal class DroidDeviceInfoService : IDeviceInfoService
    {
        public DeviceInfo GetDeviceInfo()
        {
            DeviceInfo info = new DeviceInfo {
                Manufacturer = Build.Manufacturer,
                Model = Build.Model,
                ReleaseVersion = Build.VERSION.Release + Build.VERSION.Incremental,
                CanVibrate = false,
                Sensors = new List<string>()
            };

            using (var vib =
                (Vibrator)Android.App.Application.Context.GetSystemService(Context.VibratorService))
            {
                info.CanVibrate = vib.HasVibrator;
            }
                

            using (var sensormgr =
                (SensorManager)Android.App.Application.Context.GetSystemService(Context.SensorService))
            {
                foreach (var sensor in sensormgr.GetSensorList(Android.Hardware.SensorType.All))
                {
                    info.Sensors.Add(sensor.Name);
                }
            }
            return info;
        }
    }
}
