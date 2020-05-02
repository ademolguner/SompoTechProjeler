using System.Text;

namespace SompoTech.Nuget.DataConvert
{
    public static class SompoObjectConverter
    {
        public static T GetObjectFromJson<T>(string jsonString) where T : class, new()
        {
            var objectData = new ObjectConvertFormatManager().JsonToObject<T>(jsonString);
            return objectData;
        }
        public static string GetJsonFromObject<T>(T entityObject) where T : class, new()
        {
            var jsonString = new ObjectConvertFormatManager().ObjectToJson(entityObject);
            return jsonString;
        }
        public static T GetObjectFromArray<T>(byte[] rawBytes) where T : class, new()
        {
            var stringData = Encoding.UTF8.GetString(rawBytes);
            return GetObjectFromJson<T>(stringData);
        }
    }
}
