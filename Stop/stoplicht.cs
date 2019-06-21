using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class stoplicht
    {
        private static string color;

        private enum Colours
        {
            Red,
            Orange,
            Green
        }

        public stoplicht()
        {
            color = Colours.Orange.ToString();
        }

        public void NextState()
        {
            switch (color)
            {
                case "Red":
                    color = Colours.Green.ToString();
                    break;
                case "Green":
                    color = Colours.Orange.ToString();
                    break;
                case "Orange":
                    color = Colours.Red.ToString();
                    break;
            }
        }

        public string GetCurrentColor()
        {
            return color;
        }
    }
}
