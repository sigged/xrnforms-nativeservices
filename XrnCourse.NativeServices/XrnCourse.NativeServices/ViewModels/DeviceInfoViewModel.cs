using FreshMvvm;
using Xamarin.Forms;
using XrnCourse.NativeServices.Domain;
using XrnCourse.NativeServices.Services;

namespace XrnCourse.NativeServices.ViewModels
{
    public class DeviceInfoViewModel : FreshBasePageModel
    {

        public DeviceInfo DeviceInfo { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            IDeviceInfoService service = DependencyService.Get<IDeviceInfoService>();
            DeviceInfo = service.GetDeviceInfo();
        }

    }
}
