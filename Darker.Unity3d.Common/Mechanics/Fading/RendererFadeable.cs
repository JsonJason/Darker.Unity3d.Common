using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fadeable using a renderer
    /// </summary>
    public abstract class RendererFadeable : Fadeable
    {
        protected readonly Renderer Renderer;
        private float _opacity;

        /// <summary>
        ///     Constructs a render fadeable
        /// </summary>
        /// <param name="renderer">The renderer whos material should be faded</param>
        protected RendererFadeable(Renderer renderer)
        {
            Renderer = renderer;
        }

        /// <summary>
        ///     The current Opacity level from 0 > 1
        /// </summary>
        public virtual float Opacity
        {
            get => _opacity;
            set
            {
                _opacity = value;
                UpdateRenderer();
            }
        }

        /// <summary>
        ///     Perform the update to the renderers opacity
        /// </summary>
        protected abstract void UpdateRenderer();
    }
}