using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Performs a rayast through a camera using the mouse position
    /// </summary>
    public class MouseScreenRaycaster : RayRaycaster
    {
        private readonly Camera _camera;

        /// <summary>
        ///     Constructs a raycaster using a mouse through a camera
        /// </summary>
        /// <param name="camera">Camera to raycast from</param>
        public MouseScreenRaycaster(Camera camera)
        {
            _camera = camera;
        }

        /// <inheritdoc />
        protected override Ray CreateRay() => _camera.ScreenPointToRay(Input.mousePosition);
    }
}