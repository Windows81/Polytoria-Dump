namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000418")]
internal sealed class SerObjectInfoInit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010C7")]
	internal Hashtable seenBeforeTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010C8")]
	internal int objectInfoIdCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010C9")]
	internal SerStack oiPool; //Field offset: 0x20

	[Address(RVA = "0x13A9FD0", Offset = "0x13A91D0", Length = "0xB6")]
	[CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HeaderHandler), typeof(__BinaryParser), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001EA8")]
	public SerObjectInfoInit() { }

}

