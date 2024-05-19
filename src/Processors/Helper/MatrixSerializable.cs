using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Processors.Helper
{
    public class MatrixSerializable : ISerializable
    {
        private Matrix matrix;

        public MatrixSerializable(Matrix matrix)
        {
            this.matrix = matrix;
        }

        protected MatrixSerializable(SerializationInfo info, StreamingContext context)
        {
            // Deserialize matrix elements
            float[] elements = (float[])info.GetValue("Elements", typeof(float[]));

            matrix = new Matrix(
                elements[0], elements[1],
                elements[2], elements[3],
                elements[4], elements[5]
            );
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Serialize matrix elements
            float[] elements = matrix.Elements;
            info.AddValue("Elements", elements, typeof(float[]));
        }

        public Matrix GetMatrix()
        {
            return matrix;
        }
    }

    // Custom converter for Matrix
    public class MatrixConverter : JsonConverter<Matrix>
    {
        public override void WriteJson(JsonWriter writer, Matrix value, JsonSerializer serializer)
        {
            var elements = value.Elements;
            serializer.Serialize(writer, elements);
        }

        public override Matrix ReadJson(JsonReader reader, Type objectType, Matrix existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var elements = serializer.Deserialize<float[]>(reader);
            return new Matrix(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5]);
        }
    }
}
