using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fadeable of a materials color
    /// </summary>
    public class MaterialColorFadable : RendererFadeable
    {
        private readonly IMaterialColorer _colorer;

        /// <summary>
        ///     Constructs a material color fadeable
        /// </summary>
        /// <param name="renderer">render to fade</param>
        /// <param name="colorer">Colorer to apply a color to a material</param>
        public MaterialColorFadable(Renderer renderer, IMaterialColorer colorer) : base(renderer)
        {
            _colorer = colorer;
        }

        /// <inheritdoc />
        protected override void UpdateRenderer()
        {
            var c = _colorer.CurrentMaterialColor(Renderer.material);
            c.a = Opacity;
            _colorer.Apply(Renderer.material, c);
        }
    }
}