namespace Manager
{
    public interface ISerialize
    {
        T Load<T>();

        void Save<T>(T data);
    }
}
