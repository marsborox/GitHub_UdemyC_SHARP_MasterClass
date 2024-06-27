using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4_some_other_stuff
{
    internal class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }
        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoUrl, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            //these are member of VideoPost not Post
            this.VideoUrl = videoUrl;
            this.Length = length;
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop() 
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("stopped at{0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} by - {3}", this.ID, this.Title, this.VideoUrl, this.SendByUsername);

        }
    }
}
