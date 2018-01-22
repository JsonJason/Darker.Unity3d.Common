using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InOutBack : Singleton<InOutBack, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            var s = 1.70158f;
            end -= start;
            time /= .5f;
            if (time < 1)
            {
                s *= 1.525f;
                return end * 0.5f * (time * time * ((s + 1) * time - s)) + start;
            }
            time -= 2;
            s *= 1.525f;
            return end * 0.5f * (time * time * ((s + 1) * time + s) + 2) + start;
        }
    }
}