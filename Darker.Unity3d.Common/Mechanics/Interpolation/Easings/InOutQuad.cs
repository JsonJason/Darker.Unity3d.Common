using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InOutQuad : Singleton<InOutQuad, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            time /= .5f;
            end -= start;
            if (time < 1) return end * 0.5f * time * time + start;
            time--;
            return -end * 0.5f * (time * (time - 2) - 1) + start;
        }
    }
}