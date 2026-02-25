namespace System.Collections.Generic;

[Token(Token = "0x2000605")]
internal sealed class ShortEnumEqualityComparer : EnumEqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xC8FC10", Offset = "0xC8EE10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C32")]
	public ShortEnumEqualityComparer`1() { }

	[Address(RVA = "0xF0D4A0", Offset = "0xF0C6A0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C33")]
	public ShortEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xF153B0", Offset = "0xF145B0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(short), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C34")]
	public virtual int GetHashCode(T obj) { }

}

