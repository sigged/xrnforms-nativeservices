using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XrnCourse.NativeServices.Services;
using Android.Media;

[assembly: Dependency(typeof(XrnCourse.NativeServices.Droid.Services.PlatformSoundPlayer))]

namespace XrnCourse.NativeServices.Droid.Services
{
    public class PlatformSoundPlayer : ISoundPlayer
    {
        private MediaPlayer _mediaPlayer;

        public Task PlaySound()
        {
            _mediaPlayer = MediaPlayer
                .Create(global::Android.App.Application.Context, Resource.Raw.guitarm);
            _mediaPlayer.Start();
            return Task.Delay(0);
        }
    }
}