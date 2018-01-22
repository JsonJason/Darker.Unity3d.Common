using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fadeable of a materials color
    /// </summary>
    public class MaterialPropertyFadeable : RendererFadeable
    {
        private readonly string _propertyName;

        /// <summary>
        ///     Constructs a material color fadeable
        /// </summary>
        /// <param name="renderer">render to fade</param>
        /// <param name="propertyName">Material color property to change the color on</param>
        public MaterialPropertyFadeable(Renderer renderer, string propertyName) : base(renderer)
        {
            _propertyName = propertyName;
        }

        /// <inheritdoc />
        protected override void UpdateColor()
        {
            var c = Renderer.material.GetColor(_propertyName);
            c.a = Opacity;
            Renderer.material.SetColor(_propertyName, c);
        }
    }
}