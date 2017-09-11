using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XrnCourse.NativeServices.Services;
using Xamarin.Forms;
using XrnCourse.NativeServices.Domain;
using CoreMotion;
using CoreLocation;

[assembly: Dependency(typeof(XrnCourse.NativeServices.iOS.Services.IosDeviceInfoService))]

namespace XrnCourse.NativeServices.iOS.Services
{
    internal class IosDeviceInfoService : IDeviceInfoService
    {
        private UIDevice device;
        private CMMotionManager motionManager;
        private CLLocationManager locationManager;
        
        public IosDeviceInfoService()
        {
            device = new UIDevice();
            motionManager = new CMMotionManager();
            locationManager = new CLLocationManager();
        }

        public DeviceInfo GetDeviceInfo()
        {
            DeviceInfo info = new DeviceInfo
            {
                Manufacturer = "Apple",
                Model = device.Model,
                ReleaseVersion = device.SystemVersion,
                CanVibrate = true,
                Sensors = new List<string>()
            };

            if (motionManager.AccelerometerAvailable)
                info.Sensors.Add("Accelerometer");
            if (motionManager.GyroAvailable)
                info.Sensors.Add("Gyroscope");
            if (motionManager.MagnetometerAvailable)
                info.Sensors.Add("Magnetometer");

            return info;
        }
    }
}