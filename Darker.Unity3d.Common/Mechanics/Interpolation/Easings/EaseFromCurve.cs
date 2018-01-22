using UnityEngine;

namespace Darker.Unity3d
{
    public class EaseFromCurve : IEasing
    {
        public AnimationCurve Curve;

        public EaseFromCurve(AnimationCurve curve)
        {
            Curve = curve;
        }

        public float Ease(float time) => Curve.Evaluate(time);
    }
}