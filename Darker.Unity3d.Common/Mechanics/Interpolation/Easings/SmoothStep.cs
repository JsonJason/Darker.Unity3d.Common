using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class SmoothStep : Singleton<SmoothStep, IEasing>, IEasing
    {
        public float Ease(float t) => t * t * (3f - 2f * t);
    }
}