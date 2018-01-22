using UnityEngine;

namespace Darker.Unity3d
{
    public class FadeEffect : IEffect
    {
        private readonly Fadeable _fadeable;
        private readonly float _from;
        private readonly float _to;

        public FadeEffect(Fadeable fadeable, float from, float to)
        {
            _fadeable = fadeable;
            _from = from;
            _to = to;
        }

        public void Start() => _fadeable.Opacity = _from;

        public void Update(float value) => _fadeable.Opacity = Mathf.Lerp(_from, _to, value);

        public void End() => _fadeable.Opacity = _to;
    }
}