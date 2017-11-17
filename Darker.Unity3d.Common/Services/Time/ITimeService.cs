namespace Darker.Unity3d
{
    /// <summary>
    ///     Provides data about the current timescale and time between updates
    /// </summary>
    public interface ITimeService
    {
        /// <summary>
        ///     Time since last update
        /// </summary>
        float Delta { get; }

        /// <summary>
        ///     Current Scale of Time.
        ///     <example>0 - Stopped,1 - Normal,2 - DoubleTime etc</example>
        /// </summary>
        float TimeScale { get; set; }

        /// <summary>
        ///     Stop Time
        /// </summary>
        /// <returns>The <see cref="TimeScale" /> before time was stopped</returns>
        float StopTime();
    }
}