using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class OutBack : Singleton<OutBack, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            var s = 1.70158f;
            end -= start;
            time = time - 1;
            return end * (time * time * ((s + 1) * time + s) + 1) + start;
        }
    }
}