using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorList;
using static TelCo.ColorCoder.ColorPair;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color to pair number.
    /// </summary>
    public class PairNumber
    {
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetMajorIndex(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorMapMajor.Length; i++)
            {
                if (ColorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;

        }
        public static int GetMinorIndex(ColorPair pair)
        {
            int minorIndex = -1;
            for (int i = 0; i < ColorMapMinor.Length; i++)
            {
                if (ColorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }
        public static int GetPairNumberFromColor(ColorPair pair)
    {           int majorIndex= GetMajorIndex(pair);
                int minorIndex= GetMinorIndex(pair);
            
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
