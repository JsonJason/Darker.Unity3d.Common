using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class OutBounce : Singleton<OutBounce, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;
            time /= 1f;
            end -= start;
            if (time < 1 / 2.75f)
                return end * (7.5625f * time * time) + start;
            if (time < 2 / 2.75f)
            {
                time -= 1.5f / 2.75f;
                return end * (7.5625f * time * time + .75f) + start;
            }
            if (time < 2.5 / 2.75)
            {
                time -= 2.25f / 2.75f;
                return end * (7.5625f * time * time + .9375f) + start;
            }
            time -= 2.625f / 2.75f;
            return end * (7.5625f * time * time + .984375f) + start;
        }
    }
}