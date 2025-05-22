namespace Manager
{
    public interface ISerialize
    {
        /// <summary>
        /// Loads data from XAML file
        /// </summary>
        /// <typeparam name="T">The type of object to load</typeparam>
        /// <returns>The deserialized object of type T, or null if loading fails</returns>
        T? Load<T>();

        /// <summary>
        /// Saves data into XAML file
        /// </summary>
        /// <typeparam name="T">The type of object to save</typeparam>
        /// <param name="data">The object to serialize</param>
        void Save<T>(T data);
    }
}
