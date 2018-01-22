using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Colors a material by a named property
    /// </summary>
    public class MaterialPropertyColorer : IMaterialColorer
    {
        private readonly string _propertyName;

        /// <summary>
        ///     Colors a material by a property of type color
        /// </summary>
        /// <param name="propertyName">property to color</param>
        public MaterialPropertyColorer(string propertyName)
        {
            _propertyName = propertyName;
        }

        /// <inheritdoc />
        public void Apply(Material material, Color color) => material.SetColor(_propertyName, color);

        /// <inheritdoc />
        public Color CurrentMaterialColor(Material material) => material.GetColor(_propertyName);
    }
}