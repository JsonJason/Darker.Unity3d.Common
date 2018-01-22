using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class ElasticInOut : Singleton<ElasticInOut, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            var d = 1f;
            var p = d * .3f;
            float s = 0;
            float a = 0;

            if (time == 0) return start;

            if ((time /= d * 0.5f) == 2) return start + end;

            if (a == 0f || a < Mathf.Abs(end))
            {
                a = end;
                s = p / 4;
            }
            else
            {
                s = p / (2 * Mathf.PI) * Mathf.Asin(end / a);
            }

            if (time < 1)
                return -0.5f * (a * Mathf.Pow(2, 10 * (time -= 1)) * Mathf.Sin((time * d - s) * (2 * Mathf.PI) / p)) +
                       start;
            return a * Mathf.Pow(2, -10 * (time -= 1)) * Mathf.Sin((time * d - s) * (2 * Mathf.PI) / p) * 0.5f + end +
                   start;
        }
    }
}