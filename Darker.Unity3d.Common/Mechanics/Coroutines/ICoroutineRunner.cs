using System.Collections;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Starts and Stops Coroutines, Enumerators designed to be run across many frames
    /// </summary>
    public interface ICoroutineRunner
    {
        /// <summary>
        ///     Starts running the enumerator
        /// </summary>
        /// <param name="enumerator">enumerator</param>
        void Start(IEnumerator enumerator);

        /// <summary>
        ///     Stops running the enumerator
        /// </summary>
        /// <param name="enumerator">enumerator</param>
        void Stop(IEnumerator enumerator);

        /// <summary>
        ///     Stops all running enumerators
        /// </summary>
        void StopAll();
    }
}