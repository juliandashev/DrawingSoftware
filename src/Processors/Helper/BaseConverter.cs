using Draw.src.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace Draw.src.Processors.Helper
{
    public class BaseConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (serializer == null || value == null)
            {
                writer.WriteNull();
                return;
            }

            JObject jsonObject = new JObject
            {
                { "Type", value.GetType().Name }
            };

            // Create the shape object and add it to jsonObject
            JObject shapeObject = JObject.FromObject(value, serializer);
            jsonObject.Add("Shape", shapeObject);

            jsonObject.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            var type = Type.GetType(jsonObject["Type"].ToString());
            var shape = jsonObject["Shape"].ToObject(type, serializer);

            return shape;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(Shape).IsAssignableFrom(objectType);
        }
    }
}
