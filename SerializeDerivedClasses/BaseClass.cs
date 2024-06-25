namespace SerializeDerivedClasses;

using System.Text.Json.Serialization;

[JsonDerivedType(typeof(BaseClass), typeDiscriminator: "BaseClass")]
[JsonDerivedType(typeof(DerivedClass), typeDiscriminator: "DerivedClass")]
class BaseClass
{
    public string BaseProperty { get; set; } = "Base Property";
}
