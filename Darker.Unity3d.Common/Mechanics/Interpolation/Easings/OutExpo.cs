using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class OutExpo : Singleton<OutExpo, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return end * (-Mathf.Pow(2, -10 * time) + 1) + start;
        }
    }
}