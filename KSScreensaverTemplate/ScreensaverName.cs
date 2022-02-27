
// The KS.Misc.Screensaver import is necessary for mod routine to work. You can specify ICustomSaver explicitly, but it may reduce the readability of your
// screensaver code.

using KS.Misc.Screensaver;
using System.Collections.Generic;

namespace KSScreensaverTemplate
{
    // Change the ScreensaverName class to your screensaver name
    public class ScreensaverName : ICustomSaver
    {
        public bool Initialized { get; set; }
        public int DelayForEachWrite { get; set; }
        public string SaverName { get; set; }
        public Dictionary<string, object> SaverSettings { get; set; }

        public void InitSaver()
        {
            // Statements written here will be executed when the screensaver gets initialized. They start up either by starting up the kernel or manually
            // starting it.
            //
            // Put your initialization statements here. You can also place your screensaver settings using the SaverSettings property.
        }

        public void PostDisplay()
        {
            // Statements to execute after the screensaver ends by pressing any key.
            //
            // Put your decommission statements here.
        }

        public void PreDisplay()
        {
            // Statements to execute before the screensaver starts.
        }

        public void ScrnSaver()
        {
            // All of the drawing statements must be done here. These statements are executed inside the loop of the custom screensaver.
        }
    }
}

// Refer to https://eoflaoe.github.io/Kernel-Simulator for up-to-date API documentation for screensaver developers.
