using FreshMvvm;
using XrnCourse.NativeServices.Domain;

namespace XrnCourse.NativeServices.ViewModels
{
    public class DeviceInfoViewModel : FreshBasePageModel
    {

        public DeviceInfo DeviceInfo { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            DeviceInfo = new DeviceInfo();
        }

    }
}
