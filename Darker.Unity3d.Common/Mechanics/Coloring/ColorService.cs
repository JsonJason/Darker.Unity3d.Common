using UnityEngine;

namespace Darker.Unity3d
{
    public class ColorService : EffectService
    {
        public ColorService(ITimeService timeService, ICoroutineRunner coroutineService) : base(timeService,
            coroutineService)
        {
        }

        public void SetColorTo(IColorable colorable, Color target)
        {
            colorable.ApplyColor(target);
        }

        public void FadeColorTo(IColorable colorable, Color target, float duration,
            IEasing easing)
        {
            LerpEffect(new ColorEffect(colorable, target), duration, easing);
        }
    }
}