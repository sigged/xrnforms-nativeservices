using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;
using XrnCourse.NativeServices.Services;
using AVFoundation;

[assembly: Dependency(typeof(XrnCourse.NativeServices.iOS.Services.PlatformSoundPlayer))]

namespace XrnCourse.NativeServices.iOS.Services
{
    public class PlatformSoundPlayer : ISoundPlayer
    {
        private AVAudioPlayer backgroundMusic;

        public Task PlaySound()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.Ambient);
            session.SetActive(true);

            NSUrl soundUrl = new NSUrl("Sounds/guitar-m.mp3");
            NSError err;
            backgroundMusic = new AVAudioPlayer(soundUrl, "mp3", out err);
            backgroundMusic.Play();

            return Task.Delay(0);
        }
    }
}