using SerializeDerivedClasses;
using System.Text.Json;

BaseClass baseClass = new DerivedClass(); // this BaseClass is a DerivedClass at runtime

// Polymorphic serialization with type discriminator
var polymorphicJson = JsonSerializer.Serialize(baseClass, SerializerOptions.Options);

// Polymorphic deserialization
var PolymorphicBaseClass = JsonSerializer.Deserialize<BaseClass>(polymorphicJson);

Console.WriteLine(polymorphicJson);

Console.WriteLine($"Polymorphic deserialization as: {PolymorphicBaseClass?.GetType()}");
Console.WriteLine();
Console.WriteLine($"BaseClass is DerivedClass: {PolymorphicBaseClass is DerivedClass}");


