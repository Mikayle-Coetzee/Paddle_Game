using NAudio.CoreAudioApi;
using System;

namespace PROG7311_ICE_1_ST10023767.Classes
{
    public static class SystemVolumeControlClass
    {
        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Get the current system volume
        /// </summary>
        /// <returns></returns>
        public static int GetMasterVolume()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            }
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Set the system volume 
        /// </summary>
        /// <param name="volume"></param>
        public static void SetMasterVolume(int volume)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                device.AudioEndpointVolume.MasterVolumeLevelScalar = Math.Max(0, Math.Min(volume / 100.0f, 1.0f));
            }
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

