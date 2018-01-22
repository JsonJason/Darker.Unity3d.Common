using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InQuint : Singleton<InQuint, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return end * time * time * time * time * time + start;
        }
    }
}