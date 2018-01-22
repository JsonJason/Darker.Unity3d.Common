using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fadeable of a materials color
    /// </summary>
    public class MaterialColorFadeable : RendererFadeable
    {
        /// <summary>
        ///     Constructs a material color fadeable
        /// </summary>
        /// <param name="renderer">render to fade</param>
        public MaterialColorFadeable(Renderer renderer) : base(renderer)
        {
        }

        /// <inheritdoc />
        protected override void UpdateColor()
        {
            var c = Renderer.material.color;
            c.a = Opacity;
            Renderer.material.color = c;
        }
    }
}