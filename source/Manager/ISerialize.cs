namespace Manager
{
    public interface ISerialize
    {
        object Load();

        void Save();
    }
}
