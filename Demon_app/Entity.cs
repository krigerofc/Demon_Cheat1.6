using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Demon_app;

namespace Demon_app
{
    public class Entity
    {
        public int ID { get; set; }
        public float Healt { get; set; }
        public int Team { get; set; }
        public Vector3 Position { get; set; }
        public float Distance { get; set; }
        public IntPtr address { get; set; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Healt: {Healt}");
            stringBuilder.AppendLine($"Team: {Team}");
            stringBuilder.AppendLine($"Position: {Position}");
            stringBuilder.AppendLine($"Distance: {Distance}");
            stringBuilder.AppendLine($"address: {address}");

            return stringBuilder.ToString();
        }
    }
}