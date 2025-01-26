using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using PROG7311_ICE_1_ST10023767.Classes;

namespace PROG7311_ICE_1_ST10023767
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Get the current system volume
            int currentVolume = SystemVolumeControlClass.GetMasterVolume();
            Console.WriteLine($"Current System Volume: {currentVolume}%");

            // Setting the system volume
            SystemVolumeControlClass.SetMasterVolume(70);

            Application.Run(new FrmHome());
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

