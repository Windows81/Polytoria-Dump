namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000419")]
internal sealed class SerObjectInfoCache
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010CA")]
	internal string fullTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010CB")]
	internal string assemblyString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010CC")]
	internal bool hasTypeForwardedFrom; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010CD")]
	internal MemberInfo[] memberInfos; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40010CE")]
	internal String[] memberNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40010CF")]
	internal Type[] memberTypes; //Field offset: 0x38

	[Address(RVA = "0x13A9EC0", Offset = "0x13A90C0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001EA9")]
	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	[Address(RVA = "0x13A9F30", Offset = "0x13A9130", Length = "0x96")]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInformation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EAA")]
	internal SerObjectInfoCache(Type type) { }

}

