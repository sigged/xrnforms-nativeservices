using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrnCourse.NativeServices.Domain
{
    public class DeviceInfo
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string ReleaseVersion { get; set; }
        public bool CanVibrate { get; set; }
        public List<string> Sensors { get; set; }
    }
}
