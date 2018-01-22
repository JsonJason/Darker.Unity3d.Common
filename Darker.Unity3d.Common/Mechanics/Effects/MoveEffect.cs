using UnityEngine;

namespace Darker.Unity3d
{
    public class MoveEffect : IEffect
    {
        private readonly IMovable _mover;
        private readonly Vector3 _target;

        private Vector3 _startPosition;


        public MoveEffect(IMovable mover, Vector3 target)
        {
            _mover = mover;
            _target = target;
        }

        public void Start()
        {
            _startPosition = _mover.Position;
        }

        public void Update(float value)
        {
            var deltaPosition = Vector3.LerpUnclamped(_startPosition, _target, value);
            _mover.SetPosition(deltaPosition);
        }

        public void End()
        {
            _mover.SetPosition(_target);
        }
    }
}