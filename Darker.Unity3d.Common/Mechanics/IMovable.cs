using UnityEngine;

namespace Darker.Unity3d
{
    public interface IMovable
    {
        Vector3 Position { get; }

        void SetPosition(Vector3 position);
    }

    public interface IMoveService
    {
        void SetPositionTo(IMovable movable, Vector3 position);
        void MoveTo(IMovable movable, Vector3 position, float duration, IEasing easing = null);
    }

    public class MoveService : EffectService, IMoveService
    {
        public MoveService(ITimeService timeService, ICoroutineRunner coroutineService) : base(timeService,
            coroutineService)
        {
        }

        public void SetPositionTo(IMovable movable, Vector3 position)
        {
            movable.SetPosition(position);
        }

        public void MoveTo(IMovable movable, Vector3 position, float duration, IEasing easing = null)
        {
            LerpEffect(new MoveEffect(movable, position), duration, easing);
        }
    }
}