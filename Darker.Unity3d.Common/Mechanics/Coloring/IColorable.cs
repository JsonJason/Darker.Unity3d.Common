using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    /// An element that can be coloured
    /// </summary>
    public interface IColorable
    {
        /// <summary>
        /// The current color
        /// </summary>
        Color CurrentColor { get; }

        /// <summary>
        /// Applies a new color
        /// </summary>
        /// <param name="color">Color to apply</param>
        void ApplyColor(Color color);
    }

    /// <summary>
    /// Applies a color to a material
    /// </summary>
    public interface IMaterialColorer
    {
        /// <summary>
        /// Applys a color to a material
        /// </summary>
        /// <param name="material">material to color</param>
        /// <param name="color">color to apply</param>
        void Apply(Material material, Color color);

        /// <summary>
        /// The color currently on the material
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        Color CurrentMaterialColor(Material material);
    }
}