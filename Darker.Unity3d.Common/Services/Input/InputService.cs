namespace Darker.Unity3d
{
    /// <summary>
    ///     Provides state of the current input device
    /// </summary>
    public interface InputService
    {
        /// <summary>
        ///     Checks if <paramref name="action" /> is down this frame but up in the previous one
        /// </summary>
        /// <param name="action">Input action to check</param>
        /// <returns>boolean state of <paramref name="action" /></returns>
        bool GetDown(string action);

        /// <summary>
        ///     Checks if <paramref name="action" /> is down this frame and was also down in the previous one
        /// </summary>
        /// <param name="action">Input action to check</param>
        /// <returns>boolean state of <paramref name="action" /></returns>
        bool Get(string action);

        /// <summary>
        ///     Checks if <paramref name="action" /> is up this frame and was down in the previous one
        /// </summary>
        /// <param name="action">Input action to check</param>
        /// <returns>boolean state of <paramref name="action" /></returns>
        bool GetUp(string action);

        /// <summary>
        ///     Returns the float value of <paramref name="axis" /> clamped between 0 and 1
        /// </summary>
        /// <param name="axis">Input axis</param>
        /// <returns>0-1 float value of <paramref name="axis" /></returns>
        float GetAxis(string axis);

        /// <summary>
        ///     Returns the unclamped float value of <paramref name="axis" />
        /// </summary>
        /// <param name="axis">Input axis</param>
        /// <returns>float value of <paramref name="axis" /></returns>
        float GetAxisRaw(string axis);
    }
}