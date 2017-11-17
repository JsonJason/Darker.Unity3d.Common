using UnityEngine;

namespace Darker.Unity3d
{
    public class UnityInputService : InputService
    {
        public bool GetDown(string action) => Input.GetButtonDown(action);
        public bool Get(string action) => Input.GetButton(action);
        public bool GetUp(string action) => Input.GetButtonUp(action);
        public float GetAxis(string name) => Input.GetAxis(name);
        public float GetAxisRaw(string name) => Input.GetAxisRaw(name);
    }
}