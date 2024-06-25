# SerializeDerivedClasses

## Polymorphic serialization and deserialization

using attribute "JsonDerivedType" with typeDiscriminator

[JsonDerivedType(typeof(BaseClass), typeDiscriminator: "BaseClass")]  
[JsonDerivedType(typeof(DerivedClass), typeDiscriminator: "DerivedClass")]
