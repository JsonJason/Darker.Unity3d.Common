using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class InOutCirc : Singleton<InOutCirc, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            time /= .5f;
            end -= start;
            if (time < 1) return -end * 0.5f * (Mathf.Sqrt(1 - time * time) - 1) + start;
            time -= 2;
            return end * 0.5f * (Mathf.Sqrt(1 - time * time) + 1) + start;
        }
    }
}