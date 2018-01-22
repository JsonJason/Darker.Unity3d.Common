using DarkerSmile.Common;

namespace Darker.Unity3d
{
    public class OutQuart : Singleton<OutQuart, IEasing>, IEasing
    {
        public float Ease(float time)
        {
            float start = 0;
            float end = 1;

            time--;
            end -= start;
            return -end * (time * time * time * time - 1) + start;
        }
    }
}