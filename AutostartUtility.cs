using Microsoft.Win32;

namespace PowerControl
{
    public class AutostartUility
    {
        private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
        /// <summary> 
        /// Sets the autostart value for the assembly. 
        /// </summary> 
        /// <param name="keyName">Registry Key Name</param> 
        /// <param name="assemblyLocation">Assembly location (e.g. Assembly.GetExecutingAssembly().Location)</param> 
        public static void SetAutoStart(string keyName, string assemblyLocation)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.SetValue(keyName, assemblyLocation);
        }
        /// <summary> 
        /// Returns null or currently registered assembly location if found. 
        /// </summary> 
        /// <param name="keyName">Registry Key Name</param> 
        public static string IsAutoStartEnabled(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
            if (key == null)
                return null;
            string value = (string)key.GetValue(keyName);
            return value;
        }
        /// <summary> 
        /// Unsets the autostart value for the assembly. 
        /// </summary> 
        /// <param name="keyName">Registry Key Name</param> 
        public static void UnSetAutoStart(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.DeleteValue(keyName);
        }
    }
}
