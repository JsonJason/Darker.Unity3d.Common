using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InOutQuart : Singleton<InOutQuart, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            time /= .5f;
            end -= start;
            if (time < 1) return end * 0.5f * time * time * time * time + start;
            time -= 2;
            return -end * 0.5f * (time * time * time * time - 2) + start;
        }
    }
}