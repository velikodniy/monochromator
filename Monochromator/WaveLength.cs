using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monochromator.Properties;

namespace Monochromator
{
    public static class WaveLength
    {
        struct XYPair { public double Angle, WLength; }
        class XYPairWLComparer : IComparer<XYPair>
        {
            public int Compare(XYPair x, XYPair y)
            {
                return (int)(x.WLength - y.WLength);
            }
        }

        class XYPairAComparer : IComparer<XYPair>
        {
            public int Compare(XYPair x, XYPair y)
            {
                return (int)(x.Angle - y.Angle);
            }
        }

        static List<XYPair> wlengths = new List<XYPair>();

        static WaveLength()
        {
            string[] rows = Resources.wavelengths.Trim().Split('\n');
            XYPair xy;
            foreach(string row in rows)
            {
                var pair = row.Split('\t');
                xy.Angle = double.Parse(pair[0].Trim());
                xy.WLength = double.Parse(pair[1].Trim());
                wlengths.Add(xy);
            }
            wlengths.Sort((a, b) => (int)(a.Angle - b.Angle));
        }

        public static double ToDegrees(double wl)
        {
            if (wl < Min || wl > Max)
                throw new ArgumentException();
            var index = wlengths.BinarySearch(
                new XYPair { Angle = 0, WLength = wl },
                new XYPairWLComparer());

            if (index < 0) {
                // Линейная интерполяция
                var y0 = wlengths[~index - 1].Angle;
                var y1 = wlengths[~index].Angle;
                var x0 = wlengths[~index - 1].WLength;
                var x1 = wlengths[~index].WLength;

                return y0 + (y1 - y0) * (wl - x0) / (x1 - x0);
            }
            else
                return wlengths[index].Angle;
        }

        public static double FromDegrees(double a)
        {
            if (a < MinAngle || a > MaxAngle)
                throw new ArgumentException();
            var index = wlengths.BinarySearch(
                new XYPair { Angle = a, WLength = 0 },
                new XYPairAComparer());

            if (index < 0)
            {
                // Линейная интерполяция
                var y0 = wlengths[~index - 1].WLength;
                var y1 = wlengths[~index].WLength;
                var x0 = wlengths[~index - 1].Angle;
                var x1 = wlengths[~index].Angle;

                return y0 + (y1 - y0) * (a - x0) / (x1 - x0);
            }
            else
                return wlengths[index].WLength;
        }

        public static double Max
        {
            get { return wlengths[wlengths.Count - 1].WLength; }
        }

        public static double Min {
            get { return wlengths[0].WLength;  }
        }

        public static double MaxAngle
        {
            get { return wlengths[wlengths.Count - 1].Angle; }
        }

        public static double MinAngle
        {
            get { return wlengths[0].Angle; }
        }

    }
}
