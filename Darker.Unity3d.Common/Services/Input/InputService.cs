namespace Darker.Unity3d
{
    public interface InputService
    {
        bool GetDown(string action);
        bool Get(string action);
        bool GetUp(string action);

        float GetAxis(string name);
        float GetAxisRaw(string name);
    }
}