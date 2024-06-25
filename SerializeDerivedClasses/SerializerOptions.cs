using System.Text.Json;

namespace SerializeDerivedClasses
{
    internal static class SerializerOptions
    {
        public static JsonSerializerOptions Options = new() { WriteIndented = true };
    }
}
