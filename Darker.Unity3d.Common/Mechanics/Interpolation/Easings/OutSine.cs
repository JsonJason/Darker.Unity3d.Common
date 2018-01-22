using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class OutSine : Singleton<OutSine, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return end * Mathf.Sin(time * (Mathf.PI * 0.5f)) + start;
        }
    }
}