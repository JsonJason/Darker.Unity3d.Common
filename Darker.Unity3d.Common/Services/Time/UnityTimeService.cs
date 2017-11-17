using UnityEngine;

namespace Darker.Unity3d
{
    public class UnityTimeService : ITimeService
    {
        private static UnityTimeService _instance;

        public UnityTimeService Instance => _instance ?? (_instance = new UnityTimeService());

        public float Delta => Time.deltaTime;

        public float TimeScale
        {
            get => Time.timeScale;
            set => Time.timeScale = value;
        }

        public float StopTime()
        {
            var scale = TimeScale;
            TimeScale = 0;
            return scale;
        }
    }
}