using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Makes a renderer colorable by its material
    /// </summary>
    public class RendererColorer : IColorable
    {
        private readonly IMaterialColorer _materialColorer;
        private readonly Renderer _renderer;

        /// <summary>
        ///     Colors an element by its material
        /// </summary>
        /// <param name="renderer">renderer to color</param>
        /// <param name="materialColorer">means of apply color to a renderer</param>
        public RendererColorer(Renderer renderer, IMaterialColorer materialColorer)
        {
            _renderer = renderer;
            _materialColorer = materialColorer;
        }

        /// <inheritdoc />
        public Color CurrentColor => _materialColorer.CurrentMaterialColor(_renderer.material);

        /// <inheritdoc />
        public void ApplyColor(Color color) => _materialColorer.Apply(_renderer.material, color);
    }
}