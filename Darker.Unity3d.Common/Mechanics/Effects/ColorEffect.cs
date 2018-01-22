using UnityEngine;

namespace Darker.Unity3d
{
    public class ColorEffect : IEffect
    {
        private readonly IColorable _colorable;
        private readonly Color _desired;

        private Color _startColor;

        public ColorEffect(IColorable colorable, Color desired)
        {
            _colorable = colorable;
            _desired = desired;
        }

        public void Start()
        {
            _startColor = _colorable.CurrentColor;
        }

        public void Update(float value)
        {
            var deltaColor = Color.Lerp(_startColor, _desired, value);
            _colorable.ApplyColor(deltaColor);
        }

        public void End()
        {
            _colorable.ApplyColor(_desired);
        }
    }
}