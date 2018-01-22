using System;
using System.Collections;
using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fades a fadeable element over time
    /// </summary>
    public class Fader
    {
        private readonly ICoroutineRunner _runner;

        private IEnumerator _current;

        /// <summary>
        ///     Constructs a fader
        /// </summary>
        /// <param name="runner">The coroutine runner to use when fading is running</param>
        public Fader(ICoroutineRunner runner)
        {
            _runner = runner;
        }

        /// <summary>
        ///     Is currently fading something
        /// </summary>
        public bool IsFading { get; private set; }

        /// <summary>
        ///     Fades in a fadeable
        /// </summary>
        /// <param name="fadable">The item to fade</param>
        /// <param name="overXSeconds">duration of fade</param>
        /// <param name="curve">curve to fade by</param>
        /// <param name="onComplete">action to perform on complete of a fade</param>
        public void FadeIn(Fadeable fadable, float overXSeconds = 1, AnimationCurve curve = null,
            Action onComplete = null)
        {
            if (IsFading) return;
            _current = CoFading(fadable, overXSeconds, fadable.Opacity, 1, curve, onComplete);
            _runner.Start(_current);
        }

        /// <summary>
        ///     Fades out a fadeable
        /// </summary>
        /// <param name="fadable">The item to fade</param>
        /// <param name="overXSeconds">duration of fade</param>
        /// <param name="curve">curve to fade by</param>
        /// <param name="onComplete">action to perform on complete of a fade</param>
        public void FadeOut(Fadeable fadable, float overXSeconds = 1, AnimationCurve curve = null,
            Action onComplete = null)
        {
            if (IsFading) return;
            _current = CoFading(fadable, overXSeconds, fadable.Opacity, 0, curve, onComplete);
            _runner.Start(_current);
        }

        /// <summary>
        ///     Stop the currently running fade
        /// </summary>
        public void StopFading()
        {
            if (IsFading) _runner.Stop(_current);
        }

        private IEnumerator CoFading(Fadeable fadable, float duration, float from, float to, AnimationCurve curve,
            Action onComplete)
        {
            curve = curve ?? AnimationCurve.Linear(0, 0, 1, 1);
            IsFading = true;
            float timer = 0;
            while (timer < 1)
            {
                timer += Time.deltaTime / duration;
                fadable.Opacity = Mathf.Lerp(from, to, timer);
                yield return null;
            }
            IsFading = false;
            onComplete?.Invoke();
        }
    }
}