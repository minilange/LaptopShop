using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Keyboard
    {
        public int KeyboardId { get; set; }
        public bool Numpad { get; set; }
        public bool Backlight { get; set; } 
        public string Language { get; set; } 
        public string Layout { get; set; } 

    }
}
