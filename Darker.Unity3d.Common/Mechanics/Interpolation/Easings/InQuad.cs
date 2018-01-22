using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class InQuad : Singleton<InQuad, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return end * time * time + start;
        }
    }
}