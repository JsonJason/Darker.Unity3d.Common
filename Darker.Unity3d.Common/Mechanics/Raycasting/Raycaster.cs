using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Raycasts into the game world and returns a hitinfo on success
    /// </summary>
    public interface Raycaster
    {
        /// <summary>
        ///     Did the raycast hit something
        /// </summary>
        bool SomethingHit { get; }

        /// <summary>
        ///     Perform the raycast
        /// </summary>
        void PerformRaycast();

        /// <summary>
        ///     Hit Data
        /// </summary>
        /// <returns>RaycastHitInfo</returns>
        RaycastHit GetHitInfo();
    }
}