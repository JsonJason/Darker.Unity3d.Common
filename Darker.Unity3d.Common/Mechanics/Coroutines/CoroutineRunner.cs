using System.Collections;
using UnityEngine;

namespace Darker.Unity3d
{
    /// <summary>
    ///     Runs all coroutines using the provided MonoBehaviour as the parent.
    /// </summary>
    public class CoroutineRunner : ICoroutineRunner
    {
        private readonly MonoBehaviour _owner;

        /// <summary>
        ///     Constructs a coroutine runner that uses a monobehaviour, standard unity implementation
        /// </summary>
        /// <param name="owner">MonoBehaviour to host the coroutines</param>
        public CoroutineRunner(MonoBehaviour owner)
        {
            _owner = owner;
        }

        /// <inheritdoc />
        public void Start(IEnumerator enumerator)
        {
            _owner.StartCoroutine(enumerator);
        }

        /// <inheritdoc />
        public void Stop(IEnumerator enumerator)
        {
            _owner.StartCoroutine(enumerator);
        }

        /// <inheritdoc />
        public void StopAll()
        {
            _owner.StopAllCoroutines();
        }
    }
}