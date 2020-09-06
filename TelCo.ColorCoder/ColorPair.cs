using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorList;



namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the mapping of pair number to color 
    /// </summary>
    public class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        
                    public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }

       
    }
}
