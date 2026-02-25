namespace System.Collections.Generic;

[Token(Token = "0x2000604")]
internal sealed class SByteEnumEqualityComparer : EnumEqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xC8FC10", Offset = "0xC8EE10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2F")]
	public SByteEnumEqualityComparer`1() { }

	[Address(RVA = "0xF0D4A0", Offset = "0xF0C6A0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C30")]
	public SByteEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xF0D3F0", Offset = "0xF0C5F0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(sbyte), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C31")]
	public virtual int GetHashCode(T obj) { }

}

