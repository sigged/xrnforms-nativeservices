using FreshMvvm;
using Xamarin.Forms;
using XrnCourse.NativeServices.Domain;
using XrnCourse.NativeServices.Services;

namespace XrnCourse.NativeServices.ViewModels
{
    public class DeviceInfoViewModel : FreshBasePageModel
    {
        private IDeviceInfoService service;

        public DeviceInfoViewModel(IDeviceInfoService deviceInfoService)
        {
            service = deviceInfoService;
        }

        public DeviceInfo DeviceInfo { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            DeviceInfo = service.GetDeviceInfo();
        }

    }
}
