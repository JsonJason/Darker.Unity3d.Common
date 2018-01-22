using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class Spring : Singleton<Spring, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            time = Mathf.Clamp01(time);
            time =
                (Mathf.Sin(time * Mathf.PI * (0.2f + 2.5f * time * time * time)) * Mathf.Pow(1f - time, 2.2f) + time) *
                (1f + 1.2f * (1f - time));
            return start + (end - start) * time;
        }
    }
}