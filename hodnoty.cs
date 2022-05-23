using System.Threading;
using System.Windows.Forms;

namespace NIM_v1._0
{
    class hodnoty
    {
        public static int sirky = 0;
        public static bool Easy = false;
        public static bool Medium = false;
        public static bool Hard = false;
        public static void Wait(int time)
        {
            Thread thread = new Thread(delegate ()
            {
                Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }
    }
}
