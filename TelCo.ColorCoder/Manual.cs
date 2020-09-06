using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using static TelCo.ColorCoder.ColorList;
using static TelCo.ColorCoder.ColorPair;
using static TelCo.ColorCoder.NumberToColor;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    class ReferenceManual
    {
        public override string ToString() //overrides the ToString() in ColorLists
        {
            string colorCodeWithColors = "";
            for(int pairNo = 1; pairNo<= ColorMapMinor.Length*ColorMapMajor.Length; pairNo++)
            {
                ColorPair pair = NumberToColor.GetColorFromPairNumber(pairNo);
                colorCodeWithColors += "Pair Number : " + pairNo +  "   Colors : " + pair + "\n"; 

            }
            
             return colorCodeWithColors;
        }
    }
}
