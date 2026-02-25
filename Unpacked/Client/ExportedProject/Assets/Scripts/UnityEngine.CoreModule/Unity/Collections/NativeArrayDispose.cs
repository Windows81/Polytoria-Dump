namespace Unity.Collections;

[NativeContainer]
[Token(Token = "0x2000041")]
internal struct NativeArrayDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000B3")]
	internal Void* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B4")]
	internal Allocator m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x1939360", Offset = "0x1938560", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public void Dispose() { }

}

