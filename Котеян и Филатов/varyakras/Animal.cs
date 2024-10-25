using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varyakras
{
    internal class Animal
    {
        public string color = "white";
        public string voice = "meow-meow";
        public bool tail = true;
        public string name = "Princess";
        public string sex = "woman";

        public string GetVoice() {
            return voice;
        }
    }

}
