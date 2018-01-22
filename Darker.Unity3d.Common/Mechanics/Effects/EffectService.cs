using System.Collections;
using UnityEngine;

namespace Darker.Unity3d
{
    public abstract class EffectService
    {
        protected readonly ICoroutineRunner CoroutineService;
        protected readonly ITimeService TimeService;

        protected EffectService(ITimeService timeService, ICoroutineRunner coroutineService)
        {
            TimeService = timeService;
            CoroutineService = coroutineService;
        }

        protected IEnumerator Co_Effect(IEffect effect, float duration, IEasing easing)
        {
            effect.Start();
            var timer = 0f;
            while (timer < 1)
            {
                timer += TimeService.Delta / duration;
                effect.Update(easing.Ease(timer));
                yield return null;
            }
            effect.End();
        }

        protected void LerpEffect(IEffect effect, float duration,
            IEasing easing)
        {
            easing = easing ?? new EaseFromCurve(AnimationCurve.EaseInOut(0, 0, 1, 1));
            CoroutineService.Start(Co_Effect(effect, duration, easing));
        }
    }
}