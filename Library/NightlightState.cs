using System.Drawing;

namespace Library
{
    public class NightlightState
    {
        public bool isOn;
        public int Brightness;
        public Color currentColor; // если буде делать цветным
        public int SensorLight; // если будем делать сеенсор освещения вокруг
        public string currentMod;
    }
}
