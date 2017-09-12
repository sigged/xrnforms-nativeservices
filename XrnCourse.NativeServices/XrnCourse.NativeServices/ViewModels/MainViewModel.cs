using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XrnCourse.NativeServices.Services;

namespace XrnCourse.NativeServices.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
        private ISoundPlayer soundPlayer;

        public ICommand OpenDeviceInfoPageCommand { get; private set; }
        public ICommand PlaySoundCommand { get; private set; }

        public MainViewModel(ISoundPlayer soundplayer)
        {
            soundPlayer = soundplayer;
            OpenDeviceInfoPageCommand = new Command(OpenDeviceInfoPage);
            PlaySoundCommand = new Command(PlaySound);
        }

        private async void OpenDeviceInfoPage()
        {
            await CoreMethods.PushPageModel<DeviceInfoViewModel>(true);
        }


        private async void PlaySound()
        {
            await soundPlayer.PlaySound();
        }
    }
}
