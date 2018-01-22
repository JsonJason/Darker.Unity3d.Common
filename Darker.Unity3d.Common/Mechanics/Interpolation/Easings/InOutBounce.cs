using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InOutBounce : Singleton<InOutBounce, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            end -= start;
            var d = 1f;
            if (time < d * 0.5f) return InBounce.Instance.Ease(time * 2) * 0.5f + start;
            return OutBounce.Instance.Ease(time * 2 - d) * 0.5f + end * 0.5f + start;
        }
    }
}