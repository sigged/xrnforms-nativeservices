using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XrnCourse.NativeServices.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {


        public ICommand OpenDeviceInfoPageCommand { get; private set; }

        public MainViewModel()
        {
            OpenDeviceInfoPageCommand = new Command(OpenDeviceInfoPage);
        }

        private async void OpenDeviceInfoPage()
        {
            await CoreMethods.PushPageModel<DeviceInfoViewModel>(true);
        }
    }
}
