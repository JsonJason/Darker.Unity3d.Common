using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Using a constructed ray, performs a raycast
    /// </summary>
    public abstract class RayRaycaster : Raycaster
    {
        private RaycastHit _hit;

        /// <summary>
        ///     Perform the raycast
        /// </summary>
        public virtual void PerformRaycast() =>
            SomethingHit = Physics.Raycast(CreateRay(), out _hit);


        /// <summary>
        ///     Did the raycast hit something
        /// </summary>
        public virtual bool SomethingHit { get; private set; }

        /// <summary>
        ///     Hit Data
        /// </summary>
        /// <returns>RaycastHitInfo</returns>
        public virtual RaycastHit GetHitInfo() => _hit;

        /// <summary>
        ///     Constructs and returns a Ray to be used in casting
        /// </summary>
        /// <returns></returns>
        protected abstract Ray CreateRay();
    }
}