using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InBack : Singleton<InBack, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            end -= start;
            time /= 1;
            var s = 1.70158f;
            return end * time * time * ((s + 1) * time - s) + start;
        }
    }
}