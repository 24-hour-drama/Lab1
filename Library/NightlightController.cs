using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class NightlightController
    {
        private NightlightState State { get; set; }
        int newBrightness;
        public void SetBrightness()
        {
            if (State.isOn == true && (newBrightness <= 100 && newBrightness >= 0))
            {
                State.Brightness = newBrightness;
            }
        }
    }
}
