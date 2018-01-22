using System;
using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class CLearp : Singleton<CLearp, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            var min = 0.0f;
            var max = 360.0f;
            var half = Math.Abs((max - min) * 0.5f);
            float retval;
            float diff;
            if (end - start < -half)
            {
                diff = (max - start + end) * time;
                retval = start + diff;
            }
            else if (end - start > half)
            {
                diff = -(max - end + start) * time;
                retval = start + diff;
            }
            else
            {
                retval = start + (end - start) * time;
            }
            return retval;
        }
    }
}