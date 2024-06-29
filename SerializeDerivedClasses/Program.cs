using SerializeDerivedClasses;
using System.Text.Json;

BaseClass baseClass = new DerivedClass(); // this BaseClass is a DerivedClass at runtime

// Polymorphic serialization with type discriminator
var polymorphicJson = JsonSerializer.Serialize(baseClass, SerializerOptions.Options);

// Polymorphic deserialization
var PolymorphicBaseClass = JsonSerializer.Deserialize<BaseClass>(polymorphicJson);

Console.WriteLine(polymorphicJson);

Console.WriteLine($"\nPolymorphic deserialization as: {PolymorphicBaseClass?.GetType()}");
Console.WriteLine($"\nPolymorphic BaseClass is deserialized as DerivedClass: {PolymorphicBaseClass is DerivedClass}");


Console.WriteLine("\n\nPress any key to exit.");
Console.ReadKey(true);
