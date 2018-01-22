using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class InOutExpo : Singleton<InOutExpo, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            time /= .5f;
            end -= start;
            if (time < 1) return end * 0.5f * Mathf.Pow(2, 10 * (time - 1)) + start;
            time--;
            return end * 0.5f * (-Mathf.Pow(2, -10 * time) + 2) + start;
        }
    }
}