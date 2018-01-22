using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InBounce : Singleton<InBounce, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            end -= start;
            var d = 1f;
            return end - OutBounce.Instance.Ease(d - time) + start;
        }
    }
}