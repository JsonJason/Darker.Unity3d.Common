namespace Darker.Unity3d
{
    /// <summary>
    ///     Represents an object that can take an interpolation value
    ///     from 0 -1 (potentially raw outer bounds) and be acted upon
    /// </summary>
    public interface IInterpolatable
    {
        /// <summary>
        ///     Interpolate self based on value
        /// </summary>
        /// <param name="interval">The value to interpolate with (traditionally 0-1)</param>
        void Interpolate(float interval);
    }
}