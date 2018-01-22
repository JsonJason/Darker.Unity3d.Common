using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class InCirc : Singleton<InCirc, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return -end * (Mathf.Sqrt(1 - time * time) - 1) + start;
        }
    }
}