namespace Darker.Unity3d
{
    public interface IEffect
    {
        void Start();
        void Update(float value);
        void End();
    }
}