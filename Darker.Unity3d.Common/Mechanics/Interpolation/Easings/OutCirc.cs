using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class OutCirc : Singleton<OutCirc, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            time--;
            end -= start;
            return end * Mathf.Sqrt(1 - time * time) + start;
        }
    }
}