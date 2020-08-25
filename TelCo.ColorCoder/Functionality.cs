using System;
namespace TelCo.ColorCoder
{
  class Functionality
    {
      private static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair() { majorColor = colorMapMajor[majorIndex],
                minorColor = colorMapMinor[minorIndex] };
          
            return pair;
        }
      private static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i; break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
    }
}
