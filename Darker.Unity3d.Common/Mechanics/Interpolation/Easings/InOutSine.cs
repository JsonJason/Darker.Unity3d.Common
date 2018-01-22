using DarkerSmile.Common;
using UnityEngine;

namespace Darker.Unity3d
{
    public class InOutSine : Singleton<InOutSine, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return -end * 0.5f * (Mathf.Cos(Mathf.PI * time) - 1) + start;
        }
    }
}