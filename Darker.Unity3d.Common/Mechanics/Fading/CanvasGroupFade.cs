using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Fabeable wrapper for a ui canvas group
    /// </summary>
    public class CanvasGroupFade : Fadeable
    {
        private readonly CanvasGroup _group;

        /// <summary>
        ///     Constructs a canvas group fader
        /// </summary>
        /// <param name="group">The group whos elements will be faded</param>
        public CanvasGroupFade(CanvasGroup group)
        {
            _group = group;
        }

        /// <summary>
        ///     The current group opacity
        /// </summary>
        public float Opacity
        {
            get => _group.alpha;
            set => _group.alpha = value;
        }
    }
}