using IPA;
using IPALogger = IPA.Logging.Logger;

namespace DiMenus
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        [Init]
        public Plugin(IPALogger _)
        {

        }

        [OnEnable, OnDisable]
        public void OnState() { /* On State */ }
    }
}