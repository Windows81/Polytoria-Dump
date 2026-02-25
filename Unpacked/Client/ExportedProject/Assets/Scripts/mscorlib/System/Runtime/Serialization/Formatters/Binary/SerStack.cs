namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000421")]
internal sealed class SerStack
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001145")]
	internal Object[] objects; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001146")]
	internal string stackId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001147")]
	internal int top; //Field offset: 0x20

	[Address(RVA = "0x13CA180", Offset = "0x13C9380", Length = "0x78")]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(HeaderHandler), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerObjectInfoInit), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
	[CalledBy(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext), typeof(InternalFE), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ObjectReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectProgress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F24")]
	internal SerStack(string stackId) { }

	[Address(RVA = "0x13C9EA0", Offset = "0x13C90A0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F27")]
	internal void IncreaseCapacity() { }

	[Address(RVA = "0x13C9F40", Offset = "0x13C9140", Length = "0x8")]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMessageEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001F2A")]
	internal bool IsEmpty() { }

	[Address(RVA = "0x13C9F90", Offset = "0x13C9190", Length = "0x37")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMemberEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001F28")]
	internal object Peek() { }

	[Address(RVA = "0x13C9F50", Offset = "0x13C9150", Length = "0x3A")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F29")]
	internal object PeekPeek() { }

	[Address(RVA = "0x13C9FD0", Offset = "0x13C91D0", Length = "0x73")]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseSerializedStreamHeaderEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F26")]
	internal object Pop() { }

	[Address(RVA = "0x13CA050", Offset = "0x13C9250", Length = "0x125")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001F25")]
	internal void Push(object obj) { }

}

