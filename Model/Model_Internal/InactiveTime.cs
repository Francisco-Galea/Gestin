using System.Runtime.InteropServices;

namespace Gestin.Model.Model_Internal
{
    internal class InactiveTime
    {
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        public static int inactiveTime { get; set; } = 1200000; //20 minutos
        public static uint getIdleTime()
        {
            LASTINPUTINFO lastUserAction = new LASTINPUTINFO();
            lastUserAction.cbSize = (uint)Marshal.SizeOf(lastUserAction);

            if (GetLastInputInfo(ref lastUserAction))
            {
                return (uint)Environment.TickCount - lastUserAction.dwTime;
            }
            else
            {
                return 0;
            }
        }

        public struct LASTINPUTINFO
        {
            public uint cbSize { get; set; }
            public uint dwTime { get; set; }
        }

        public static DateTime maxTimeLoggedIn(DateTime dateTime)
        {
            return dateTime.AddHours(2);
        }
    }
}
