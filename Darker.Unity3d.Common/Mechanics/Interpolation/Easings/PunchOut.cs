using UnityEngine;

namespace Darker.Unity3d
{
    public class PunchOut : IEasing
    {
        private readonly float _amplitude;

        public PunchOut(float amplitude)
        {
            _amplitude = amplitude;
        }

        public float Ease(float time)
        {
            float s = 9;
            if (time == 0)
                return 0;
            if (time == 1)
                return 0;
            var period = 1 * 0.3f;
            s = period / (2 * Mathf.PI) * Mathf.Asin(0);
            return _amplitude * Mathf.Pow(2, -10 * time) * Mathf.Sin((time * 1 - s) * (2 * Mathf.PI) / period);
        }
    }
}