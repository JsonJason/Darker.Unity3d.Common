using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class SmootherStep : Singleton<SmootherStep, IEasing>, IEasing
    {
        public float Ease(float t) => t * t * t * (t * (6f * t - 15f) + 10f);
    }
}