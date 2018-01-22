using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class OutQuad : Singleton<OutQuad, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            end -= start;
            return -end * time * (time - 2) + start;
        }
    }
}