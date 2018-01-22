namespace Darker.Unity3d
{
    /// <summary>
    ///     An easing function.
    ///     Takes a time parameter and eases it
    ///     into a more intereseting curve
    /// </summary>
    public interface IEasing
    {
        /// <summary>
        ///     Eases a time value based on an easing function
        /// </summary>
        /// <param name="time">The raw time value</param>
        /// <returns>The eased time value</returns>
        float Ease(float time);
    }
}