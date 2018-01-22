using JS;
using UnityEngine;

public class ColorService : EffectService, IColorService
{
    public void SetColorTo(IColorable colorable, Color target)
    {
        colorable.ApplyColor(target);
    }

    public void FadeColorTo(IColorable colorable, Color target, float duration,
        IEasing easing)
    {
        LerpEffect(new ColorEffect(colorable, target), duration, easing);
    }

    public ColorService(ITimeService timeService, ICoroutineService coroutineService) : base(timeService, coroutineService)
    {
    }
}