using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Using a chosen transform, raycasts forward and returns the hit information
    /// </summary>
    public class TransformRaycaster : RayRaycaster
    {
        private readonly Transform _item;

        /// <summary>
        ///     Constructs a raycaster that uses a transform to create the ray
        /// </summary>
        /// <param name="item">Transform to generate rays from</param>
        public TransformRaycaster(Transform item)
        {
            _item = item;
        }

        /// <inheritdoc />
        protected override Ray CreateRay() => new Ray(_item.position, _item.forward);
    }
}