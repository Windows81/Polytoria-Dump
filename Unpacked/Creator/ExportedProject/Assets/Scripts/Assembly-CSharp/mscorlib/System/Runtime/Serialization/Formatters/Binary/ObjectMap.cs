namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000410")]
internal sealed class ObjectMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001035")]
	internal string objectName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001036")]
	internal Type objectType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001037")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001038")]
	internal Object[] typeInformationA; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001039")]
	internal Type[] memberTypes; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400103A")]
	internal String[] memberNames; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400103B")]
	internal ReadObjectInfo objectInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400103C")]
	internal bool isInitObjectInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400103D")]
	internal ObjectReader objectReader; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400103E")]
	internal int objectId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400103F")]
	internal BinaryAssemblyInfo assemblyInfo; //Field offset: 0x60

	[Address(RVA = "0x139F590", Offset = "0x139E790", Length = "0x2B2")]
	[CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(String[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo)}, ReturnType = typeof(ObjectMap))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Type)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(ObjectManager), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(bool)}, ReturnType = typeof(ReadObjectInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E29")]
	internal ObjectMap(string objectName, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[Address(RVA = "0x139F070", Offset = "0x139E270", Length = "0x51F")]
	[CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(BinaryTypeEnum[]), typeof(Object[]), typeof(Int32[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo), typeof(SizedArray)}, ReturnType = typeof(ObjectMap))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Type)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryAssemblyInfo), typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001E2A")]
	internal ObjectMap(string objectName, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[Address(RVA = "0x139EF00", Offset = "0x139E100", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(String[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E2C")]
	internal static ObjectMap Create(string name, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[Address(RVA = "0x139EFA0", Offset = "0x139E1A0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(BinaryTypeEnum[]), typeof(Object[]), typeof(Int32[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo), typeof(SizedArray)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E2D")]
	internal static ObjectMap Create(string name, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[Address(RVA = "0x139EEB0", Offset = "0x139E0B0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadObjectInfo), Member = "InitDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo&), typeof(Object[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E2B")]
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Object[] memberData) { }

}

