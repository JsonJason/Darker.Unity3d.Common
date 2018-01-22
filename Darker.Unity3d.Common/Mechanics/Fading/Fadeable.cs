namespace Darker.Unity3d
{
    /// <summary>
    /// An element that can have its opacity faded
    /// </summary>
    public interface Fadeable
    {
        /// <summary>
        /// The visibility from a range of 0 to 1.
        /// </summary>
        float Opacity { get; set; }
    }
}