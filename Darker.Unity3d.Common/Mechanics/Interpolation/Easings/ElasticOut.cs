using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class ElasticOut : Singleton<ElasticOut, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;

            var d = 1f;
            var p = d * .3f;
            float s = 0;
            float a = 0;

            if (time == 0) return start;

            if ((time /= d) == 1) return start + end;

            if (a == 0f || a < Mathf.Abs(end))
            {
                a = end;
                s = p * 0.25f;
            }
            else
            {
                s = p / (2 * Mathf.PI) * Mathf.Asin(end / a);
            }

            return a * Mathf.Pow(2, -10 * time) * Mathf.Sin((time * d - s) * (2 * Mathf.PI) / p) + end + start;
        }
    }
}