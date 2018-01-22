using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Material Colorer using the default material color
    /// </summary>
    public class StandardMaterialColorer : IMaterialColorer
    {
        /// <inheritdoc />
        public void Apply(Material material, Color color) => material.color = color;

        /// <inheritdoc />
        public Color CurrentMaterialColor(Material material) => material.color;
    }
}