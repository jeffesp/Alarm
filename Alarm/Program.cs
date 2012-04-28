using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Alarm
{
    class Program
    {
        private static string usage = @"Alarm.exe [mintues before ringing] [message when ringing] [number of times to ring] [path to soundfile]";

        static void Main(string[] args)
        {
            string soundFile = @"c:\Windows\Media\notify.wav";
            string message = "Time to make the donuts.";
            int minutes = 0;
            int count = 3;

            if (args.Length == 0)
                Console.WriteLine(usage);

            if (args.Length > 3 && File.Exists(args[3]))
                soundFile = args[3];

            if (args.Length > 2)
                Int32.TryParse(args[2], out count);

            if (args.Length > 1)
                message = args[1];

            if (args.Length > 0 && Int32.TryParse(args[0], out minutes))
                Thread.Sleep(minutes * 60 * 1000);

            ThreadPool.QueueUserWorkItem((state) =>
                {
                    using (SoundPlayer simpleSound = new SoundPlayer(soundFile))
                    {
                        for (int i = 0; i < count; i++)
                            simpleSound.PlaySync();
                    }

                });

            new Alert(message).ShowDialog();
        }
    }
}
