namespace RealEstateDataTool.Utils
{
    public class Generics
    {
        private T ObjectFromDictionary<T>(IDictionary<string, string> dict) where T : class
        {
            Type type = typeof(T);
            T result = (T)Activator.CreateInstance(type);
            foreach (var item in dict)
            {
                type.GetProperty(item.Key).SetValue(result, item.Value, null);
            }
            return result;
        }
    }
}
